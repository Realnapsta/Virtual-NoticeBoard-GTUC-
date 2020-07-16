using System;
using System.Collections.Generic;
using VirtualNoticeBoardGTUC.Views.Startup;
using Xamarin.Forms;

namespace VirtualNoticeBoardGTUC.Views.Main
{
    public partial class AccountPage : ContentPage
    {

        public AccountPage()
        {
            InitializeComponent();
        }

        public void View_info_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync( new DisplayInfoPage());
        }

        public void LogoutButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new StartUpShell();
        }
    }
}
