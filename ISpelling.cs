using System;
using System.Collections.Generic;
using System.Globalization;

namespace SpellingKit
{
	public interface ISpelling
	{
		string Text { get; }
		IEnumerable<CultureInfo> Locales { get; }
	}
}

