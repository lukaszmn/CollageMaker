using ITLN.CollageMaker.Lib;
using ITLN.Utils.Disk;
using ITLN.Utils.Win.ListEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLN.CollageMaker {

	public partial class MainForm : Form {

		private Controller controller;

		private ListEditorHelper<Item> editor;


		public MainForm() {
			InitializeComponent();

			setup();

			// TODO: drag & drop
			// TODO: reorder items
			// TODO: delete multiple
		}


		private void setup() {
			uOpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			uOrientation.Items.AddRange(
				Enum.GetValues(typeof(CollageOrientation))
				.Cast<CollageOrientation>()
				.ToArray()
			);
			uOrientation.SelectedIndex = 0;

			uPicture.Image = new Bitmap(1, 1);

			controller = new Controller();

			editor = new ListEditorHelper<Item>(uList, null, uAdd, null, null, controller.Items);
			editor.DisplayItem += (s, item) => new[] { getName(item.Item) };
			editor.ConfirmOnDelete = DeleteConfirmation.Never;
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


		private void uCaptions_TextChanged(object sender, EventArgs e) {
			redraw();
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
			if (uOrientation.SelectedIndex < 0)
				return;

			bool hasCaptions = storeCaptions();
			var orient = (CollageOrientation) uOrientation.SelectedItem;
			uPicture.Image = controller.Redraw(orient, uPicture.Image, hasCaptions);
		}


		private void uOrientation_SelectedItemChanged(object sender, EventArgs e) {
			redraw();
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

	}
}
