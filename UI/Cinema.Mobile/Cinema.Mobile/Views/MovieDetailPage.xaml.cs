﻿using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailPage : ContentPage
    {
        MovieDetailsViewModel model = null;

        public MovieDetailPage(MovieDto movie)
        {
            InitializeComponent();
            BindingContext = model = new MovieDetailsViewModel { Movie = movie };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

            if (model.Movie.Poster.Length == 0)
            {
                this.MovieDetailPoster.Source = ImageSource.FromFile("movieposterplaceholder.png");
            }

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ScreeningDto;

            await Navigation.PushAsync(new NewReservationPage(item));
        }
    }
}