using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTesteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBreakTeste_Click(object sender, EventArgs e)
        {
            string saida = "";
            int contador;

            for(contador = 1; contador <= 10; contador++)
            {
                if (contador == 5)
                    break; // pula o código restante no laço
                           // se contador == 5

                saida += contador + ""; 
            } // fim do laço

            saida += "\nSaiu do loop na contagem = " + contador;

            MessageBox.Show(saida, "Demonstrando a declaração break",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
