﻿namespace Cinema.WinUI.Events
{
    partial class FormEventDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventDetails));
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.logoSmall1 = new Cinema.WinUI.UserControls.Logos.LogoSmall();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.lblViewTitle = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtPromoter = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.lblPromoter = new System.Windows.Forms.Label();
            this.dtpEventTime = new System.Windows.Forms.DateTimePicker();
            this.lblScreeningTime = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.btnUpload = new Cinema.WinUI.UserControls.Buttons.UploadButton();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtEventTitle = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new Cinema.WinUI.UserControls.Buttons.DeleteButton();
            this.btnBack = new Cinema.WinUI.UserControls.Buttons.BackButton();
            this.btnSaveChanges = new Cinema.WinUI.UserControls.Buttons.SaveChangesButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNewsType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFormCorner = new System.Windows.Forms.Label();
            this.pnlCornerLabel = new System.Windows.Forms.Panel();
            this.pnlFormTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlCornerLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.White;
            this.pnlFormTitle.Controls.Add(this.logoSmall1);
            this.pnlFormTitle.Controls.Add(this.lblBreadCrumbsCurrent);
            this.pnlFormTitle.Controls.Add(this.lblBreadcrumbs);
            this.pnlFormTitle.Controls.Add(this.lblViewTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1155, 73);
            this.pnlFormTitle.TabIndex = 9;
            // 
            // logoSmall1
            // 
            this.logoSmall1.Location = new System.Drawing.Point(1005, 15);
            this.logoSmall1.Margin = new System.Windows.Forms.Padding(4);
            this.logoSmall1.Name = "logoSmall1";
            this.logoSmall1.Size = new System.Drawing.Size(124, 49);
            this.logoSmall1.TabIndex = 4;
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(120, 45);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(92, 13);
            this.lblBreadCrumbsCurrent.TabIndex = 3;
            this.lblBreadCrumbsCurrent.Text = "Event details";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(20, 45);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(100, 13);
            this.lblBreadcrumbs.TabIndex = 2;
            this.lblBreadcrumbs.Text = "Home / Events /";
            // 
            // lblViewTitle
            // 
            this.lblViewTitle.AutoSize = true;
            this.lblViewTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblViewTitle.Location = new System.Drawing.Point(20, 10);
            this.lblViewTitle.Name = "lblViewTitle";
            this.lblViewTitle.Size = new System.Drawing.Size(148, 25);
            this.lblViewTitle.TabIndex = 1;
            this.lblViewTitle.Text = "Event details";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.txtPromoter);
            this.pnlDetails.Controls.Add(this.lblPromoter);
            this.pnlDetails.Controls.Add(this.dtpEventTime);
            this.pnlDetails.Controls.Add(this.lblScreeningTime);
            this.pnlDetails.Controls.Add(this.dtpEventDate);
            this.pnlDetails.Controls.Add(this.lblSchedule);
            this.pnlDetails.Controls.Add(this.btnUpload);
            this.pnlDetails.Controls.Add(this.rtbDescription);
            this.pnlDetails.Controls.Add(this.txtEventTitle);
            this.pnlDetails.Controls.Add(this.cmbEventType);
            this.pnlDetails.Controls.Add(this.btnDelete);
            this.pnlDetails.Controls.Add(this.btnBack);
            this.pnlDetails.Controls.Add(this.btnSaveChanges);
            this.pnlDetails.Controls.Add(this.picImage);
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Controls.Add(this.lblNewsType);
            this.pnlDetails.Controls.Add(this.lblTitle);
            this.pnlDetails.ForeColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(24, 152);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlDetails.Size = new System.Drawing.Size(1105, 546);
            this.pnlDetails.TabIndex = 11;
            // 
            // txtPromoter
            // 
            this.txtPromoter.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPromoter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoter.ForeColor = System.Drawing.Color.Gray;
            this.txtPromoter.Location = new System.Drawing.Point(546, 162);
            this.txtPromoter.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.txtPromoter.Name = "txtPromoter";
            this.txtPromoter.Size = new System.Drawing.Size(528, 22);
            this.txtPromoter.TabIndex = 43;
            // 
            // lblPromoter
            // 
            this.lblPromoter.AutoSize = true;
            this.lblPromoter.BackColor = System.Drawing.Color.White;
            this.lblPromoter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromoter.ForeColor = System.Drawing.Color.Gray;
            this.lblPromoter.Location = new System.Drawing.Point(440, 165);
            this.lblPromoter.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblPromoter.Name = "lblPromoter";
            this.lblPromoter.Size = new System.Drawing.Size(65, 14);
            this.lblPromoter.TabIndex = 42;
            this.lblPromoter.Text = "Promoter";
            // 
            // dtpEventTime
            // 
            this.dtpEventTime.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpEventTime.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpEventTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventTime.Location = new System.Drawing.Point(546, 119);
            this.dtpEventTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEventTime.Name = "dtpEventTime";
            this.dtpEventTime.ShowUpDown = true;
            this.dtpEventTime.Size = new System.Drawing.Size(528, 22);
            this.dtpEventTime.TabIndex = 41;
            this.dtpEventTime.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEventDateAndTime_Validating);
            // 
            // lblScreeningTime
            // 
            this.lblScreeningTime.AutoSize = true;
            this.lblScreeningTime.BackColor = System.Drawing.Color.White;
            this.lblScreeningTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreeningTime.ForeColor = System.Drawing.Color.Gray;
            this.lblScreeningTime.Location = new System.Drawing.Point(440, 119);
            this.lblScreeningTime.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblScreeningTime.Name = "lblScreeningTime";
            this.lblScreeningTime.Size = new System.Drawing.Size(74, 14);
            this.lblScreeningTime.TabIndex = 40;
            this.lblScreeningTime.Text = "Event time";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpEventDate.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpEventDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Location = new System.Drawing.Point(546, 77);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(528, 22);
            this.dtpEventDate.TabIndex = 39;
            this.dtpEventDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEventDateAndTime_Validating);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.BackColor = System.Drawing.Color.White;
            this.lblSchedule.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.Color.Gray;
            this.lblSchedule.Location = new System.Drawing.Point(440, 77);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(76, 14);
            this.lblSchedule.TabIndex = 38;
            this.lblSchedule.Text = "Event date";
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpload.Location = new System.Drawing.Point(31, 252);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 32);
            this.btnUpload.TabIndex = 37;
            this.btnUpload.ButtonClicked += new System.EventHandler(this.btnUpload_ButtonClicked);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.ForeColor = System.Drawing.Color.Gray;
            this.rtbDescription.Location = new System.Drawing.Point(546, 246);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(528, 207);
            this.rtbDescription.TabIndex = 36;
            this.rtbDescription.Text = "";
            this.rtbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.rtbDescription_Validating);
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEventTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtEventTitle.Location = new System.Drawing.Point(546, 35);
            this.txtEventTitle.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(528, 22);
            this.txtEventTitle.TabIndex = 35;
            this.txtEventTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtEventTitle_Validating);
            // 
            // cmbEventType
            // 
            this.cmbEventType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventType.ForeColor = System.Drawing.Color.Gray;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(546, 204);
            this.cmbEventType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(528, 22);
            this.cmbEventType.TabIndex = 30;
            this.cmbEventType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbEventType_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(665, 480);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.ButtonClicked += new System.EventHandler(this.btnDelete_ButtonClicked);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(784, 480);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 32);
            this.btnBack.TabIndex = 25;
            this.btnBack.ButtonClicked += new System.EventHandler(this.btnBack_ButtonClicked);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSize = true;
            this.btnSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChanges.Location = new System.Drawing.Point(546, 480);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 32);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.ButtonClicked += new System.EventHandler(this.btnSaveChanges_ButtonClicked);
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(31, 24);
            this.picImage.Margin = new System.Windows.Forms.Padding(20, 12, 11, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(363, 213);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 20;
            this.picImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(440, 247);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 14);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblNewsType
            // 
            this.lblNewsType.AutoSize = true;
            this.lblNewsType.BackColor = System.Drawing.Color.White;
            this.lblNewsType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsType.ForeColor = System.Drawing.Color.Gray;
            this.lblNewsType.Location = new System.Drawing.Point(440, 204);
            this.lblNewsType.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblNewsType.Name = "lblNewsType";
            this.lblNewsType.Size = new System.Drawing.Size(75, 14);
            this.lblNewsType.TabIndex = 5;
            this.lblNewsType.Text = "Event type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(440, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 14);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFormCorner
            // 
            this.lblFormCorner.AutoSize = true;
            this.lblFormCorner.BackColor = System.Drawing.Color.White;
            this.lblFormCorner.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormCorner.ForeColor = System.Drawing.Color.DimGray;
            this.lblFormCorner.Location = new System.Drawing.Point(21, 5);
            this.lblFormCorner.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormCorner.Name = "lblFormCorner";
            this.lblFormCorner.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.lblFormCorner.Size = new System.Drawing.Size(96, 35);
            this.lblFormCorner.TabIndex = 0;
            this.lblFormCorner.Text = "Event info";
            this.lblFormCorner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCornerLabel
            // 
            this.pnlCornerLabel.BackColor = System.Drawing.Color.White;
            this.pnlCornerLabel.Controls.Add(this.lblFormCorner);
            this.pnlCornerLabel.Location = new System.Drawing.Point(24, 113);
            this.pnlCornerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCornerLabel.Name = "pnlCornerLabel";
            this.pnlCornerLabel.Size = new System.Drawing.Size(141, 41);
            this.pnlCornerLabel.TabIndex = 12;
            // 
            // FormEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 716);
            this.Controls.Add(this.pnlCornerLabel);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFormTitle);
            this.MaximumSize = new System.Drawing.Size(1171, 755);
            this.MinimumSize = new System.Drawing.Size(1171, 755);
            this.Name = "FormEventDetails";
            this.Text = "ecinema - Event details";
            this.Load += new System.EventHandler(this.frmEventDetails_Load);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlCornerLabel.ResumeLayout(false);
            this.pnlCornerLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNewsType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picImage;
        private UserControls.Buttons.SaveChangesButton btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private UserControls.Buttons.BackButton btnBack;
        private UserControls.Buttons.DeleteButton btnDelete;
        private System.Windows.Forms.Label lblFormCorner;
        private System.Windows.Forms.Panel pnlCornerLabel;
        private System.Windows.Forms.Label lblViewTitle;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private UserControls.Logos.LogoSmall logoSmall1;
        private System.Windows.Forms.ComboBox cmbEventType;
        private UserControls.ExtendedTextBox txtEventTitle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private UserControls.Buttons.UploadButton btnUpload;
        private UserControls.ExtendedTextBox txtPromoter;
        private System.Windows.Forms.Label lblPromoter;
        private System.Windows.Forms.DateTimePicker dtpEventTime;
        private System.Windows.Forms.Label lblScreeningTime;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblSchedule;
    }
}