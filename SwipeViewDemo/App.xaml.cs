using Xamarin.Forms;

namespace SwipeViewDemo
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "SwipeView_Experimental" });

            InitializeComponent();

            MainPage = new TabbedPage()
            {
                Children =
                {
                    new NavigationPage(new ListViewPage()) { Title = "ListView" },
                    new NavigationPage(new CollectionViewPage()) { Title = "CollectionView" },
                    new NavigationPage(new ProgrammaticalSwipeView()) { Title = "Programmatically" },
                    new NavigationPage(new PageSwipe()) { Title = "Page swipe" }
                }
            };
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