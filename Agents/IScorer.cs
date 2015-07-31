using System;

namespace NobleMuffins.SpellingKit
{
	public interface IScorer
	{
		IScore GetScore(IWord challenge, string answer);
	}
}

