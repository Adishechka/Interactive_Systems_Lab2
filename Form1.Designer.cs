namespace Lab2
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
            components = new System.ComponentModel.Container();
            comboBoxMode = new ComboBox();
            buttonClick = new Button();
            buttonStart = new Button();
            buttonStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            buttonClearTextBox = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxMode
            // 
            comboBoxMode.Font = new Font("Cascadia Mono", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Items.AddRange(new object[] { "Режим 1", "Режим 2", "Режим 3" });
            comboBoxMode.Location = new Point(933, 12);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(121, 28);
            comboBoxMode.TabIndex = 0;
            // 
            // buttonClick
            // 
            buttonClick.BackColor = Color.White;
            buttonClick.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClick.Location = new Point(40, 180);
            buttonClick.Margin = new Padding(5);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(80, 80);
            buttonClick.TabIndex = 1;
            buttonClick.Text = "Кликни меня :3";
            buttonClick.UseVisualStyleBackColor = false;
            buttonClick.Click += buttonClick_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.MediumSeaGreen;
            buttonStart.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(1060, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(101, 28);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Orange;
            buttonStop.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStop.Location = new Point(1167, 12);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(101, 28);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.CausesValidation = false;
            textBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(933, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(440, 560);
            textBox1.TabIndex = 5;
            // 
            // buttonClearTextBox
            // 
            buttonClearTextBox.BackColor = Color.LightSteelBlue;
            buttonClearTextBox.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearTextBox.Location = new Point(1242, 46);
            buttonClearTextBox.Name = "buttonClearTextBox";
            buttonClearTextBox.Size = new Size(130, 28);
            buttonClearTextBox.TabIndex = 6;
            buttonClearTextBox.Text = "Clear TextBox";
            buttonClearTextBox.UseVisualStyleBackColor = false;
            buttonClearTextBox.Click += buttonClearTextBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 7;
            label1.Text = "Тестовая область:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(933, 58);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 8;
            label2.Text = "Текстовая область (для чтения):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1384, 661);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClearTextBox);
            Controls.Add(textBox1);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(buttonClick);
            Controls.Add(comboBoxMode);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(100, 100);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Lab2 - AdievKR";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMode;
        private Button buttonClick;
        private Button buttonStart;
        private Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button buttonClearTextBox;
        private Label label1;
        private Label label2;
    }
}
