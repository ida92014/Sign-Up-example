using static System.Runtime.InteropServices.JavaScript.JSType;

namespace newHomework
{

    public partial class Form1 : Form
    {

        List<string> Data = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                label3.Text = "please fill the fields";
            }
            else
            {
                Data.Add(textBox3.Text);
                Data.Add(textBox4.Text);
                Data.Add(textBox5.Text);
                panel2.Visible = false;
                label2.Visible = true;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '.';

            if (textBox5.Text.Length < 6)
            {
                label1.Text = "it is too short";
            }
            else
            {
                label1.Text = "";
                bool lo = false;
                foreach (var item in textBox5.Text)
                {
                    if (item >= 'A' && item <= 'Z')
                    {
                        lo = true;
                    }

                }
                if (!lo)
                {
                    label1.Text = "Add uppercase letter";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool il = false;

            foreach (var item in textBox3.Text)
            {
                if (item == '@')
                {
                    il = true;
                }
            }
            if (il)
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "this gmail doesn't exist";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "show")
            {
                textBox5.UseSystemPasswordChar = true;
                label4.Text = "hide";
            }
            else
            {

                textBox5.UseSystemPasswordChar = false;
                label4.Text = "show";



            }
        }
    }
}