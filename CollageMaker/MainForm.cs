using ITLN.CollageMaker.Lib;
using ITLN.Utils.Disk;
using ITLN.Utils.Win.ListEditor;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ITLN.CollageMaker {

	public partial class MainForm : Form {

		private Controller controller;

		private ListEditorHelper<Item> editor;

		private Config config;


		public MainForm() {
			InitializeComponent();

			config = new Config();
			controller = new Controller();

			setupUI();
			showConfigInUI();

			// TODO: drag & drop
			// TODO: reorder items
			// TODO: delete multiple
		}


		private void setupUI() {
			uOpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			uPicture.Image = new Bitmap(1, 1);

			editor = new ListEditorHelper<Item>(uList, null, uAdd, null, null, controller.Items);
			editor.DisplayItem += (s, item) => new[] { getName(item.Item) };
			editor.ConfirmOnDelete = DeleteConfirmation.Never;

			uOrientation.Items.AddRange(
				Enum.GetValues(typeof(CollageOrientation))
				.Cast<CollageOrientation>()
				.ToArray()
			);

			uAlignment.Items.AddRange(
				Enum.GetValues(typeof(ImageAlignment))
				.Cast<ImageAlignment>()
				.ToArray()
			);
		}


		private bool ignoreEvents;

		private void showConfigInUI() {
			ignoreEvents = true;

			uOrientation.SelectedItem = config.Orientation;
			uAlignment.SelectedItem = config.Alignment;
			uColorPanel.BackColor = config.FontAndSplitterColor;

			if (config.SplitterSize == 0)
				uSeparatorEnabled.Checked = false;
			else {
				uSeparatorEnabled.Checked = true;
				uSeparatorSize.Value = config.SplitterSize;
			}

			ignoreEvents = false;
		}


		private string getName(Item item) {
			return new FileItem(item.Path).FileNameWithoutExtension;
		}


		private void uAdd_Click(object sender, EventArgs e) {
			if (uOpenDialog.ShowDialog() == DialogResult.OK) {

				try {
					foreach (string file in uOpenDialog.FileNames)
						controller.AddImage(file);

					//updateList();
					editor.Refresh();

				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
				
				redraw();
			}
		}


		private void updateList() {
			uList.Items.Clear();

			foreach (var item in controller.Items) {
				var name = getName(item);
				var lvi = uList.Items.Add(name);
				lvi.Tag = item;
				//lvi.SubItems.Add(item.Header);
			}
		}


		private bool storeCaptions() {
			int linesCount = uCaptions.Lines.Length;

			for (int i = 0; i < controller.Items.Count; ++i) {
				string line = "";

				if (linesCount > 0) {
					int lineIndex = i % linesCount;
					line = uCaptions.Lines[lineIndex];
				}

				controller.Items[i].Caption = line;
			}

			return linesCount > 0;
		}


		private void redraw() {
			if (ignoreEvents || uOrientation.SelectedIndex < 0)
				return;

			setOptions();
			bool hasCaptions = storeCaptions();
			uPicture.Image = controller.Redraw(config, uPicture.Image, hasCaptions);
		}


		private void setOptions() {
			var orient = (CollageOrientation)uOrientation.SelectedItem;
			config.Orientation = orient;

			var alignment = (ImageAlignment)uAlignment.SelectedItem;
			config.Alignment = alignment;

			if (!uSeparatorEnabled.Checked)
				config.SplitterSize = 0;
			else
				config.SplitterSize = (int) uSeparatorSize.Value;
		}


		private void uSave_Click(object sender, EventArgs e) {
			controller.SaveResult();
		}

		private void uCopy_Click(object sender, EventArgs e) {
			controller.CopyResult(uPicture.Image);
		}


		private void MainForm_KeyUp(object sender, KeyEventArgs e) {
			if (e.Control && e.KeyCode == Keys.V) {
				controller.PasteImage();
				editor.Refresh();
				redraw();
			}
		}


		private void uiForConfigChanged(object sender, EventArgs e) {
			redraw();
		}


		private void uColorPanel_Click(object sender, EventArgs e) {
			uColorDialog.Color = config.FontAndSplitterColor;
			if (uColorDialog.ShowDialog() == DialogResult.OK) {
				config.FontAndSplitterColor = uColorDialog.Color;
				uColorPanel.BackColor = uColorDialog.Color;
				redraw();
			}
		}


		private void uSeparatorEnabled_CheckedChanged(object sender, EventArgs e) {
			uSeparatorSize.Enabled = uSeparatorEnabled.Checked;
			uSeparatorLabel.Enabled = uSeparatorEnabled.Checked;
			redraw();
		}

	}
}
