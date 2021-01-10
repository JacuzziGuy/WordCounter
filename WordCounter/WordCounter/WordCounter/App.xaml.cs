﻿using Xamarin.Forms;
using WordCounter.Views;

namespace WordCounter
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage());
		}
	}
}
