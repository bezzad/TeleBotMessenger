using System.Drawing;
using System.Drawing.Imaging;

namespace TeleBotMessenger.Helper
{
    public static class BitmapFilter
    {
        private static bool Conv3X3(this Bitmap b, ConvMatrix m)
        {
            // Avoid divide by zero errors
            if (0 == m.Factor) return false;

            var bSrc = (Bitmap)b.Clone();

            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            var bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            var bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            var stride = bmData.Stride;
            var stride2 = stride * 2;
            var scan0 = bmData.Scan0;
            var srcScan0 = bmSrc.Scan0;

            unsafe
            {
                var p = (byte*)(void*)scan0;
                var pSrc = (byte*)(void*)srcScan0;

                var nOffset = stride + 6 - b.Width * 3;
                var nWidth = b.Width - 2;
                var nHeight = b.Height - 2;

                for (var y = 0; y < nHeight; ++y)
                {
                    for (var x = 0; x < nWidth; ++x)
                    {
                        if (pSrc != null)
                        {
                            var nPixel = ((((pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) + (pSrc[8] * m.TopRight) +
                                            (pSrc[2 + stride] * m.MidLeft) + (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) +
                                            (pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) + (pSrc[8 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                            if (nPixel < 0) nPixel = 0;
                            if (nPixel > 255) nPixel = 255;

                            if (p != null)
                            {
                                p[5 + stride] = (byte)nPixel;

                                nPixel = ((((pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) + (pSrc[7] * m.TopRight) +
                                            (pSrc[1 + stride] * m.MidLeft) + (pSrc[4 + stride] * m.Pixel) +
                                            (pSrc[7 + stride] * m.MidRight) +
                                            (pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) +
                                            (pSrc[7 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                                if (nPixel < 0) nPixel = 0;
                                if (nPixel > 255) nPixel = 255;

                                p[4 + stride] = (byte)nPixel;

                                nPixel = ((((pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) + (pSrc[6] * m.TopRight) +
                                            (pSrc[0 + stride] * m.MidLeft) + (pSrc[3 + stride] * m.Pixel) +
                                            (pSrc[6 + stride] * m.MidRight) +
                                            (pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) +
                                            (pSrc[6 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                                if (nPixel < 0) nPixel = 0;
                                if (nPixel > 255) nPixel = 255;

                                p[3 + stride] = (byte)nPixel;
                            }
                        }

                        p += 3;
                        pSrc += 3;
                    }

                    p += nOffset;
                    pSrc += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return true;
        }

        public static bool GaussianBlur(this Bitmap b, int nWeight /* default to 4*/)
        {
            var m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
            m.Factor = nWeight + 30;

            return b.Conv3X3(m);
        }

        public class ConvMatrix
        {
            public int TopLeft, TopMid, TopRight;
            public int MidLeft, Pixel = 1, MidRight;
            public int BottomLeft, BottomMid, BottomRight;
            public int Factor = 1;
            public int Offset = 0;
            public void SetAll(int nVal)
            {
                TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
            }
        }
    }
}
