using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InteractivitySample
{
	public class Algorithm
	{
		IInteractiveChooser theChooser;
		bool askToUser = false;

		public Algorithm(IInteractiveChooser aChooser, bool askToUser = false)
		{
			this.theChooser = aChooser;
			this.askToUser = askToUser;
		}

		public void Run()
		{
			for(;; )
			{
				var options = CreateRandomOptions();

				IOption selected = null;

				if (askToUser)
				{
					selected = theChooser.ChooseOne(CreateRandomOptions());
				}
				else
				{
					Console.WriteLine("Available options: [" + string.Join(",", options.Select(o => o.ID).ToList()) + "]");
					selected = options[new Random(DateTime.Now.Millisecond).Next(options.Count)];
					Thread.Sleep(1000 + new Random(DateTime.Now.Millisecond).Next(options.Count));
				}

				if (selected == null)
				{
					Console.WriteLine("Algorithm finished!");
					break;
				}
				Console.WriteLine("Selected: " + selected.ID);
			}
		}

		private List<IOption> CreateRandomOptions()
		{
			var random = new Random(DateTime.Now.Millisecond);

			var size = random.Next(2, 5);

			var result = new List<IOption>();

			for (int i = 0; i < size; i++)
			{
				result.Add(new SomeOption(random.Next(1000).ToString()));
			}

			return result;
		}
	}
}
