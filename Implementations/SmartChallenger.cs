using System;
using NobleMuffins.SpellingKit;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit
{
	public class SmartChallenger: IChallenger
	{
		private readonly List<IWord> words;
		private readonly IDictionary<IWord,int> record;
		private readonly Random random;

		private IWord previousWord;

		public SmartChallenger (IDictionary dictionary)
		{
			this.words = new List<IWord> (dictionary.Words);
			this.record = new Dictionary<IWord, int>();
			this.random = new Random ();
		}

		private int CompareWords (IWord alfa, IWord bravo) {
			int scoreAlfa, scoreBravo;
			if (record.TryGetValue (alfa, out scoreAlfa) == false) {
				scoreAlfa = 0;
			}
			if (record.TryGetValue (bravo, out scoreBravo) == false) {
				scoreBravo = 0;
			}
			//This is inverted so that the list will sort in descending order
			return scoreBravo - scoreAlfa;
		}

		public void LogOutcome(IWord word, IScore score)
		{
			int rank;
			if (record.TryGetValue (word, out rank) == false) {
				rank = 0;
			}
			if (score.IsCorrect) {
				rank /= 2;
			} else {
				rank++;
			}
			record [word] = rank;
		}

		#region IChallenger implementation
		public IWord GetChallenge ()
		{
			words.Sort (CompareWords);
			IWord word;
			do {
				var wordIndex = random.Next () % words.Count;
				wordIndex *= wordIndex;
				wordIndex /= words.Count;
				word = words [wordIndex];
			} while(words.Count > 1 && word == previousWord);
			previousWord = word;
			return word;
		}
		#endregion
	}
}

