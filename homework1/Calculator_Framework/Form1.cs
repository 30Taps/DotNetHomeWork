using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator_Framework
{
    public partial class Form1 : Form
    {
        public static int num_1 = 1;
        public static int num_2 = 1;
        public static string sym = "";

        public Form1()
        {
            InitializeComponent();
            num_1 = 1;
            num_2 = 1;
            sym = "";

        }

        private void Num1Text_TextChanged(object sender, EventArgs e)
        {
            if (Num1Text.Text.ToString()=="")
            {
                num_1 = 1;
            }
           else if(int.TryParse(Num1Text.Text.ToString(),out num_1))
            {
                num_1 = Convert.ToInt32(Num1Text.Text.ToString());
            }
            else
            {
                MessageBox.Show("输入有误");
                Num1Text.Focus();
                return;

            }
        }



        private void Num2Text_TextChanged(object sender, EventArgs e)
        {
            if(Num2Text.Text.ToString()=="")
            {
                num_2=1;
            }
            else if (int.TryParse(Num2Text.Text.ToString(), out num_2))
            {
                num_2 = int.Parse(Num2Text.Text.ToString());

            }
            else
            {
                MessageBox.Show("输入有误");
                Num2Text.Focus();
                return;

            }
        }
        private void ResultText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            switch(sym)
            {
                case "+": ResultText.Text = $"{num_1 + num_2}"; break;
                case "-": ResultText.Text = $"{num_1 - num_2}"; break;
                case "*": ResultText.Text = $"{num_1 * num_2}"; break;
                case "/":
                    {
                        if(num_2!=0)
                        {
                                            ResultText.Text = $"{num_1 / num_2}"; break;


                        }
                        else
                        {
                            MessageBox.Show("除0错误");
                            Num2Text.Focus();
                            return;
                        }
                    }
            }
        }

        private void symble_SelectedIndexChanged(object sender, EventArgs e)
        {
            sym=symble.SelectedItem.ToString();

        }
    }
}
