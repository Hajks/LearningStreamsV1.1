using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LearningStreamsV1._1
{
	public partial class Form1 : Form
	{
		string name;
		public Form1()
		{
			InitializeComponent();

		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void saveButton_Click(object sender, EventArgs e)//otwórz
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				name = openFileDialog1.FileName;
				textBox1.Clear();
				textBox1.Text = File.ReadAllText(name);
			}
		}

		private void button2_Click(object sender, EventArgs e)//zapisz
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				name = saveFileDialog1.FileName;
				File.WriteAllText(name, textBox1.Text);
			}
		}
	}
}
