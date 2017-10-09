using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CreateMltVolumeFiles
{
	public partial class CreateMltVolumeFilesForm : Form
	{
		public CreateMltVolumeFilesForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void btnCreateMltVolumeFiles_Click(object sender, EventArgs e)
		{
			try
			{
				lstResult.Items.Clear();
				List<string> createdFilesPaths = new List<string>();
				var folderPath = txtFolderPath.Text;

				if (!Directory.Exists(folderPath))
					throw new DirectoryNotFoundException();

				var directory = new DirectoryInfo(folderPath);

				if (radioFirstLevel.Checked)
				{
					var createdFilePath = Library.CreateVolumeFiles(directory);
					createdFilesPaths.Add(createdFilePath);
				}

				if (radioSecondLevel.Checked)
				{
					createdFilesPaths = Library.CreateVolumesSecondLevel(directory).ToList();
				}

				FillListbox(ref lstResult, createdFilesPaths);
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("Specified folder does not exist!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void FillListbox(ref ListBox lstbox, IEnumerable<string> source)
		{
			foreach (var item in source)
			{
				lstbox.Items.Add(item);
			}
		}
	}
}
