using System;
using NewApp.Pages;
using ThemeGallery.Styles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewApp
{
    public partial class App : Application
    {

        public App()
        {
            this.Resources = new DefaultTheme();
//-:cnd:noEmit
#if __MACOS__
            MainPage = new NavigationPage(new MainPage());
#else
            MainPage = CreateShell();
#endif
//+:cnd:noEmit            
        }

        private Page CreateShell()
        {
            return new Shell()
            {
                Items =
                {
                    new FlyoutItem()
                    {
                        Title = "Home",
                        Items =
                        {
                            new ShellSection()
                            {
                                Items =
                                {
                                    new ShellContent()
                                    {
                                        Route = "home",
                                        ContentTemplate = new DataTemplate(typeof(MainPage))
                                    }
                                }
                            }
                        }
                    }
                }
            };
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
