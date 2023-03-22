namespace S2SToken
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
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.clientSecretTextBox = new System.Windows.Forms.TextBox();
            this.resourceIdTextBox = new System.Windows.Forms.TextBox();
            this.authorityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(12, 248);
            this.tokenTextBox.Multiline = true;
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(776, 190);
            this.tokenTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ClientId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ClientSecret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ResourceId";
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(87, 90);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(440, 23);
            this.clientIdTextBox.TabIndex = 4;
            // 
            // clientSecretTextBox
            // 
            this.clientSecretTextBox.Location = new System.Drawing.Point(87, 127);
            this.clientSecretTextBox.Name = "clientSecretTextBox";
            this.clientSecretTextBox.Size = new System.Drawing.Size(440, 23);
            this.clientSecretTextBox.TabIndex = 5;
            // 
            // resourceIdTextBox
            // 
            this.resourceIdTextBox.Location = new System.Drawing.Point(87, 165);
            this.resourceIdTextBox.Name = "resourceIdTextBox";
            this.resourceIdTextBox.Size = new System.Drawing.Size(440, 23);
            this.resourceIdTextBox.TabIndex = 6;
            // 
            // authorityTextBox
            // 
            this.authorityTextBox.Location = new System.Drawing.Point(87, 204);
            this.authorityTextBox.Name = "authorityTextBox";
            this.authorityTextBox.Size = new System.Drawing.Size(440, 23);
            this.authorityTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Authority";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(87, 51);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(440, 23);
            this.aliasTextBox.TabIndex = 11;
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(12, 54);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(32, 15);
            this.aliasLabel.TabIndex = 10;
            this.aliasLabel.Text = "Alias";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(576, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 139);
            this.listBox1.TabIndex = 13;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "History";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authorityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resourceIdTextBox);
            this.Controls.Add(this.clientSecretTextBox);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tokenTextBox);
            this.Name = "Form1";
            this.Text = "S2S Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tokenTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox clientIdTextBox;
        private TextBox clientSecretTextBox;
        private TextBox resourceIdTextBox;
        private TextBox authorityTextBox;
        private Label label4;
        private Button button1;
        private TextBox aliasTextBox;
        private Label aliasLabel;
        private Button button2;
        private ListBox listBox1;
        private Label label5;
        private Button button3;
    }
}