using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Практика
{
    public partial class Form1 : Form
    {
        public object ComboBox3 { get; private set; }
        public string ComboBox3_SelectedIndexChanged { get; private set; }
        public string ComboBox4_SelectedIndexChanged { get; private set; }
        private readonly Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        private readonly object comboBox5_SelectedItem;

        public Form1()
        {
            InitializeComponent();
            var txt = File.ReadAllLines("TextFile1.txt");
            foreach (string line in txt)
                comboBox1.Items.Add(line);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged (object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            var a = Convert.ToInt32(comboBox5.SelectedItem.ToString());
            int s = Convert.ToInt32(numericUpDown2.Value);

            listBox1.Items.Add("АЗС: " + comboBox1.SelectedItem.ToString());
            listBox1.Items.Add("ФИО оператора: " + comboBox2.SelectedItem.ToString());
            listBox1.Items.Add("марка топлива: " + comboBox3.SelectedItem.ToString());
            listBox1.Items.Add("вид топлива: " + comboBox4.SelectedItem.ToString());
            listBox1.Items.Add("Обьем заправки: " + numericUpDown2.Value);
            listBox1.Items.Add("цена за 1 л.: " + comboBox5.SelectedItem.ToString());
            listBox1.Items.Add("Номер колонки: " + numericUpDown1.Value);
            listBox1.Items.Add("дата: " + dateTimePicker1.Value);
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("Марка ЕВРО");
            }
            else
                listBox1.Items.Add("Не марка ЕВРО");

            int n = a * s;
            listBox1.Items.Add("Итог: " + n + " руб.");
            listBox1.Items.Add("--------------------------------------------------");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        { 
        
            if (comboBox3.SelectedIndex == 0)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("АИ-98");
                comboBox4.Items.Add("АИ-95");
                comboBox4.Items.Add("АИ-92");
                comboBox4.Items.Add("АИ-80");

            }
            else
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("ДТЛ");
                comboBox4.Items.Add("ДТЗ");
                comboBox4.Items.Add("ДТА");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("58");

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("49");
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("45");
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("24");
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("61");
            }
        }
    }
}
    
