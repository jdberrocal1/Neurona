using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Neurona
{
    public partial class Index : System.Web.UI.Page
    {

        int[,] matriz = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        int x = 0;
        int y = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void matrix(object sender, EventArgs e)
        {
            getMatriz();
             mat.Text = matriz[0, 0] + " " + matriz[0, 1] + " " + matriz[0, 2] + " " + matriz[0, 3] + " " + matriz[0, 4] + "\n"+
                matriz[1, 0] + " " + matriz[1, 1] + " " + matriz[1, 2] + " " + matriz[1, 3] + " " + matriz[1, 4] + "\n"+
                matriz[2, 0] + " " + matriz[2, 1] + " " + matriz[2, 2] + " " + matriz[2, 3] + " " + matriz[2, 4] + "\n"+
                matriz[3, 0] + " " + matriz[3, 1] + " " + matriz[3, 2] + " " + matriz[3, 3] + " " + matriz[3, 4] + "\n"+
                matriz[4, 0] + " " + matriz[4, 1] + " " + matriz[4, 2] + " " + matriz[4, 3] + " " + matriz[4, 4] + "\n";
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

        public void getMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    System.Web.UI.WebControls.Button btn = ((System.Web.UI.WebControls.Button)FindControl("b"+i.ToString()+j.ToString()));
                    if (btn.BackColor.Equals(System.Drawing.ColorTranslator.FromHtml("#1186ab")))
                    {
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }
        }
    }
}