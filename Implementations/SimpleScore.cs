using System;

namespace NobleMuffins.SpellingKit
{
	public class SimpleScore: IScore
	{
		private readonly bool value;

		public SimpleScore (bool value)
		{
			this.value = value;
		}

		#region IScore implementation
		public bool IsCorrect {
			get {
				return value;
			}
		}
		#endregion
	}
}

