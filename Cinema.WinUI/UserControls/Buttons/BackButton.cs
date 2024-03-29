﻿using System;
using System.Windows.Forms;

namespace Cinema.WinUI.UserControls.Buttons
{
    public partial class BackButton : UserControl
    {
        public event EventHandler ButtonClicked;

        public BackButton()
        {
            InitializeComponent();
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }
    }
}
