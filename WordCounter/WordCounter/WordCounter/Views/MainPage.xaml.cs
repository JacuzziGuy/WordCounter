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
			int sentencesAmount;
			int wordsAmount;
			int count = 0;
			List<string> words = input.Text.Split(' ').ToList();
			foreach(string word in words)
			{
				if(word.Trim() == "" || word.Trim() == ".")
					count++;
			}
			wordsAmount = words.Count() - count;
			count = 0;
			foreach (string word in words)
			{
				if (word.Contains("."))
					count++;
			}
			sentencesAmount = words[words.Count()-1].Contains(".")?count:count+1;
			output.Text = $"W Twojej wypowiedzi jest {sentencesAmount} zdań, oraz {wordsAmount} słów.";
		}
	}
}
