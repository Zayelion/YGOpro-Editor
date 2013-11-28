using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CCImage
{
	public class PIC
	{
		public static Bitmap GetBitmap(string file)
		{
			if (File.Exists(file))
			{
				return new Bitmap(file,true);
			}
			else
				return null;
		}
        public static Bitmap zoom(Bitmap img, int newW, int newH)
		{
			if(img!=null)
			{
				Bitmap b = new Bitmap(newW, newH);
				Graphics g = Graphics.FromImage(b);
				g.CompositingQuality = CompositingQuality.HighQuality;
				g.SmoothingMode = SmoothingMode.HighQuality;
				g.InterpolationMode = InterpolationMode.HighQualityBicubic;
				g.DrawImage(img, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
				g.Dispose();
				return b;
			}
			return img;
		}
        public static Bitmap cut(Bitmap img, int StartX, int StartY, int iWidth, int iHeight)
		{
            if (img != null)
            {
                int w = img.Width;
                int h = img.Height;
                int cha = w - h;
                if (w - h < 0)
                    cha = -cha;
                if (StartX < w && StartY < h && cha > 4)
                {
                    if (StartX + iWidth > w)
                    {
                        iWidth = w - StartX;
                    }
                    if (StartY + iHeight > h)
                    {
                        iHeight = h - StartY;
                    }
                    Bitmap b = new Bitmap(iWidth, iHeight);
                    Graphics g = Graphics.FromImage(b);
                    g.DrawImage(img, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
                    g.Dispose();
                    return b;
                }
            }
			return img;
		}
        public static bool savejpg(Bitmap bmp, string filename, int quality)
        {
            if (bmp != null)
            {
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo ici = null;
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType.IndexOf("jpeg") > -1)
                    {
                        ici = codec;
                    }
                    if (quality < 0 || quality > 100)
                        quality = 60;
                    EncoderParameters encoderParams = new EncoderParameters();
                    encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)quality);
                    if (ici != null)
                        bmp.Save(filename, ici, encoderParams);
                    else
                        bmp.Save(filename);
                }
                return true;
            }
            return false;
        }
        public static void CutJPG(string gpath, int id, int type, string cpath,int W,int H)
        {
            int x = 25; int y = 54; int y2 = 51;
            int w = 126; int h = 126;
            int zl = 96;
            if (type > 0x800000)
            {
                y = y2;
            }
            PIC.savejpg(PIC.zoom(PIC.cut(PIC.GetBitmap(gpath + "pics\\" + id.ToString() + ".jpg"), x, y, w, h), W, H), cpath + id.ToString() + ".jpg", zl);
        }
        public static Bitmap CutJPG(string gpath, int id, int type,int W,int H)
        {
            //MessageBox.Show(SET.Length.ToString());
            int x = 25; int y = 54; int y2 = 51;
            int w = 126; int h = 126;
            if (type > 0x800000)
            {
                y = y2;
            }
            return PIC.zoom(PIC.cut(PIC.GetBitmap(gpath + "pics\\" + id.ToString() + ".jpg"), x, y, w, h), W, H);
        }
	}
}
