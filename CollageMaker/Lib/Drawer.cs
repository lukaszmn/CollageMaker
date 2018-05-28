using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLN.CollageMaker.Lib {

	class Drawer {

		private List<Item> items;

		private Config config;

		private CollageOrientation orientation;


		public Drawer(List<Item> items, Config config, CollageOrientation orientation) {
			this.items = items;
			this.config = config;
			this.orientation = orientation;
		}


		public Size GetSize(bool hasCaptions) {
			int width, height;
			int count = items.Count;

			if (count == 0)
				return new Size(1, 1);

			int captionHeight = (hasCaptions ? config.TotalCaptionHeight : 0);

			switch (orientation) {

				case CollageOrientation.Horizontal:
					width = (count - 1) * config.TotalMargin + items.Sum(i => i.Image.Width);
					height = items.Max(i => i.Image.Height) + captionHeight;
					break;

				case CollageOrientation.Vertical:
					width = items.Max(i => i.Image.Width);
					height = (count - 1) * config.TotalMargin + count * captionHeight + items.Sum(i => i.Image.Height);
					break;

				case CollageOrientation.Square:
					// TODO
					// roundup: int columns = Math.Sqrt(count)
					width = height = 1;
					break;

				default:
					throw new ArgumentException();
			}

			return new Size(width, height);
		}


		public Locations GetLocation(int index, Size canvasSize, bool hasCaptions) {
			var item = items[index];

			int x, y, w, h;
			int width = item.Image.Width;
			int height = item.Image.Height;

			int captionHeight = (hasCaptions ? config.TotalCaptionHeight : 0);

			Locations loc = new Locations();

			switch (orientation) {

				case CollageOrientation.Horizontal:
					if (index == 0)
						x = 0;
					else
						x = index * config.TotalMargin + items.Take(index).Sum(i => i.Image.Width);

					y = 0;
					loc.Image = new Point(x, getAlignmentPosition(y + captionHeight, canvasSize.Height, height));
					loc.Caption = new Rectangle(x, y, width, captionHeight);

					if (index > 0) {
						x -= config.Margin + config.SplitterSize;
						w = config.SplitterSize;
						h = canvasSize.Height;
						loc.Separator = new Rectangle(x, y, w, h);
					}
					break;

				case CollageOrientation.Vertical:
					if (index == 0)
						y = 0;
					else
						y = index * (config.TotalMargin + captionHeight) + items.Take(index).Sum(i => i.Image.Height);

					x = 0;
					loc.Image = new Point(getAlignmentPosition(x, canvasSize.Width, width), y + captionHeight);
					loc.Caption = new Rectangle(x, y, width, captionHeight);

					if (index > 0) {
						y -= config.Margin + config.SplitterSize;
						w = canvasSize.Width;
						h = config.SplitterSize;
						loc.Separator = new Rectangle(x, y, w, h);
					}
					break;

			}

			return loc;
		}


		private int getAlignmentPosition(int start, int end, int size) {
			switch (config.Alignment) {

				case ImageAlignment.Start:
					return start;

				case ImageAlignment.Middle:
					int margin = (end - start - size) / 2;
					return start + margin;

				case ImageAlignment.End:
					return end - size;

				default:
					throw new ArgumentException();
			}
		}

	}


	class Locations {
		public Point Image;
		public Rectangle Caption;
		public Rectangle Separator;
	}

}
