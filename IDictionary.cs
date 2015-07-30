using System;
using System.Collections.Generic;

namespace SpellingKit
{
	public interface IDictionary
	{
		IEnumerable<IWord> Words { get; }
	}
}

