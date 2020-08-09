﻿using Cinema.WinUI.Authorization;
using Cinema.WinUI.Movies;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public partial class FormMain : SecureBaseForm
    {
        private Form activeForm = null;

        private IList<string> _nextFormPrincipal;
        public FormMain(IList<string> userPrincipal) : base(new string[] { "Administrator","Content Editor" }, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_UserIsAllowed(object sender, EventArgs e)
        {
            btnScreenings.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnDashboard.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnMovies.Visible = this.ValidatedUserRoles.Contains("Administrator");
            btnLogin.Visible = false;
        }

        private void customizeDesign()
        {
            panelDashboardSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelDashboardSubmenu.Visible == true)
            {
                panelDashboardSubmenu.Visible = false;
            }
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelDashboardSubmenu);
            openChildForm(new FormDashboard(_nextFormPrincipal));
        }

        private void buttonDashaboardSubmenu1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashaboardSubmenu2_Click(object sender, EventArgs e)
        {

        }

        private void refreshParentForm(object sender, EventArgs e)
        {
            this.Owner.Refresh();
            this.Close();
        }

        private void openChildForm(SecureBaseForm childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMovieList frmMoviesList = new frmMovieList(_nextFormPrincipal);
            openChildForm(frmMoviesList);
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_nextFormPrincipal);
            openChildForm(loginForm);
        }
    }
}
