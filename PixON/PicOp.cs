using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PixON
{
    class PicOp
    {
        public static void ImportClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                Image clipImg = Clipboard.GetImage();
                if (File.Exists("temp/tmp.png")) File.Delete("temp/tmp.png");
                clipImg.Save("temp/tmp.png",System.Drawing.Imaging.ImageFormat.Png);

                string imgMD5 = Format.GetMD5("temp/tmp.png");
                string fileName = "data/" + imgMD5 + ".png";
                if (File.Exists(fileName)) File.Delete(fileName);
                clipImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);

                PixONDb picDb = new PixONDb();
                picDb.AddFile(fileName, imgMD5);

                var addPopup = new AddPopup();
                addPopup.imgMD5 = imgMD5;
                addPopup.Show();
            }
            else
            {
                MessageBox.Show("剪贴板中未找到图片！");
            }
        }
    }
}
