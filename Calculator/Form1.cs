using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Operand = ","; 
            
            string FullString2 = textBox1.Text;
            int  j = 0;
            while ((Operand != "+") && (Operand != "-") && (Operand != "/") && (Operand != "*"))
            {
                Operand = FullString2.Substring(j, 1); ///Remove заменить на команду с вытаскиванием элемента из строки по номеру элемента
                j = j + 1;
            };


            string Right, Left;
            Right = textBox1.Text;
            Right = Right.Substring(j, FullString2.Length-j);

            Left = textBox1.Text;
            Left = Left.Substring(0, j-1);


        }
    }
}
