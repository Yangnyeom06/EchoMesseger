using System;

namespace EchoMesseger
{
    public partial class Form1 : Form
    {
        int selectedListIndex = -1;
        bool sendAble = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && sendAble)
            {
                listBox1.Items.Add($"[{DateTime.Now.ToString("HH : mm : ss")}] {textBox1.Text.Trim()}");
                label2.Text = $"현재 대화: {listBox1.Items.Count}개";
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text) && sendAble)
            {
                listBox1.Items.Add($"[{DateTime.Now.ToString("HH : mm : ss")}] {textBox1.Text.Trim()}");
                label2.Text = $"현재 대화: {listBox1.Items.Count}개";
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedListIndex = listBox1.SelectedIndex;
            Console.WriteLine($"Selected Index: {selectedListIndex}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedListIndex != -1)
            {
                listBox1.Items.RemoveAt(selectedListIndex);
                label2.Text = $"현재 대화: {listBox1.Items.Count}개";
                selectedListIndex = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() > 50)
            {
                label3.Text = "메시지는 50자까지만 입력 가능합니다.";
                sendAble = false;
            }
            else
            {
                label3.Text = "";
                sendAble = true;
            }
        }
    }
}