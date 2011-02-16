using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JpegBookMaker
{
    public class PageInfo
    {
        public string Path { get; private set; }
        public Rectangle Bounds;
        public int Level, Contrast;
        public bool IsGrayScale;

        public PageInfo()
        {
        }

        public PageInfo(string path)
        {
            Path = path;
        }

        public Bitmap GetBitmap()
        {
            if (Path != null)
                return new Bitmap(Path);
            else
                return null;
        }
    }
}
