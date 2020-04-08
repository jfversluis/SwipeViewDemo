using System;
using Xamarin.Forms;

namespace SwipeViewDemo
{
    public class ProgrammaticalSwipeView : ContentPage
    {
        public ProgrammaticalSwipeView()
        {
			Title = "Programmatically";

			var swipeLayout = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Star }
				},
				Margin = new Thickness(12)
			};

			var openButton = new Button
			{
				Text = "Open SwipeView"
			};

			var closeButton = new Button
			{
				Text = "Close SwipeView"
			};

			swipeLayout.Children.Add(openButton, 0, 0);
			swipeLayout.Children.Add(closeButton, 0, 1);

			var swipeItem = new SwipeItem
			{
				BackgroundColor = Color.Red,
				IconImageSource = "calculator.png",
				Text = "File"
			};

			swipeItem.Invoked += (sender, e) => { DisplayAlert("SwipeView", "File Invoked", "Ok"); };

			var swipeItems = new SwipeItems { swipeItem };

			swipeItems.Mode = SwipeMode.Reveal;

			var swipeContent = new Grid
			{
				BackgroundColor = Color.Gray
			};

			var fileSwipeLabel = new Label
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Text = "Swipe to Right (File)"
			};

			swipeContent.Children.Add(fileSwipeLabel);

			var swipeView = new SwipeView
			{
				HeightRequest = 60,
				WidthRequest = 300,
				LeftItems = swipeItems,
				Content = swipeContent
			};

			swipeLayout.Children.Add(swipeView, 0, 2);

			var scroll = new ScrollView();
			var eventsInfo = new Label();
			scroll.Content = eventsInfo;

			swipeLayout.Children.Add(scroll, 0, 3);

			Content = swipeLayout;

			openButton.Clicked += (sender, e) =>
			{
				swipeView.Open(OpenSwipeItem.LeftItems);
			};

			closeButton.Clicked += (sender, e) =>
			{
				swipeView.Close();
			};

			swipeView.SwipeStarted += (sender, e) =>
			{
				eventsInfo.Text += $"SwipeStarted - Direction:{e.SwipeDirection}" + Environment.NewLine;
			};

			swipeView.SwipeChanging += (sender, e) =>
			{
				eventsInfo.Text += $"SwipeChanging - Direction:{e.SwipeDirection}, Offset:{e.Offset}" + Environment.NewLine;
			};

			swipeView.SwipeEnded += (sender, e) =>
			{
				eventsInfo.Text += $"SwipeEnded - Direction:{e.SwipeDirection}" + Environment.NewLine;
			};
		}
    }
}