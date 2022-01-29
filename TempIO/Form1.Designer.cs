namespace TempIO
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(561, 111);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(82, 22);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "RESET";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(561, 73);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(82, 22);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "START";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(358, 63);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PlaceholderText = "np. 20";
            this.TextBox2.Size = new System.Drawing.Size(158, 23);
            this.TextBox2.TabIndex = 13;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(358, 34);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PlaceholderText = "np. 20";
            this.TextBox1.Size = new System.Drawing.Size(158, 23);
            this.TextBox1.TabIndex = 12;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(96, 126);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(229, 15);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Lista dostępnych materiałów izolacyjnych:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(96, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(209, 15);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Podaj wartość temperatury na dworze:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(96, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(204, 15);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Podaj wartość temperatury w pokoju:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(358, 92);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "np. 20";
            this.textBox4.Size = new System.Drawing.Size(158, 23);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Wartość oczekiwana w pokoju:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(96, 166);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 294);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beton",
            "Cegła",
            "Cement",
            "Drewno",
            "Pustak",
            "Styropian + Beton",
            "Styropian + Cegła",
            "Styropian + Cement",
            "Styropian + Drewno",
            "Styropian + Pustak"});
            this.comboBox1.Location = new System.Drawing.Point(358, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 23);
            this.comboBox1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Chart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 525);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Button Button2;
        internal Button Button1;
        internal TextBox TextBox2;
        internal TextBox TextBox1;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal TextBox textBox4;
        internal Label label5;
        private Label label6;
        private ListView listView1;
        private ComboBox comboBox1;
        private Button button3;
    }
}