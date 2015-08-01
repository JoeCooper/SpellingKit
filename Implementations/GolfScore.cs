using System;

namespace NobleMuffins.SpellingKit
{
	public class GolfScore: IScore
	{
		private readonly int score;
		
		public GolfScore (int score)
		{
			this.score = score;
		}

		public int Score {
			get {
				return score;
			}
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

