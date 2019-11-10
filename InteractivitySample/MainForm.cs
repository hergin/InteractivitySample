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
	public partial class MainForm : Form, IInteractiveChooser
	{
		Algorithm theAlgorithm;

		public MainForm()
		{
			InitializeComponent();

			backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
			backgroundWorker1.WorkerSupportsCancellation = true;
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			theAlgorithm.Run();
		}

		public IOption ChooseOne(List<IOption> options)
		{
			var optionSelector = new OptionSelector(options);
			optionSelector.ShowDialog();
			return optionSelector.Selected;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			theAlgorithm = new Algorithm(this,checkBox_askToUser.Checked);

			backgroundWorker1.RunWorkerAsync();
		}
	}
}
