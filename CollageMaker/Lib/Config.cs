using System.Drawing;

namespace ITLN.CollageMaker.Lib {

	class Config {

		public int CaptionSize = 20;

		public int CaptionMargin = 10;

		public int Margin = 20;


		public int SplitterSize = 5;

		public Color FontAndSplitterColor = Color.Red;


		public CollageOrientation Orientation;

		public ImageAlignment Alignment;


		public int TotalMargin {
			get { return Margin + SplitterSize + Margin; }
		}


		public int TotalCaptionHeight {
			get { return CaptionMargin + CaptionSize + CaptionMargin; }
		}

	}
}
