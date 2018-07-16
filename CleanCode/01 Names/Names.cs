using System.Drawing;

namespace CleanCode.Names
{
    public class BitmapDrawer 
    {
        public Bitmap DrawBitmap (string fileName)
        {
            var bitmapImage = new Bitmap(fileName);
            var bitmapGraphic = Graphics.FromImage(bitmapImage);
            bitmapGraphic.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            bitmapGraphic.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            bitmapGraphic.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmapImage;
        }
    }
}
