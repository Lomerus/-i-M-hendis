namespace nypodev
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
            adTxt = new TextBox();
            adresTxt = new TextBox();
            yasTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            listboxResults = new ListBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            mesaiTxt = new TextBox();
            SuspendLayout();
            // 
            // adTxt
            // 
            adTxt.Location = new Point(133, 83);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 0;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(133, 151);
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(125, 27);
            adresTxt.TabIndex = 1;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(119, 220);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Name Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 158);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 227);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // button1
            // 
            button1.Location = new Point(336, 337);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listboxResults
            // 
            listboxResults.FormattingEnabled = true;
            listboxResults.ItemHeight = 20;
            listboxResults.Location = new Point(616, 119);
            listboxResults.Name = "listboxResults";
            listboxResults.Size = new Size(150, 104);
            listboxResults.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 311);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Mesai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 271);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "Unvan";
            // 
            // mesaiTxt
            // 
            mesaiTxt.Location = new Point(107, 304);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(125, 27);
            mesaiTxt.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mesaiTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(listboxResults);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yasTxt);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yasTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listboxResults;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox mesaiTxt;
    }
}