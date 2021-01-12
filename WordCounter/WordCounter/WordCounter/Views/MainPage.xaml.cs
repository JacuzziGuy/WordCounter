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
			ResetInput();
		}
		private void ResetInput()
		{
			//Po prostu ustawiam tekst na pusty string, bo inaczej przy uruchomieniu wykrywa jako null.
			input.Text = "";
		}
		private void SubmitClicked(object sender, EventArgs e)
		{
			//Łapanie błędu
			if (input.Text == "")
			{
				output.Text = "Nie ma żadnej wypowiedzi.";
				return;
			}
			//zmienne
			string sentenceText = "", wordText = "";
			int sentencesAmount;
			int wordsAmount;
			int count = 0;
			List<string> words = input.Text.Trim().Split(' ').ToList();
			//Ustalanie ilości słów
			foreach (string word in words)
			{
				if (word.Trim() == "" || word.Trim() == ".")
					count++;
			}
			wordsAmount = words.Count() - count;
			//Ustalanie ilości zdań
			count = 0;
			foreach (string word in words)
			{
				if (word.Contains(".") || word.Contains("!") || word.Contains("?"))
					count++;
			}
			string lastWord = words[words.Count()-1];
			sentencesAmount = lastWord.Contains(".") || lastWord.Contains("!") || lastWord.Contains("?") ? count : count + 1;
			//Odpowiednia odmiana słowa "zdanie"
			if (sentencesAmount == 1)
				sentenceText = "zdanie";
			else if (sentencesAmount % 10 >= 2 && sentencesAmount % 10 <= 4)
				sentenceText = "zdania";
			else if (sentencesAmount % 10 >= 5 || sentencesAmount % 10 <= 1 || (sentencesAmount >=11 && sentencesAmount <= 19))
				sentenceText = "zdań";
			//Odpowiednia odmiana słowa "słowo"
			if (wordsAmount == 1)
				wordText = "słowo";
			else if (wordsAmount % 10 >= 2 && wordsAmount % 10 <= 4)
				wordText = "słowa";
			else if (wordsAmount % 10 >= 5 || wordsAmount % 10 <= 1 || (wordsAmount >= 11 && wordsAmount <= 19))
				wordText = "słów";
			//wyświetlenie informacji
			output.Text = $"Podana wypowiedź ma {sentencesAmount} {sentenceText}, oraz {wordsAmount} {wordText}.";
		}
	}
}
