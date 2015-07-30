using System;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit
{
	public interface IDictionary
	{
		IEnumerable<IWord> Words { get; }
	}
}

