namespace WinFormsApp1
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SizeComboBox = new ComboBox();
            FontComboBox = new ComboBox();
            buttonUnderline = new Button();
            buttonItalic = new Button();
            buttonCentre = new Button();
            buttonRight = new Button();
            buttonBold = new Button();
            buttonLeft = new Button();
            ColorComboBox = new ComboBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            LoadBox = new TextBox();
            SaveBox = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(787, 398);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 16);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 15);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "FontStyle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 15);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 15);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "Alighment";
            // 
            // SizeComboBox
            // 
            SizeComboBox.FormattingEnabled = true;
            SizeComboBox.Location = new Point(118, 34);
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(52, 23);
            SizeComboBox.TabIndex = 6;
            SizeComboBox.SelectedIndexChanged += SizeComboBox_SelectedIndexChanged;
            // 
            // FontComboBox
            // 
            FontComboBox.FormattingEnabled = true;
            FontComboBox.Location = new Point(12, 34);
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(100, 23);
            FontComboBox.TabIndex = 7;
            FontComboBox.SelectedIndexChanged += FontComboBox_SelectedIndexChanged;
            // 
            // buttonUnderline
            // 
            buttonUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            buttonUnderline.Location = new Point(232, 33);
            buttonUnderline.Name = "buttonUnderline";
            buttonUnderline.Size = new Size(25, 23);
            buttonUnderline.TabIndex = 8;
            buttonUnderline.Text = "U";
            buttonUnderline.UseVisualStyleBackColor = true;
            buttonUnderline.UseWaitCursor = true;
            buttonUnderline.Click += buttonUnderline_Click_1;
            // 
            // buttonItalic
            // 
            buttonItalic.Location = new Point(263, 33);
            buttonItalic.Name = "buttonItalic";
            buttonItalic.Size = new Size(25, 23);
            buttonItalic.TabIndex = 9;
            buttonItalic.Text = "/";
            buttonItalic.UseVisualStyleBackColor = true;
            buttonItalic.Click += buttonItalic_Click;
            // 
            // buttonCentre
            // 
            buttonCentre.Location = new Point(341, 33);
            buttonCentre.Name = "buttonCentre";
            buttonCentre.Size = new Size(25, 23);
            buttonCentre.TabIndex = 10;
            buttonCentre.Text = "C";
            buttonCentre.UseVisualStyleBackColor = true;
            buttonCentre.Click += buttonCentre_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(372, 33);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(25, 23);
            buttonRight.TabIndex = 11;
            buttonRight.Text = "R";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonBold
            // 
            buttonBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBold.Location = new Point(201, 33);
            buttonBold.Name = "buttonBold";
            buttonBold.Size = new Size(25, 23);
            buttonBold.TabIndex = 12;
            buttonBold.Text = "B";
            buttonBold.UseVisualStyleBackColor = true;
            buttonBold.Click += buttonBold_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(310, 33);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(25, 23);
            buttonLeft.TabIndex = 13;
            buttonLeft.Text = "L";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // ColorComboBox
            // 
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(419, 33);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(121, 23);
            ColorComboBox.TabIndex = 14;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(713, 33);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 26);
            buttonSave.TabIndex = 15;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(713, 4);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 16;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // LoadBox
            // 
            LoadBox.Location = new Point(565, 4);
            LoadBox.Name = "LoadBox";
            LoadBox.Size = new Size(142, 23);
            LoadBox.TabIndex = 17;
            // 
            // SaveBox
            // 
            SaveBox.Location = new Point(565, 34);
            SaveBox.Name = "SaveBox";
            SaveBox.Size = new Size(142, 23);
            SaveBox.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(SaveBox);
            Controls.Add(LoadBox);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(ColorComboBox);
            Controls.Add(buttonLeft);
            Controls.Add(buttonBold);
            Controls.Add(buttonRight);
            Controls.Add(buttonCentre);
            Controls.Add(buttonItalic);
            Controls.Add(buttonUnderline);
            Controls.Add(FontComboBox);
            Controls.Add(SizeComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "NotePad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox SizeComboBox;
        private ComboBox FontComboBox;
        private Button buttonUnderline;
        private Button buttonItalic;
        private Button buttonCentre;
        private Button buttonRight;
        private Button buttonBold;
        private Button buttonLeft;
        private ComboBox ColorComboBox;
        private Button buttonSave;
        private Button buttonLoad;
        private TextBox LoadBox;
        private TextBox SaveBox;
    }
}