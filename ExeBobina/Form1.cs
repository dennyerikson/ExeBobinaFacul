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
            switch (btnCalcular.Text)
            {
                case "=":
                    // obtendo o valor das medidas 08/08
                    GetMedidas(tbValorMadidas.Text);

                    // peso total dividido pela soma das medidas 08/08
                    double resp = Convert.ToDouble(tbPesoTotal.Text) / aux;
                    double pesoTotal = 0;
                    for (int i = 0; i < listMedidas.Count; i++)
                    {
                        lblResp.Text += "\n Medida: " + listMedidas[i] + " = Peso: " +
                            // multiplicação das medias por retorno de "resp" 09/08/2018
                             (resp * (Convert.ToDouble(listMedidas[i]))).ToString("n2") +" kg";
                        // soma dos pesos 09/08/2018
                        (pesoTotal += (resp * (Convert.ToDouble(listMedidas[i])))).ToString("n2");
                    }
                    lblResp.Text += "\n\nPeso total: " + pesoTotal +" kg"+ " \nPeso por mm: " + resp.ToString("n4")+
                        "\n\nFormula: (valor_medida * (peso_total / soma_medidas))"+
                        "\nCréditos a formula Alcides Galdino";

                    btnCalcular.Text = "↑↓";
                    break;

                case "↑↓":

                    tbPesoTotal.Text = "";
                    tbValorMadidas.Text = "";
                    lblResp.Text = "";
                    btnCalcular.Text = "=";

                    break;
            }
        }

        double aux;
        // carregar lista
        public List<string> GetMedidas(string medidas)
        {
            // remoção das virgulas para a lista
            string[] list = medidas.Split(',');

            foreach(string lists in list)
            {
                listMedidas.Add(lists);              
            }

            for(int i = 0; i < listMedidas.Count; i++)
            {
                // soma das medias da lista 
                aux += Convert.ToDouble(listMedidas[i]);
            }
            return listMedidas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
