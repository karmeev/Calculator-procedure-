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
                Operand = FullString2.Substring(j, 1); 
                j = j + 1;
            };
 
           string Right = FullString2.Substring(j, FullString2.Length-j);
           string Left = FullString2.Substring(0, j-1);




        }
    }
}
