using System;
using System.Collections.Generic;
using VirtualNoticeBoardGTUC.Views.Main;
using Xamarin.Forms;

namespace VirtualNoticeBoardGTUC.Views.Startup
{
    public partial class LoginPage : ContentPage
    {
        public void StudentMainPage_Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainShell();
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
