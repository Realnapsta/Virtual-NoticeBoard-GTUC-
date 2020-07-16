using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Virtual_NoticeBoard_GTUC_.Services;
using Virtual_NoticeBoard_GTUC_.Views;
using VirtualNoticeBoardGTUC.Views.Startup;
using VirtualNoticeBoardGTUC.Models;

namespace Virtual_NoticeBoard_GTUC_
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public static string DatabaseLocation = string.Empty;

        public static Students currentstudent = new Students();

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            MainPage = new StartUpShell();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new StartUpShell();
            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
