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
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(641, 148);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(94, 29);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "RESET";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(641, 97);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 29);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "START";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(409, 84);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PlaceholderText = "np. 20";
            this.TextBox2.Size = new System.Drawing.Size(180, 27);
            this.TextBox2.TabIndex = 13;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(409, 45);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PlaceholderText = "np. 20";
            this.TextBox1.Size = new System.Drawing.Size(180, 27);
            this.TextBox1.TabIndex = 12;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(110, 168);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(285, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Lista dostępnych materiałów izolacyjnych:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(110, 83);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(262, 20);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Podaj wartość temperatury na dworze:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(110, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(254, 20);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Podaj wartość temperatury w pokoju:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(409, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "np. 20";
            this.textBox4.Size = new System.Drawing.Size(180, 27);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Wartość oczekiwana w pokoju:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(110, 221);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(625, 391);
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
            this.comboBox1.Location = new System.Drawing.Point(409, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
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
    }
}