using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SwipeViewDemo
{
	public class Message
	{
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Description { get; set; }
		public string Date { get; set; }
	}

	public class SwipeViewDemoViewModel : BindableObject
	{
		private ObservableCollection<Message> _messages;
		private string _pageName;

		public SwipeViewDemoViewModel(string pagename)
		{
			_pageName = pagename;
			Messages = new ObservableCollection<Message>();
			LoadMessages();
		}

		public ObservableCollection<Message> Messages
		{
			get { return _messages; }
			set
			{
				_messages = value;
				OnPropertyChanged();
			}
		}

		public Command FavouriteCommand => new Command(OnFavourite);
		public Command DeleteCommand => new Command(OnDelete);


		private void LoadMessages()
		{
			for (int i = 0; i < 100; i++)
			{
				Messages.Add(new Message { Title = $"Lorem ipsum {i + 1}", SubTitle = "Lorem ipsum dolor sit amet", Date = "Yesterday", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
			}
		}

		private void OnFavourite()
		{
			MessagingCenter.Send(this, $"favourite_{_pageName}");
		}

		private void OnDelete()
		{
			MessagingCenter.Send(this, $"delete_{_pageName}");
		}
	}
}