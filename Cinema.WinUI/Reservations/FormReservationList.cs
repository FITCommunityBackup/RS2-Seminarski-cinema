﻿using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Shared.Constants;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.WinUI.Constants;
using Cinema.WinUI.Helpers;
using Cinema.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.WinUI.Movies
{
    public partial class FormReservationList : BaseDataGridForm
    {
        private readonly ApiService _reservationsApi = new ApiService("Reservations");
        private IList<string> _nextFormPrincipal;
        private bool _dateFilterCleared = true;

        public FormReservationList(IList<string> userPrincipal) : base(new string[] { Roles.Administrator, Roles.ContentEditor }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
        }

        private ReservationSearchRequest GetSearchRequest()
        {
            ReservationSearchRequest searchRequest = new ReservationSearchRequest();

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ReservationSearchRequest;
            searchRequest.PageIndex = pagination.PageIndex;
            searchRequest.CustomerFullName = txtCustomer.Text;
            searchRequest.Movie = txtMovie.Text;

            if (!_dateFilterCleared)
            {
                searchRequest.CreatedAt = dtpDateAdded.Value.ToUniversalTime();
            }
            else
            {
                searchRequest.CreatedAt = null;
            }

            Enum.TryParse(cmbStatus.SelectedValue.ToString(), out ReservationStatus timingStatus);
            searchRequest.Status = timingStatus;

            AddIncludes(ref searchRequest);

            if (int.TryParse(txtReservationId.Text, out int searchReservationId))
            {
                searchRequest.ReservationId = searchReservationId;
            }

            if (int.TryParse(txtPrice.Text, out int searchPrice))
            {
                searchRequest.Price = searchPrice;
            }

            return searchRequest;
        }

        private static ReservationSearchRequest AddIncludes(ref ReservationSearchRequest searchRequest)
        {
            searchRequest.Includes.Add("User");
            searchRequest.Includes.Add("Invoice");
            searchRequest.Includes.Add("Screening.Movie");
            return searchRequest;
        }

        private async Task LoadReservations(ReservationSearchRequest searchRequest)
        {
            var result = await _reservationsApi.Get<PagedList<ReservationDto>>(searchRequest);

            grdReservationsList.AutoGenerateColumns = false;
            grdReservationsList.DataSource = result.Data;

            SetReservationCancelationButtons();

            pagination.PageIndex = result.PageIndex;
            pagination.TotalPages = result.TotalPages;
        }

        private void SetReservationCancelationButtons()
        {
            for (int i = 0; i < grdReservationsList.Rows.Count; i++)
            {
                var row = grdReservationsList.Rows[i];
                string reservationActionHeaderText = "Action";

                int lastColumnIndex = GetColumnIndexByHeaderText(grdReservationsList, reservationActionHeaderText);

                ReservationDto reservation = row.DataBoundItem as ReservationDto;

                DataGridViewButtonCell buttonCell = row.Cells[lastColumnIndex] as DataGridViewButtonCell;
                buttonCell.ReadOnly = false;

                if (reservation.Status == ReservationStatus.CANCELED)
                {
                    buttonCell.Value = ReservationStatusButtonText.AUTHORIZE_RESERVATION;
                    buttonCell.Style.BackColor = Color.Green;
                }
                else
                {
                    buttonCell.Value = ReservationStatusButtonText.CANCEL_RESERVATION;
                    buttonCell.Style.BackColor = Color.Red;
                }

                buttonCell.ReadOnly = true;
            }
        }

        #region Event methods

        private async void FormReservationList_Load(object sender, EventArgs e)
        {
            this.grdReservationsList.DoubleBuffered(true);
            ReservationSearchRequest searchRequest = new ReservationSearchRequest();
            AddIncludes(ref searchRequest);

            searchRequest = ApplyDefaultSearchValues(searchRequest) as ReservationSearchRequest;

            cmbStatus.DataSource = Enum.GetValues(typeof(ReservationStatus));
            cmbStatus.SelectedItem = ReservationStatus.PAID;

            /* The handler is added code-first in order to prevent the SearchChanged method being triggered
            * in the value initialisation for status above.*/
            cmbStatus.SelectedIndexChanged += new EventHandler(SearchChanged);

            await LoadReservations(searchRequest);
        }

        private async void pagination_PageChanged(object sender, EventArgs e)
        {
            ReservationSearchRequest searchRequest = GetSearchRequest();
            await LoadReservations(searchRequest);
        }

        private async void grdReservationsList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = grdReservationsList.Columns[e.ColumnIndex];
            string clickedColumnName = clickedColumn.Name;

            ChangeSorting(clickedColumnName);

            ReservationSearchRequest searchRequest = GetSearchRequest();
            searchRequest.SortColumn = CurrentSortPropertyName;
            searchRequest.SortOrder = CurrentSortOrder;

            await LoadReservations(searchRequest);
        }

        private async void grdReservationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                int.TryParse(clickedRow.Cells["id"].Value.ToString(), out int reservationId);

                bool success = await _reservationsApi.Update<bool>(reservationId, null, "status");

                if (success)
                {
                    ReservationSearchRequest searchRequest = GetSearchRequest();
                    await LoadReservations(searchRequest);
                }
            }
        }

        private async void SearchChanged(object sender, EventArgs e)
        {
            ReservationSearchRequest searchRequest = GetSearchRequest();
            await LoadReservations(searchRequest);
        }

        private void grdReservationsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BindNavigationColumns(grdReservationsList, sender, e);
        }

        private void dtpDateAdded_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpDateAdded.CustomFormat = " ";
                dtpDateAdded.Format = DateTimePickerFormat.Custom;
                _dateFilterCleared = true;
            }

            SearchChanged(sender, e);
        }

        private void dtpDateAdded_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateAdded.Format == DateTimePickerFormat.Custom)
            {
                dtpDateAdded.Format = DateTimePickerFormat.Short;
            }

            _dateFilterCleared = false;
            SearchChanged(sender, e);
        }

        #endregion
    }
}
