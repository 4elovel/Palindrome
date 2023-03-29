using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            int var = System.Convert.ToInt32(textBox1.Text);
                        var = var * 3;
                        label1.Text = System.Convert.ToString(var);*/

            /*            string str1 = "Radok";
                        char[] chars = { 'A', 'B', 'C' };
                        string str2 = new string(chars);
                        string str3 = new string(chars, 0, 2);
                        string str4 = new string('@', 8);
                        string str6 = @"C:\abf\fafaf\af";
                        string str7 = "C:\\abf\\fafaf\\af";
                        label1.Text = "str1: " + str1;
                        label2.Text = "str2: " + str2;
                        label3.Text = "str3: " + str3;
                        label4.Text = "str4: " + str4;
                        label5.Text = "HIIIII";
                        label6.Text = "str6: " + str6;
                        label7.Text = "str7: " + str7;*/
            char[] charArray = textBox1.Text.ToCharArray();
            Array.Reverse(charArray);
            string buf = new string(charArray);
            if (textBox1.Text == buf)
            {
                label1.Text = "Palindrome";
            }
            else
            {
                label1.Text = "Not Palindrome";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}