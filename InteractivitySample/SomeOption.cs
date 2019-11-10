using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractivitySample
{
	public class SomeOption : IOption
	{
		public String Value { get; }

		public string ID => Value;

		public SomeOption(String value)
		{
			this.Value = value;
		}
	}
}
