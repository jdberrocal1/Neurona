using System;
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

        int[,] matriz = new int[10, 10] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
        int x = 0;
        int y = 0;
        
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
            Neurotron insNeurotron = new Neurotron();
            if (check.Checked)
            {
                result.Text = insNeurotron.checkMatrix(getMatrixFromIMG());
            }
            else
            {
                result.Text = insNeurotron.checkMatrix(getMatriz()); 
            }
        }

        protected void paintButton(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button btn = ((System.Web.UI.WebControls.Button)sender);
            string id = btn.ID;
            string posx = id.Substring(1,1);
            string posy = id.Substring(2);
            x = Convert.ToInt32(posx);
            y = Convert.ToInt32(posy);

            

            Color _color = btn.BackColor;
            if (_color.Equals(System.Drawing.ColorTranslator.FromHtml("#1186ab")))
            {
                btn.BackColor = Color.Black;

                
            }
            else
            {
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#1186ab");
                
            }
           
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

        public int[] getMatriz()
        {
            int[] vector = new int[100];
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    System.Web.UI.WebControls.Button btn = ((System.Web.UI.WebControls.Button)FindControl("b"+i.ToString()+j.ToString()));
                    if (btn.BackColor.Equals(System.Drawing.ColorTranslator.FromHtml("#1186ab")))
                    {
                        vector[cont] = 1;
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        vector[cont] = 0;
                        matriz[i, j] = 0;
                    }
                    cont++;
                }
            }
            return vector;
        }

        protected int[] getMatrixFromIMG() {
            image.PostedFile.SaveAs(Server.MapPath("~/Upload/") + Path.GetFileName(image.PostedFile.FileName));
            string file = Server.MapPath("Upload/" + image.PostedFile.FileName);
            img.ImageUrl = "~/Upload/" + image.PostedFile.FileName;
            Bitmap myBitmap = GrayScale(new Bitmap(file));
            int[] vector = new int[100];
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Color pixelColor = myBitmap.GetPixel(j, i);
                    Color color = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    if (pixelColor.Equals(color))
                    {
                        vector[cont] = 0;
                        matriz[j, i] = 0;
                    }
                    else
                    {
                        vector[cont] = 1;
                        matriz[j, i] = 1;
                    }
                    cont++;

                }

            }
            return vector;
        }
    }
}