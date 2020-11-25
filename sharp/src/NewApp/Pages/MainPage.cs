using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewApp.PageModels;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.CommunityToolkit.Markup.LeftToRight;
using static Xamarin.CommunityToolkit.Markup.GridRowsColumns;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace NewApp.Pages
{
    public partial class MainPage : ContentPage
    {
        void Build() => Content =
                new Grid
                {
                    RowDefinitions = GridRowsColumns.Rows.Define(
                        (GridRows.Title, Auto),
                    (GridRows.Body, Star)
                    ),
                    Children =
                    {
                        new Frame
                            {
                                BackgroundColor = (Color)App.Current.Resources["ThemePrimary"],
                                Padding = 24,
                                CornerRadius = 0,
                                Content =
                                    new Label
                                    {
                                        Text = "Welcome to Xamarin.Forms",
                                        TextColor = Color.White,
                                        FontSize = 36
                                    }.CenterHorizontal()
                            },
                        new StackLayout
                        {
                            Margin = 15,
                            Children =
                            {
                                new Label
                                {
                                    Text = "Start developing now",
                                    FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label))
                                },
                                new Label
                                {
                                    Text = "Make changes to your XAML and save it to see your UI update in your running app. Give it a try!",
                                    FontSize = 16
                                }.Paddings(left:10,right:10),
                                new Label
                                {
                                    FontSize = 16
                                }.Paddings(left:10,top:24,right:10)
                                .FormattedText(
                                    new Span{ Text = "Learn more at " },
                                    new Span{ Text = "https://aka.ms/xamarin-quickstart"}.Bold()
                                )
                            }

                        }.Row(GridRows.Body)

                    }
                };
        


        public MainPage()
        {            
            //(App.Current.MainPage as Xamarin.Forms.NavigationPage).BackgroundColor = Color.Blue;
            //(App.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().EnableTranslucentNavigationBar();
            BindingContext = new MainPageModel();
            Build();
        }

    }

    internal enum GridRows
    {
        Title,
        Body
    }
}
