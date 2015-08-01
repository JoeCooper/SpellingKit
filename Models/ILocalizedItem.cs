using System;
using System.Collections.Generic;
using System.Globalization;

namespace NobleMuffins.SpellingKit
{
	public interface ILocalizedItem
	{
		IEnumerable<CultureInfo> Locales { get; }
	}
}

