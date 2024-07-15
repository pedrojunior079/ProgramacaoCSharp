using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurosCompostosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJurosCompostos_Click(object sender, EventArgs e)
        {
            decimal quantia, principal = (decimal) 1000.00;
            double  taxa = 0.5;
            string saida;

            saida = "Ano \tValor em depósito\n";
            for(int ano = 1; ano <= 10; ano++)
            {
                quantia = principal *
                    (decimal)Math.Pow(1.0 + taxa, ano);

                saida += ano + "\t" +
                    String.Format("{0:C}", quantia) + "\n";
                    
            }
            MessageBox.Show(saida, "Juros Compostos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
