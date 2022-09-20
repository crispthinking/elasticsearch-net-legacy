using System;
using System.Collections.Generic;
using System.Linq;
using SemVer;

namespace Tests.Framework
{
	public class SkipVersionAttribute : Attribute
	{
		public IList<SemVer.Range> Ranges { get; }

		public SkipVersionAttribute(string skipVersionRangesSeparatedByComma, string reason)
		{
			this.Ranges = skipVersionRangesSeparatedByComma.Split(',')
				.Select(r => new SemVer.Range(r))
				.ToList();
		}
	}
}
