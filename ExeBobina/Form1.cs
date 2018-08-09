using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBobina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        List<string> listMedidas = new List<string>();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            GetMedidas(tbValorMadidas.Text);

            double resp = Convert.ToDouble(tbPesoTotal.Text) / aux;
            double pesoTotal = 0;
            for(int i =0; i < listMedidas.Count; i++)
            {
                lblResp.Text += "\n Medida: "+listMedidas[i]+" = "+
                    (Convert.ToDouble(listMedidas[i]) * resp);
                pesoTotal += Convert.ToDouble(listMedidas[i]);
            }

            lblResp.Text += "\n Peso total: " + pesoTotal * listMedidas.Count + " \n Resp: " + resp ;

        }

        double aux;
        public List<string> GetMedidas(string medidas)
        {
            string[] list = medidas.Split(',');

            foreach(string lists in list)
            {
                listMedidas.Add(lists);
              
            }

            for(int i = 0; i < listMedidas.Count; i++)
            {
                aux = Convert.ToDouble(listMedidas[i]);
            }
            

            return listMedidas;
        }
    }
}
