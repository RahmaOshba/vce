using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vigenerecipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // creat encryption function
        public void VigenerEncrypt (ref StringBuilder s, string key)
        {
            for ( int i=0; i<s.Length; i++) s[i]=char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    s[i] = (char) ((s[i])+key[i]-'A');
                    if (s[i] < 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + i == key.Length ? 0 : j + 1;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(textBox1.Text);
            string key = textBox2.Text;
            VigenerEncrypt(ref s, key);
            textBox3.Text = Convert.ToString(s);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
