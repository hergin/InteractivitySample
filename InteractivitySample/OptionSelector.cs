using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractivitySample
{
	public partial class OptionSelector : Form
	{
		IOption selected;
		public IOption Selected { get => selected; }

		public OptionSelector(List<IOption> options)
		{
			InitializeComponent();

			var currentY = 80;

			foreach (var option in options)
			{
				Button optionButton = new Button();
				optionButton.Location = new System.Drawing.Point(30, currentY);
				optionButton.Name = "optionButton" + option.ID;
				optionButton.Size = new System.Drawing.Size(246, 23);
				optionButton.Text = option.ID;

				optionButton.Click += (s, e) =>
				{
					selected = option;
					this.Close();
				};

				Controls.Add(optionButton);

				currentY += 30;
			}
		}
	}
}
