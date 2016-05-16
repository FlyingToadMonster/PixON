using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PixON
{
    class PicOp
    {
        public static void ImportClipboard()
        {
            bool foundImage = false;
            Image clipImg = null;
            if (Clipboard.ContainsData(DataFormats.Html))
            {
                string clipHtml = (string)Clipboard.GetData(DataFormats.Html);
                int startPos = clipHtml.IndexOf("\"") + 9;
                int endPos = clipHtml.IndexOf("\"", startPos);
                if (startPos > 8 && endPos >= 0)
                {
                    string path = clipHtml.Substring(startPos, endPos - startPos);
                    if (File.Exists(path))
                    {
                        clipImg = Image.FromFile(path);
                        foundImage = true;
                    }
                }
            }
            if (!foundImage && Clipboard.ContainsImage())
            {
                clipImg = Clipboard.GetImage();
                foundImage = true;
            }

            if (!foundImage)
            {
                MessageBox.Show("未找到图片！");
                return;
            }

            if (File.Exists("temp/tmp.png")) File.Delete("temp/tmp.png");
            clipImg.Save("temp/tmp.png", System.Drawing.Imaging.ImageFormat.Png);
            string imgMD5 = Format.GetMD5("temp/tmp.png");
            File.Delete("temp/tmp.png");

            string fileName = "data/" + imgMD5 + ".png";
            if (!File.Exists(fileName)) clipImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);

            PixONDb picDb = new PixONDb();
            picDb.AddFile(fileName, imgMD5);
            picDb.Close();

            var addPopup = new PropPopup();
            addPopup.imgMD5 = imgMD5;
            addPopup.fileName = fileName;
            addPopup.Text = "添加图片";

            addPopup.Show();
            addPopup.Activate();
        }

        public static void EditProp(string fileName)
        {
            Clipboard.SetImage(Image.FromFile(fileName));
            ImportClipboard();
        }
    }
}
