using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using CRM.Common;
using System.IO;
using System.Drawing.Imaging;

namespace CRM.Web.Areas.Admin.Controllers
{
    public class VCodeController : Controller
    {
        // GET: Admin/VCode
        public ActionResult Index()
        {
            var code = GetHashCode(1);
            Session[Keys.code] = code;
            using (Image img = new Bitmap(75, 30))
            {
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.Clear(Color.White);
                    g.DrawString(code, new Font("黑体", 14, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout),new SolidBrush(Color.Red),1,2);
                }

                byte[] imgBuffer;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    imgBuffer = ms.ToArray();
                }

                return File(imgBuffer,"image/jpeg");
            }
        }

        private string GetHashCode(int v)
        {
            Random r = new Random();
            string str = "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string res = string.Empty;
            int leng = str.Length;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < v; i++)
                {
                    res += str[r.Next(leng)];
                }
            }
            return res;
        }
    }
}