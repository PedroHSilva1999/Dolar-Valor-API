using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bitcoin_Valor_API.Dolar;
namespace Dolar_Valor_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            Dolar_Cotacao ValorDolar = new Dolar_Cotacao();
            txtDolar.Text = "Valor de compra do Dólar: " + ValorDolar.api_response();


        }
    }


   
}
