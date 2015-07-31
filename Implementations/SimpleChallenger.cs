using System;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit
{
	public class SimpleChallenger: IChallenger
	{
		private readonly IList<IWord> words;
		private readonly Random random;

		private IWord previousWord;
		
		public SimpleChallenger (IDictionary dictionary)
		{
			this.words = new List<IWord> (dictionary.Words);
			this.random = new Random ();
		}

		#region IChallenger implementation
		public IWord GetChallenge ()
		{
			IWord word;
			do {
				var wordIndex = random.Next () % words.Count;
				word = words [wordIndex];
			} while(words.Count > 1 && word == previousWord);
			previousWord = word;
			return word;
		}
		#endregion
	}
}

