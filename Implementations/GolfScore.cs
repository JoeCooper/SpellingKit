using System;

namespace NobleMuffins.SpellingKit
{
	public class GolfScore: IScore
	{
		public readonly int score;
		
		public GolfScore (int score)
		{
			this.score = score;
		}

		#region IScore implementation
		public bool IsCorrect {
			get {
				return score == 0;
			}
		}
		#endregion
	}
}

