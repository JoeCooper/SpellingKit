using System;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit
{
	public interface IWord
	{
		IEnumerable<ISampleSentence> SampleSentences { get; }
		IEnumerable<ISpelling> Spellings { get; }
	}
}

