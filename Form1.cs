namespace TP_MODUL3_103022400078
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool start = true;
        private void flag()
        {
            if (start)
            {
                label1.Text = "";
                start = false;
            }
        }

        private string angka1 = null, angka2 = null;

        private void button1_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "1";
            } else
            {
                angka2 += "1";
            }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "2";
            } else
            {
                angka2 += "2";
            }
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "3";
            }else
            {
                angka2 += "3";
            }
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {                 
                angka1 += "4";   
            } else
            {
                angka2 += "4";
            }
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "5";   
            } else
            {
                angka2 += "5";
            }
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 = "6";   
            } else
            {
                angka2 += "6";
            }
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "7";   
            } else
            {
                angka2 += "7";
            }
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "8";   
            } else
            {
                angka2 += "8";
            }
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "9";   
            } else
            {
                angka2 += "9";
            }
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                label1.Text = angka1;
            }
            else
            {
                label1.Text = "";
                int hasil = Convert.ToInt32(angka1) + Convert.ToInt32(angka2);
                label1.Text = Convert.ToString(hasil);
            }
            start = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flag();
            angka2 = "";
            label1.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            flag();
            if (angka2 == null)
            {
                angka1 += "0";
            } 
            else 
            {
                angka2 += "0";
            }
            label1.Text += "0";
        }
    }
}
