using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace NewApp.WPF
{
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new NewApp.App());
        }
    }
}