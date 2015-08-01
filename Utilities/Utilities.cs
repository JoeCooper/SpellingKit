using System;
using System.Globalization;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit
{
	public static class Utilities
	{
		private static T GetForCulture<T>(IEnumerable<T> items, CultureInfo preferredCulture) where T: class, ILocalizedItem
		{
			T item;
			var enumerator = items.GetEnumerator ();
			if (enumerator.MoveNext ()) {
				item = enumerator.Current;
			} else {
				item = null;
			}
			if (preferredCulture != null) {
				enumerator.Reset ();
				while (enumerator.MoveNext ()) {
					var tentative = enumerator.Current;
					foreach (var itemCulture in tentative.Locales) {
						if (preferredCulture.Equals (itemCulture)) {
							item = tentative;
						}
					}
				}
			}
			return item;
		}
		
		public static ISampleSentence GetSampleSentence(IWord word, CultureInfo culture = null) {
			ISampleSentence sampleSentence = null;
			if (word.SampleSentences != null) {
				sampleSentence = GetForCulture<ISampleSentence>(word.SampleSentences, culture);
			}
			return sampleSentence;
		}

		public static ISpelling GetSpelling(IWord word, CultureInfo culture = null) {
			ISpelling spelling = null;
			if (word.Spellings != null) {
				spelling = GetForCulture(word.Spellings, culture);
			}
			return spelling;
		}
	}
}

