namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     



        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;


        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "Kare";
            panel1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            button1.Visible = true;
            button4.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "Dikd�rtgen";
            panel1.Visible = true;
            button4.Visible = true;
            button1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int uzunkenar, k�sakenar;
            double alan, �evre;
            k�sakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);

            alan = k�sakenar * uzunkenar;
            �evre = (k�sakenar + uzunkenar) * 2;
            label5.Text = alan.ToString();
            label6.Text = �evre.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int kenar;
            double alann, �evree;
            kenar = Convert.ToInt32(textBox1.Text);
            alann = kenar * kenar;
            �evree= (kenar + kenar) * 2;
            label5.Text= alann.ToString();
            label6.Text=�evree.ToString();


        }
    }
}
