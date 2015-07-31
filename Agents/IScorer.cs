using System;

namespace NobleMuffins.SpellingKit
{
	public interface IScorer<T> where T: IScore
	{
		T GetScore(IWord challenge, string answer);
	}
}

