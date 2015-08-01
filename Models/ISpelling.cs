using System;
using System.Collections.Generic;
using System.Globalization;

namespace NobleMuffins.SpellingKit
{
	public interface ISpelling: ILocalizedItem
	{
		string Text { get; }
	}
}

