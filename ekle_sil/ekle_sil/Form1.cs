using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekle_sil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""||comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Girdileri Yapınız","Bilgi");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text+" "+textBox3.Text);
                listBox3.Items.Add(comboBox1.SelectedItem);
                a += 1;
                label5.Text = "Öğrenci Sayısı =" + a;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            listBox2.SelectedIndex = -1;
            listBox3.SelectedIndex = -1;
            listBox1.SelectedIndex = a;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox2.SelectedIndex;
            listBox1.SelectedIndex = -1;
            listBox3.SelectedIndex = -1;
            listBox2.SelectedIndex = a;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox3.SelectedIndex;
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            listBox3.SelectedIndex = a;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text=="")
            {
                MessageBox.Show("Lütfen Bilgi Giriniz");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    int c = listBox1.FindStringExact(textBox4.Text);
                    if (c == -1)
                    {
                        MessageBox.Show("Kişi Listede Yok");
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(c);
                        listBox2.Items.RemoveAt(c);
                        listBox3.Items.RemoveAt(c);
                        a -= 1;
                        label5.Text = "Öğrenci Sayısı =" + a;
                    }
                }
                else if (radioButton2.Checked)
                {
                    int c = listBox2.FindStringExact(textBox4.Text);
                    if (c == -1)
                    {
                        MessageBox.Show("Kişi Listede Yok");
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(c);
                        listBox2.Items.RemoveAt(c);
                        listBox3.Items.RemoveAt(c);
                        a -= 1;
                        label5.Text = "Öğrenci Sayısı =" + a;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Bilgi Giriniz");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    int c = listBox1.FindStringExact(textBox4.Text);
                    if (c == -1)
                    {
                        MessageBox.Show("Kişi Listede Yok");
                    }
                    else
                    {
                        c += 1;
                        MessageBox.Show("Kişi Listede " + c + ". Sırada");
                    }
                }
                else if (radioButton2.Checked)
                {
                    int c = listBox2.FindStringExact(textBox4.Text);
                    if (c == -1)
                    {
                        MessageBox.Show("Kişi Listede Yok");
                    }
                    else
                    {
                        c += 1;
                        MessageBox.Show("Kişi Listede " + c + ". Sırada");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Bilgi Giriniz");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    int c = listBox1.FindStringExact(textBox4.Text);
                    if (c == -1)
                    {
                        MessageBox.Show("Kişi Listede Yok");
                    }
                    else
                    {
                        listBox1.Items[c] = textBox1.Text;
                        listBox2.Items[c] = textBox2.Text + textBox3.Text;
                        listBox3.Items[c] = comboBox1.SelectedItem;
                    }
                }
                else if (radioButton2.Checked)
                {
                    int c = listBox2.FindStringExact(textBox4.Text);
                    if (c == -1)
                    {
                        MessageBox.Show("Kişi Listede Yok");
                    }
                    else
                    {
                        listBox1.Items[c] = textBox1.Text;
                        listBox2.Items[c] = textBox2.Text + textBox3.Text;
                        listBox3.Items[c] = comboBox1.SelectedItem;
                    }
                }
            }
        }
    }
}
