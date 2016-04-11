using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_Code
{
    public partial class Form1 : Form
    {
        string name, surname;

        public Form1()
        {
            InitializeComponent();
            vangaButton.Click += VangaButton_Click;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            Stopwatch watch = new Stopwatch();          

            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //nameTextBox.Enabled = checkBox1.Checked;
            groupBox1.Enabled = checkBox1.Checked;
        }

        private void VangaButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Ванга говорит: чекбокс выбран");
            }
            else
            {
                MessageBox.Show("Ванга говорит: не выбран");
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 10000; i++)
            {
                using (StreamWriter writer = new StreamWriter("NewUser"))
                {
                    writer.WriteLine("{0} {1}", nameTextBox.Text, surnameTextBox.Text);
                }
            }
            watch.Stop();
            MessageBox.Show(String.Format("File written in {0} ms", watch.ElapsedMilliseconds));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
