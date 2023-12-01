using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMyAppFirst
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет мир!", "Сообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonPlus.Checked)
                {
                    int a = Convert.ToInt32(textBoxVarA.Text);
                    int b = Convert.ToInt32(textBoxVarB.Text);

                    int c = a + b;

                    textBoxResult.Text = Convert.ToString(c);
                }

                if (radioButtonMinus.Checked)
                {
                    int a = Convert.ToInt32(textBoxVarA.Text);
                    int b = Convert.ToInt32(textBoxVarB.Text);

                    int c = a - b;

                    textBoxResult.Text = Convert.ToString(c);
                }

                if (radioButtonMult.Checked)
                {
                    int a = Convert.ToInt32(textBoxVarA.Text);
                    int b = Convert.ToInt32(textBoxVarB.Text);

                    int c = a * b;

                    textBoxResult.Text = Convert.ToString(c);
                }

                if (radioButtonDiv.Checked)
                {
                    double a = Convert.ToDouble(textBoxVarA.Text);
                    double b = Convert.ToDouble(textBoxVarB.Text);

                    double z = a / b;

                    textBoxResult.Text = Convert.ToString(z);
                }

            }
            catch
            {

                MessageBox.Show("Неверный ввод данных ", " Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            




        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
