namespace CW_Forms_GDI
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
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            labelCurrentPenWidth = new Label();
            label2 = new Label();
            label3 = new Label();
            X_1 = new Label();
            X_2 = new Label();
            textBoxX1 = new TextBox();
            textBoxX2 = new TextBox();
            Y_1 = new Label();
            Y_2 = new Label();
            textBoxY1 = new TextBox();
            textBoxY2 = new TextBox();
            buttonOK = new Button();
            panel1 = new Panel();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.FullOpen = true;
            // 
            // button1
            // 
            button1.Location = new Point(690, 116);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(588, 35);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(200, 56);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(588, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Pen width:";
            // 
            // labelCurrentPenWidth
            // 
            labelCurrentPenWidth.AutoSize = true;
            labelCurrentPenWidth.Location = new Point(670, 12);
            labelCurrentPenWidth.Name = "labelCurrentPenWidth";
            labelCurrentPenWidth.Size = new Size(17, 20);
            labelCurrentPenWidth.TabIndex = 4;
            labelCurrentPenWidth.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(588, 120);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Choose color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 170);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Coordinates";
            // 
            // X_1
            // 
            X_1.AutoSize = true;
            X_1.Location = new Point(588, 219);
            X_1.Name = "X_1";
            X_1.Size = new Size(32, 20);
            X_1.TabIndex = 7;
            X_1.Text = "X-1";
            // 
            // X_2
            // 
            X_2.AutoSize = true;
            X_2.Location = new Point(588, 266);
            X_2.Name = "X_2";
            X_2.Size = new Size(32, 20);
            X_2.TabIndex = 8;
            X_2.Text = "X-2";
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(626, 219);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(51, 27);
            textBoxX1.TabIndex = 9;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(626, 263);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(51, 27);
            textBoxX2.TabIndex = 10;
            // 
            // Y_1
            // 
            Y_1.AutoSize = true;
            Y_1.Location = new Point(690, 219);
            Y_1.Name = "Y_1";
            Y_1.Size = new Size(31, 20);
            Y_1.TabIndex = 11;
            Y_1.Text = "Y-1";
            // 
            // Y_2
            // 
            Y_2.AutoSize = true;
            Y_2.Location = new Point(690, 266);
            Y_2.Name = "Y_2";
            Y_2.Size = new Size(31, 20);
            Y_2.TabIndex = 12;
            Y_2.Text = "Y-2";
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(727, 219);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(51, 27);
            textBoxY1.TabIndex = 13;
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(727, 263);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(51, 27);
            textBoxY2.TabIndex = 14;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(640, 310);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 60);
            buttonOK.TabIndex = 15;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 426);
            panel1.TabIndex = 16;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(640, 378);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 60);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(panel1);
            Controls.Add(buttonOK);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxY1);
            Controls.Add(Y_2);
            Controls.Add(Y_1);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxX1);
            Controls.Add(X_2);
            Controls.Add(X_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelCurrentPenWidth);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
        private Label labelCurrentPenWidth;
        private Label label2;
        private Label label3;
        private Label X_1;
        private Label X_2;
        private TextBox textBoxX1;
        private TextBox textBoxX2;
        private Label Y_1;
        private Label Y_2;
        private TextBox textBoxY1;
        private TextBox textBoxY2;
        private Button buttonOK;
        private Panel panel1;
        private Button buttonClear;
    }
}