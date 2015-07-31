using System;

namespace NobleMuffins.SpellingKit
{
	public class SimpleScorer: IScorer
	{
		#region IScorer implementation
		public IScore GetScore (IWord challenge, string answer)
		{
			var result = false;
			var trimmedAnswer = answer.Trim ();
			foreach (var spelling in challenge.Spellings) {
				var trimmedSpelling = spelling.Text;
				var pass = string.Equals (trimmedAnswer, trimmedSpelling, StringComparison.InvariantCultureIgnoreCase);
				if (pass) {
					result = true;
					break;
				}
			}
			return new SimpleScore (result);
		}
		#endregion
	}
}

