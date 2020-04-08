using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwipeViewDemo
{
    public partial class PageSwipe : ContentPage
    {
        public PageSwipe()
        {
            InitializeComponent();
        }

		void OnContentClicked(object sender, EventArgs args)
		{
			DisplayAlert("OnClicked", "The Content Button has been clicked.", "Ok");
		}

		void OnRightItemsClicked(object sender, EventArgs args)
		{
			DisplayAlert("OnClicked", "The RightItems Button has been clicked.", "Ok");
		}

		void OnButtonClicked(object sender, EventArgs e)
		{
			DisplayAlert("Custom SwipeItem", "Button Clicked!", "Ok");
		}
	}
}
