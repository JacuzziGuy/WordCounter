using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace WordCounter.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void SubmitClicked(object sender, EventArgs e)
		{
			int sentencesAmount = 0;
			int wordsAmount;
			List<string> words = input.Text.Split(' ').ToList();
			List<string> temp = new List<string>();
			foreach(string word in words)
			{
				if(word.Trim() == "")
				{
					temp.Add(word);
				}
			}
			wordsAmount = words.Count() - temp.Count();
			output.Text = $"W Twojej wypowiedzi jest {sentencesAmount} zdań, oraz {wordsAmount} słów.";
		}
	}
}
