using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Neurona
{
    public partial class Index : System.Web.UI.Page
    {
                
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public Bitmap GrayScale(Bitmap Bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y < Bmp.Height; y++)
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return Bmp;
        }

        protected void evaluate(object sender, EventArgs e)
        {
            //Neurotron insNeurotron = new Neurotron();
            //result.Text = insNeurotron.checkMatrix(getMatrixFromIMG(),Convert.ToDouble(learning.Text));

            ArrayList x = getMatrixFromIMG();
        }

        

        static public Bitmap ScaleImage(System.Drawing.Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            Bitmap bmp = new Bitmap(newImage);

            return bmp;
        }

        protected Bitmap getBitmapImage()
        {
            image.PostedFile.SaveAs(Server.MapPath("~/Upload/") + Path.GetFileName(image.PostedFile.FileName));
            string file = Server.MapPath("Upload/" + image.PostedFile.FileName);
            img.ImageUrl = "~/Upload/" + image.PostedFile.FileName;
            //Bitmap myBitmap = GrayScale(new Bitmap(file));
            return new Bitmap(file);
        }

        protected bool isCleanColumn(Bitmap img, int colum)
        {
            bool clean = true;
            for (int i = 0; i < 10; i++)
            {
                Color pixelColor = img.GetPixel(colum, i);
                Color color = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                if (pixelColor.Equals(color))
                {
                    clean = true;
                }
                else
                {
                    clean = false;
                    break;
                }
            }
                return clean;
        }

        protected ArrayList getMatrixFromIMG() {
            Bitmap myBitmap = getBitmapImage();
            int[] vector = new int[100];
            int cont = 0;
            Color color = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            ArrayList matriz = new ArrayList();
            

            for (int c = 0; c < myBitmap.Width; c += 10)
            {
                bool cleanColumn = isCleanColumn(myBitmap, c);
                if (!cleanColumn)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = c; j < c+10; j++)
                        {

                            Color pixelColor = myBitmap.GetPixel(j, i);

                            if (pixelColor.Equals(color))
                            {
                                vector[cont] = 0;
                                
                            }
                            else
                            {
                                vector[cont] = 1;
                                
                            }
                            cont++;
                        }
                    }

                matriz.Add(vector);
                }
                else
                {
                    c-=9;
                }
                cont = 0;
                
                vector = new int[100];
                
            }
            
            return matriz;
        }
    }
}