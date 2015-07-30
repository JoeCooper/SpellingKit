using System;
using System.Collections.Generic;

namespace SpellingKit
{
	public interface IWord
	{
		IEnumerable<ISpelling> Spellings { get; }
	}
}

