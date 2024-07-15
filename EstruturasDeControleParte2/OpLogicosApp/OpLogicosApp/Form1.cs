using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpLogicosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bOpLogicos_Click(object sender, EventArgs e)
        {
            // testando o operador E condicional (&&)
            MessageBox.Show("CONDICIONAL AND (&&)" +
                "\nfalse && false: " + (false && false) +
                "\nfalse  && true: " + (false && true) +
                "\ntrue && false: " + (true && false) +
                "\nrtrue && true: " + (true && true));

            // testando o operador OU condicional (||)
            MessageBox.Show("\n\nCONDICIONAL OR(||)" +
               "\nfalse || false: " + (false || false) +
               "\nfalse  || true: " + (false || true) +
               "\ntrue || false: " + (true || false) +
               "\nrtrue || true: " + (true || true));

            // testando o operador E lógico (&)
            MessageBox.Show("\n\nLÓGICO AND (&)" +
               "\nfalse & false: " + (false & false) +
               "\nfalse  & true: " + (false & true) +
               "\ntrue & false: " + (true & false) +
               "\nrtrue & true: " + (true & true));

            // testando o operador OU lógico (|)
            MessageBox.Show("\n\nLÓGICO OR (|)" +
               "\nfalse | false: " + (false | false) +
               "\nfalse  | true: " + (false | true) +
               "\ntrue | false: " + (true | false) +
               "\nrtrue | true: " + (true | true));

            // testando o operador OU exclusivo lógico (^)
            MessageBox.Show("\n\nEXCLUSIVO LÓGICO OR (^)" +
               "\nfalse ^ false: " + (false ^ false) +
               "\nfalse  ^ true: " + (false ^ true) +
               "\ntrue ^ false: " + (true ^ false) +
               "\nrtrue ^ true: " + (true ^ true));

            // testando o operador Não lógico (!)
            MessageBox.Show("\n\nLÓGICA NÃO (!)" +
            "\n!false: " + (!false) +
            "\n!true: " + (!true));
        }
    }
}
