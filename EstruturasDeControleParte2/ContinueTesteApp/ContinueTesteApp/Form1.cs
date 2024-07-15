using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinueTesteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContinueTeste_Click(object sender, EventArgs e)
        {
            string saida = "";

            for(int contador = 1; contador <= 10; contador++)
            {
                if (contador == 5)
                    continue;           // pula o código restante no laço
                                        // apenas se contador == 5

                saida += contador + " ";
            }

            saida += "\nUsado continuar para pular a impressão 5";

            MessageBox.Show(saida, "Usando a instrução continue",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
