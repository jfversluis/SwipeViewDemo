using Xamarin.Forms;

namespace SwipeViewDemo
{
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            InitializeComponent();

            BindingContext = new SwipeViewDemoViewModel("collectionview");

            MessagingCenter.Subscribe<SwipeViewDemoViewModel>(this, "favourite_collectionview", sender => { DisplayAlert("SwipeView", "Favourite", "Ok"); });
            MessagingCenter.Subscribe<SwipeViewDemoViewModel>(this, "delete_collectionview", sender => { DisplayAlert("SwipeView", "Delete", "Ok"); });
        }
    }
}