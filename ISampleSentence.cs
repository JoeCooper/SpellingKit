using System;

namespace NobleMuffins.SpellingKit
{
	public interface ISampleSentence
	{
		string BeforeTheWord { get; }
		string AfterTheWord { get; }
	}
}

