using System;

namespace EchoMesseger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add($"[{DateTime.Now.ToString("HH : mm : ss")}] {textBox1.Text.Trim()}");
                label2.Text = $"현재 대화: {listBox1.Items.Count}개";
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add($"[{DateTime.Now.ToString("HH : mm : ss")}] {textBox1.Text.Trim()}");
                label2.Text = $"현재 대화: {listBox1.Items.Count}개";
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
