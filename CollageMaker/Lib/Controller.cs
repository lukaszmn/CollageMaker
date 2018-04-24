using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLN.CollageMaker.Lib {

	class Controller {

		public List<Item> Items = new List<Item>();

		public Config Config = new Config();


		private static int counter = 1;


		public void AddImage(string path) {
			Items.Add(new Item {
				Path = path,
				Image = Image.FromFile(path)
			});
		}


		public void PasteImage() {
			Image image = Clipboard.GetImage();
			if (image == null)
				return;

			Items.Add(new Item {
				Path = $"Pasted {counter++}",
				Image = image
			});
		}


		public Image Redraw(CollageOrientation orientation, Image image, bool hasCaptions) {
			Drawer drawer = new Drawer(Items, Config, orientation);
			Size size = drawer.GetSize(hasCaptions);
			var bmp = new Bitmap(image, size);

			using (var font = new Font("Arial", Config.CaptionSize))
			using (var brush = new SolidBrush(Config.FontAndSplitterColor))
			using (var sf = new StringFormat())
			using (Graphics g = Graphics.FromImage(bmp)) {

				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Center;

				g.Clear(Color.White);

				for (int i = 0; i < Items.Count; ++i) {
					var item = Items[i];

					var loc = drawer.GetLocation(i, size, hasCaptions);

					g.DrawString(item.Caption, font, brush, loc.Caption, sf);
					g.DrawImageUnscaled(item.Image, loc.Image);

					g.FillRectangle(brush, loc.Separator);
				}

			}

			return bmp;
		}

		public void SaveResult() {
			// TODO

		}


		public void CopyResult(Image image) {
			Clipboard.SetImage(image);
		}

	}


	class Item {
		public string Path;
		public string Caption;
		public Image Image;
	}
}
