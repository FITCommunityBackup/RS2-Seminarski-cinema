﻿using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyReservationsDetailsPage : ContentPage
    {
        public MyReservationsDetailsViewModel model = null;

        public MyReservationsDetailsPage(ReservationDto reservation)
        {
            InitializeComponent();
            BindingContext = model = new MyReservationsDetailsViewModel { Reservation = reservation };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        //protected async override void OnDisappearing()
        //{
        //    MessagingCenter.Send(this, "refresh");
        //}
    }
}