namespace EchoMesseger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 58);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(38, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(573, 249);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 15F);
            textBox1.Location = new Point(38, 377);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(573, 41);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F);
            button1.Location = new Point(640, 365);
            button1.Name = "button1";
            button1.Size = new Size(139, 64);
            button1.TabIndex = 3;
            button1.Text = "전송";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
    }
}
