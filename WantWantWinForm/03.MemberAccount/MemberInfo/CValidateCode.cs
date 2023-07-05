using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWantWantWinForm.MemberInfo
{
    internal class CValidateCode
    {
        public string GenerateCheckCode() //產生驗證碼的內容(4碼英文大寫&數字)
        {
            int number;
            char code;
            string checkCode = String.Empty;

            System.Random random = new Random();
            
            for (int i = 0; i < 4; i++)
            {
                number = random.Next();

                if (number % 2 == 0)
                    code = (char)('0' + (char)(number % 10));
                else if (number % 3 == 0)
                    code = (char)('A' + (char)(number % 26));
                else
                    code = (char)('a' + (char)(number % 26));
                checkCode += code.ToString();
            }
            return checkCode.ToUpper();
        }

        public Bitmap CreateCheckCodeImage(string checkCode, int w = 54, int h = 30)
        {
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(w, h);
            Graphics g = Graphics.FromImage(image);

            g.Clear(Color.WhiteSmoke);  //清除背景色

            Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple }; //定義隨機顏色

            string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
            Random rand = new Random();
            int z = 10;  //干擾線線條數
            for (int i = 0; i < z; i++)
            {
                int x1 = rand.Next(image.Width);
                int x2 = rand.Next(image.Width);
                int y1 = rand.Next(image.Height);
                int y2 = rand.Next(image.Height);
                g.DrawLine(new Pen(Color.LightGray, 1), x1, y1, x2, y2);  //根據座標畫線
            }

            for (int i = 0; i < checkCode.Length; i++)
            {
                int cindex = rand.Next(7);
                int findex = rand.Next(5);

                Font f = new System.Drawing.Font(font[findex], 14, System.Drawing.FontStyle.Bold);
                Brush b = new System.Drawing.SolidBrush(c[cindex]);
                int ii = 4;
                if ((i + 1) % 2 == 0)
                {
                    ii = 2;
                }
                g.DrawString(checkCode.Substring(i, 1), f, b, 3 + (i * (14)), ii);
            }
            image = TwistImage(image, true, 3, 1);
            g.DrawRectangle(new Pen(Color.Black, 0), 0, 0, image.Width - 1, image.Height - 1);
            return image;
        }

        #region  產生波型扭曲效果

        private const double PI = 3.1415926535897932384626433832795;
        private const double PI2 = 6.283185307179586476925286766559;

       
        //srcBmp：圖片路徑，bXDir：如果扭曲>True，nMultValue：波型的幅度倍數，越大扭曲程度越高，建議為3，dPhase：波型的起始單位，區間為[0-2*PI]
        public System.Drawing.Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase) 
        {
            System.Drawing.Bitmap destBmp = new Bitmap(srcBmp.Width, srcBmp.Height);

            // 背景顏色為白色
            System.Drawing.Graphics graph = System.Drawing.Graphics.FromImage(destBmp);
            graph.FillRectangle(new SolidBrush(System.Drawing.Color.White), 0, 0, destBmp.Width, destBmp.Height);
            graph.Dispose();

            double dBaseAxisLen = bXDir ? (double)destBmp.Height : (double)destBmp.Width;

            for (int i = 0; i < destBmp.Width; i++)
            {
                for (int j = 0; j < destBmp.Height; j++)
                {
                    double dx = 0;
                    dx = bXDir ? (PI2 * (double)j) / dBaseAxisLen : (PI2 * (double)i) / dBaseAxisLen;
                    dx += dPhase;
                    double dy = Math.Sin(dx);

                    // 取得當前點的顏色
                    int nOldX = 0, nOldY = 0;
                    nOldX = bXDir ? i + (int)(dy * dMultValue) : i;
                    nOldY = bXDir ? j : j + (int)(dy * dMultValue);

                    System.Drawing.Color color = srcBmp.GetPixel(i, j);
                    if (nOldX >= 0 && nOldX < destBmp.Width
                     && nOldY >= 0 && nOldY < destBmp.Height)
                    {
                        destBmp.SetPixel(nOldX, nOldY, color);
                    }
                }
            }

            return destBmp;
        }

        #endregion
        
    }
}
