using System;
#if (CreateBackendProject)
using Xamarin.Essentials;
#endif
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewApp
{
    public partial class App : Application
    {
        #if (CreateBackendProject)
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl = 
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;
        #endif

        public App ()
        {
            Device.SetFlags(new string[] { "AppTheme_Experimental" });
            
            InitializeComponent();

            #if (CreateBackendProject)
            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();
            #endif
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
