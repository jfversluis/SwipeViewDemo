using System.ComponentModel;
using Xamarin.Forms;

namespace SwipeViewDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            BindingContext = new SwipeViewDemoViewModel("listview");

            MessagingCenter.Subscribe<SwipeViewDemoViewModel>(this, "favourite_listview", sender => { DisplayAlert("SwipeView", "Favourite", "Ok"); });
            MessagingCenter.Subscribe<SwipeViewDemoViewModel>(this, "delete_listview", sender => { DisplayAlert("SwipeView", "Delete", "Ok"); });
        }
    }
}