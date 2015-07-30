using System;
using System.Collections.Generic;

namespace NobleMuffins.SpellingKit
{
	public interface IWord
	{
		IEnumerable<ISpelling> Spellings { get; }
	}
}

