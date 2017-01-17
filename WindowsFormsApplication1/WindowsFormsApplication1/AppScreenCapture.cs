using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AppScreenCapture
{
    class AppScreenCapture
    {
        #region DLL Imports
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

        [DllImport("user32.dll")]
        static extern bool GetWindowRgn(IntPtr hWnd, IntPtr hRgn);

        [DllImport("gdi32.dll")]
        static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
        #endregion
        #region Global Value
        static Graphics gfxBmp;
        static Region region;
        #endregion
        public static void PrintW(IntPtr hwnd)
        {
            Rectangle rc = Rectangle.Empty;
            Graphics gfxWin = Graphics.FromHwnd(hwnd);
            rc = Rectangle.Round(gfxWin.VisibleClipBounds);

            Bitmap bmp = new Bitmap(
                rc.Width, rc.Height,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            try { 
                gfxBmp = Graphics.FromImage(bmp);
                IntPtr hdcBitmap = gfxBmp.GetHdc();
                bool succeeded = PrintWindow(hwnd, hdcBitmap, 1);
                gfxBmp.ReleaseHdc(hdcBitmap);
                IntPtr hRgn = CreateRectRgn(0, 0, 0, 0);
                GetWindowRgn(hwnd, hRgn);
                region = Region.FromHrgn(hRgn);
            }
            catch (Exception)
            {
                gfxBmp.FillRectangle(
                new SolidBrush(Color.Gray),
                new Rectangle(Point.Empty, bmp.Size));
                gfxBmp.ExcludeClip(region);
                gfxBmp.Clear(Color.Transparent);
            }finally
            {
                bmp.Save("test.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                gfxBmp.Dispose();
            }
        }


    }
}
