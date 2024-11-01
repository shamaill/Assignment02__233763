using System;
using System.Windows.Forms;

namespace Assignment02_233763
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Label label = new Label();
            label.Text = "Enter Text:";
            label.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(100, 20);
            this.Controls.Add(textBox);

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Location = new System.Drawing.Point(20, 60);
            richTextBox.Size = new System.Drawing.Size(200, 100);
            this.Controls.Add(richTextBox);

            CheckBox checkBox = new CheckBox();
            checkBox.Text = "Check Me!";
            checkBox.Location = new System.Drawing.Point(20, 180);
            this.Controls.Add(checkBox);

            RadioButton radioButton = new RadioButton();
            radioButton.Text = "Option 1";
            radioButton.Location = new System.Drawing.Point(20, 210);
            this.Controls.Add(radioButton);

            ComboBox comboBox = new ComboBox();
            comboBox.Location = new System.Drawing.Point(20, 240);
            comboBox.Items.AddRange(new
