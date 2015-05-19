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
<<<<<<< HEAD
        int[,] matriz = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
=======

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
>>>>>>> 849efd94945994cc06f081b6447b04184ec4c66e
        int x = 0;
        int y = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void evaluate(object sender, EventArgs e)
        {
            Neurotron insNeurotron = new Neurotron();
            result.Text=insNeurotron.checkMatrix(getMatriz(), Convert.ToDouble(10/100)); // RETORNA LA LETRAS QUE SE TIENE QUE MOSTRAR
            
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
    }
}