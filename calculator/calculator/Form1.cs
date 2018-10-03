using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    
    public partial class Form1 : Form
    {
        double x, y, res;
        string op;
        Boolean flage = false;
        Boolean flage_off_on = false;
        private void operators(object sender, EventArgs e)
        {
            if(op != null)
            {
                btnequal_Click(null, null);
            }

            if(txtdisplay.Text.Contains("Sin") || txtdisplay.Text.Contains("Cos") || txtdisplay.Text.Contains("Abs"))
            {
                string str = txtdisplay.Text.Substring(3);

                double temp = Convert.ToDouble(str);

                if (txtdisplay.Text.Contains("Sin"))
                {
                    x = Math.Sin(temp);
                }
                if (txtdisplay.Text.Contains("Cos"))
                {
                    x = Math.Cos(temp);
                }
                if (txtdisplay.Text.Contains("Abs"))
                {
                    x = Math.Abs(temp);
                }
                op = ((Button)sender).Text;
                flage = true;
            }
            else
            {
                x = Convert.ToDouble(txtdisplay.Text);
                op = ((Button)sender).Text;
                // txtdisplay.Text = "";
                flage = true;
            }
            txtdisplay.Text = "";
            btnsin.Enabled = true;
            btncos.Enabled = true;
            btnabs.Enabled = true;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {

            if (txtdisplay.Text.Contains("Sin") || txtdisplay.Text.Contains("Cos") || txtdisplay.Text.Contains("Abs"))
            {
                string str = txtdisplay.Text.Substring(3);

                double temp = Convert.ToDouble(str);

                if (txtdisplay.Text.Contains("Sin"))
                {
                    res = Math.Sin(temp);
                }
                if (txtdisplay.Text.Contains("Cos"))
                {
                    res = Math.Cos(temp);
                }
                if (txtdisplay.Text.Contains("Abs"))
                {
                    res = Math.Abs(temp);
                }
                txtdisplay.Text = res.ToString();
                op = null;
            }
            else
            {
                y = Convert.ToDouble(txtdisplay.Text);

                switch (op)
                {
                    case "+":
                        res = x + y;
                        break;
                    case "-":
                        res = x - y;
                        break;
                    case "*":
                        res = x * y;
                        break;
                    case "/":
                        res = x / y;
                        break;
                    case "pow":
                        res = Math.Pow(x, y);
                        break;
                }
                txtdisplay.Text = res.ToString();
                op = null;
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        { 
            if (flage_off_on == false)
            {
                foreach(Button x in panel1.Controls)
                {
                    x.Enabled = true;
                }
                flage_off_on = true;
                btnOnOff.Text = "OFF";
            }
            else
            {
                foreach (Button x in panel1.Controls)
                {
                    x.Enabled = false;
                }
                flage_off_on = false;
                btnOnOff.Text = "ON";
            }
            string s,t;
            s = "ABCDEF";
           // MessageBox.Show(s.Substring(0,s.Length-1));
            //  MessageBox.Show(s.Contains("Cx"). ToString());
           // MessageBox.Show(Convert.ToBoolean(txtdisplay.Text.Length).ToString());
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {
            //
            if(txtdisplay.Text.Length > 0)
            {
                btnsin.Enabled = false;
                btncos.Enabled = false;
                btnabs.Enabled = false;
            }
            else {
                btnsin.Enabled = true;
                btncos.Enabled = true;
                btnabs.Enabled = true;
            }
            //
            if(txtdisplay.Text.Contains(".") == true)
            {
                btnpoint.Enabled = false;
            }
            else
            {
                btnpoint.Enabled = true;
            }

            if (Convert.ToBoolean(txtdisplay.Text.Length) == false)
            {
                btnBackSpace.Enabled = false;
            }
            else
            {
                btnBackSpace.Enabled = true;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "Sin" || txtdisplay.Text == "Cos" || txtdisplay.Text == "Abs" || txtdisplay.Text == "pow")
            {
                txtdisplay.Text = "";
            }
            if (txtdisplay.Text.Length > 0)
            {
                txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
            }
            if(txtdisplay.Text.Contains("Sin") || txtdisplay.Text.Contains("Cos") || txtdisplay.Text.Contains("Abs") || txtdisplay.Text.Contains("pow"))
            {
                if (txtdisplay.Text.Length == 3)
                    txtdisplay.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdisplay_TextChanged(null, null);
            foreach (Button x in panel1.Controls)
            {
                x.Enabled = false;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (flage_off_on == true)
            {
                foreach (Button x in panel1.Controls)
                    if (x.Text == e.KeyChar.ToString())
                    {
                        x.Focus();
                        x.ForeColor = Color.Red;
                    }
                    else
                    {
                        x.ForeColor = Color.Black;
                    }

                Button temp = new Button();
                temp.Text = e.KeyChar.ToString();
                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {
                    numbers(temp, null);
                }
                else if (e.KeyChar == '+' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                {
                    operators(temp, null);
                }
                else if (e.KeyChar == '=')
                {
                    btnequal_Click(null, null);
                }
                else if (e.KeyChar == '.' && txtdisplay.Text.Contains(".") == false)
                {
                    numbers(temp, null);
                }
                else if (e.KeyChar == '\b')
                {
                    btnBackSpace_Click(null, null);
                }
            }
        }

        private void btnadvance_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ((Button)sender).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            res = 0;
            op = null;
            x = 0;
            y = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            if (flage == true)
            {
                txtdisplay.Text = "";
                flage = false;
            }
            txtdisplay.Text += ((Button)sender).Text;

        }
    }
}
