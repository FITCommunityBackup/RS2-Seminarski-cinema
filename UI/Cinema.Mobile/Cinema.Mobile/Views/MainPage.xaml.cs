﻿using Cinema.Mobile.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cinema.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.NowShowing, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.NowShowing:
                        MenuPages.Add(id, new NavigationPage(new NowShowingMoviesPage()));
                        break;

                    case (int)MenuItemType.MyReservations:
                        MenuPages.Add(id, new NavigationPage(new MyReservationsPage()));
                        break;
                    case (int)MenuItemType.News:
                        MenuPages.Add(id, new NavigationPage(new NewsPage()));
                        break;
                    case (int)MenuItemType.Events:
                        MenuPages.Add(id, new NavigationPage(new EventsPage()));
                        break;

                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }

    }
}