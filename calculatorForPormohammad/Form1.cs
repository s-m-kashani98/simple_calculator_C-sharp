namespace calculatorForPormohammad
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        double[] num = new double[100];
        double total = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            myTxt.Clear();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 0;
            }
        }
        
        private void Btn7_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "7";
                this.myTxt.Focus();
            }
            else
                myTxt.Text += "7";
        }
        private void Btn8_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "8";
            }
            else
                myTxt.Text += "8";
        }

        private void Btn9_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "9";
            }
            else
                myTxt.Text += "9";
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "4";
            }
            else
                myTxt.Text += "4";
        }

        private void Btn5_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "5";
            }
            else
                myTxt.Text += "5";
        }

        private void Btn6_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "6";
            }
            else
                myTxt.Text += "6";
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "1";
            }
            else
                myTxt.Text += "1";
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "2";
            }
            else
                myTxt.Text += "2";
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text == "0")
            {
                myTxt.Text = "3";
            }
            else
                myTxt.Text += "3";
        }
        private void BtnDot_Click(object sender, System.EventArgs e)
        {
            if (!myTxt.Text.Contains("."))
            {
                myTxt.Text += ".";
            }

        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            if (myTxt.Text != "0")
            {
                myTxt.Text += "0";
            }
        }

        private void BtnSubstract_Click(object sender, System.EventArgs e)
        {
            if (count == 0)
            {
                num[0] = System.Convert.ToDouble(myTxt.Text);
                myTxt.Clear();
                count++;
            }
            else if (count == 1)

            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] + num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] - num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] * num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] / num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total += num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total -= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total *= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total /= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "=":
                        count = 1;
                        num[0] = total;
                        myTxt.Clear();
                        break;
                    default:
                        break;
                }

            }
            LblSitu.Text = " -";
    }

        private void Btnmultiply_Click(object sender, System.EventArgs e)
        {
            if (count == 0)
            {
                num[0] = System.Convert.ToDouble(myTxt.Text);
                myTxt.Clear();
                count++;
            }
            else if (count == 1)

            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] + num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] - num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] * num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] / num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total += num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total -= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total *= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total /= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "=":
                        count = 1;
                        num[0] = total;
                        myTxt.Clear();
                        break;
                    default:
                        break;
                }

            }
            LblSitu.Text = "x";
        }

        private void BtnDivide_Click(object sender, System.EventArgs e)
        {
            if (count == 0)
            {
                num[0] = System.Convert.ToDouble(myTxt.Text);
                myTxt.Clear();
                count++;
            }
            else if (count == 1)

            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] + num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] - num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] * num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] / num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total += num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total -= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total *= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total /= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "=":
                        count = 1;
                        num[0] = total;
                        myTxt.Clear();
                        break;
                    default:
                        break;
                }

            }
            LblSitu.Text = "/";

        }

        private void BtnSum_Click(object sender, System.EventArgs e)
        {
            if (count==0)
            {
                num[0] = System.Convert.ToDouble(myTxt.Text);
                myTxt.Clear();
                count++;
            }
            else if (count==1)

            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] + num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] - num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] * num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[1] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] / num[1];
                        myTxt.Clear();
                        count++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total +=num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case " -":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total -= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "x":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total *= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "/":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total /= num[count];
                        myTxt.Clear();
                        count++;
                        break;
                    case "=":
                        count = 1;
                        num[0] = total;
                        myTxt.Clear();
                        break;
                    default:
                        break;
                }
            }
            LblSitu.Text = "+";
        }

        private void BtnEqual_Click(object sender, System.EventArgs e)
        {
            if (count==1)
            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total = num[1]+num[0];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case " -":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0] - num[1];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case "x":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total = num[1] * num[0];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case "/":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total = num[0]/num[1];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case "=":
                        break;
                    default:
                        break;
                }
                LblSitu.Text = "=";
            }
            else if (count>1)
            {
                switch (LblSitu.Text)
                {
                    case "+":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total += num[count];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case " -":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total -= num[count];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case "x":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total *= num[count];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case "/":
                        num[count] = System.Convert.ToDouble(myTxt.Text);
                        total /= num[count];
                        myTxt.Text = total.ToString();
                        count++;
                        break;
                    case "=":
                        break;
                    default:
                        break;
                }
                LblSitu.Text = "=";
            }
        }

        private void myTxt_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)&&!char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar)&&e.KeyChar=='.')
            {
                if (!myTxt.Text.Contains("."))
                {
                    myTxt.Text += ".";
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
