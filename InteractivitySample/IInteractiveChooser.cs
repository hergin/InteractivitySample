using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractivitySample
{
	public interface IInteractiveChooser
	{
		IOption ChooseOne(List<IOption> options);
	}
}
