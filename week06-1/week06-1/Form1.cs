using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week06_1
{
    public partial class Form1 : Form
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string message { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Power of 10^3 is {power(baseValue: 10, exponentValue: 3)}"); // exponentValue: 3, baseValue: 10 şeklinde de yazılabilir
            // çünkü spesifik belirttik

            this.fullName = null;
            this.email = null;
            this.message = null;

            timer1.Start();
        }


        private int power(int baseValue, int exponentValue = 2)
        {
            int result = 1;
            for(int i = 1; i <= exponentValue; i++)
            {
                result *= baseValue;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.fullName))
                    throw new Exception("Please sign up firstly");
                if (string.IsNullOrEmpty(this.email))
                    throw new Exception("Please sign up firstly");

                if (string.IsNullOrEmpty(richTextBox1.Text.Trim()))
                    throw new Exception("Please enter a message to send");

                this.message = richTextBox1.Text.Trim();

                MessageBox.Show("Your Message is sent");

                timer2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                    throw new Exception("Please enter your full name");
                if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                    throw new Exception("Please enter your email");

                this.fullName = textBox1.Text.Trim();
                this.email = textBox2.Text.Trim();

                MessageBox.Show("Sign up successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelLastMessage.Text = $"Your name: { this.fullName}\n" +
                $"Email: {this.email}\n" +
                $"Message: \n{this.message}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            /*labelLastMessage.Text = $"Your name: { this.fullName}\n" +
                $"Email: {this.email}\n" +
                $"Message: \n{this.message}";*/
            timer2.Stop();
        }
    }
}
