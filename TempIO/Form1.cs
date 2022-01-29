using Logika;
using System;
using System.Collections.Generic;

namespace TempIO
{
    public partial class Form1 : Form
    {

        private String temp1;
        private double Temp1;
        private String temp2;
        private double Temp2;
        private String temp3;
        private double Temp3;
        private String material;
        private double lambda;
        private String wynik;
        private List<string> zmianyList = new List<String>();


        private LogikaRozmyta class1;


        public Form1()
        {
            InitializeComponent();
        }



        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                temp1 = TextBox1.Text.ToString();
                Temp1 = Convert.ToDouble(temp1);
                temp2 = TextBox2.Text.ToString();
                Temp2 = Convert.ToDouble(temp2);
                temp3 = textBox4.Text.ToString();
                Temp3 = Convert.ToDouble(temp3);
                material = comboBox1.SelectedItem?.ToString();
                if (material is null) throw new Exception("Materia³ nie wybrany");
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: Pole puste!\n{ex.Message}", "ERROR", MessageBoxButtons.OK);
                return;
            }

            if (material == "Beton") lambda = 2.86;
            else if (material == "Ceg³a") lambda = 1.3;
            else if (material == "Cement") lambda = 3.45;
            else if (material == "Drewno") lambda = 3.33;
            else if (material == "Pustak") lambda = 1.25;
            else if (material == "Styropian + Beton") lambda = 5.36;
            else if (material == "Styropian + Ceg³a") lambda = 3.8;
            else if (material == "Styropian + Cement") lambda = 5.95;
            else if (material == "Styropian + Drewno") lambda = 5.83;
            else if (material == "Styropian + Pustak") lambda = 3.55;
 
            label6.Text = "Pocz¹tkowa ró¿nica temperatury pomiêdzy t¹ w pomieszczeniu a chcian¹ to: " + (Temp3 - Temp1).ToString("F2") + " stopni C.";
            obliczenia(Temp1, Temp2, Temp3, lambda);
            //foreach (string z in zmianyList)
            //{
            //     listView1.Items.Add(z);
            //}
        }


        public void obliczenia(double t1, double t2, double t3, double l)
        {

            double dtz;
            double dtw;
            double dtroz;
            double dtn = 0;
            double nowa;
            String zmiany;
            bool a = false;
            int p = 0;

            do
            {

                dtz = (t1 - t2);
                dtw = (t3 - t1);
                dtroz = dtz / (l * 24);

                if (dtw < -10.0) dtn = -5 - dtroz;
                else if (dtw < -9.0) dtn = -4.5 - dtroz;
                else if (dtw < -8) dtn = -4.0 - dtroz;
                else if (dtw < -7) dtn = -3.5 - dtroz;
                else if (dtw < -6) dtn = -3.0 - dtroz;
                else if (dtw < -5) dtn = -2.5 - dtroz;
                else if (dtw < -4) dtn = -2.0 - dtroz;
                else if (dtw < -3) dtn = -1.5 - dtroz;
                else if (dtw < -2) dtn = -1.0 - dtroz;
                else if (dtw < -1) dtn = -0.75 - dtroz;
                else if (dtw < 0) dtn = 0 - dtroz;
                //else if (dtw < 0.5) dtn = 0.5 - dtroz;
                else if (dtw < 1) dtn = 0.75 - dtroz;
                else if (dtw < 2) dtn = 1.0 - dtroz;
                else if (dtw < 3) dtn = 1.5 - dtroz;
                else if (dtw < 4) dtn = 2.0 - dtroz;
                else if (dtw < 5) dtn = 2.5 - dtroz;
                else if (dtw < 6) dtn = 3.0 - dtroz;
                else if (dtw < 7) dtn = 3.5 - dtroz;
                else if (dtw < 8) dtn = 4.0 - dtroz;
                else if (dtw < 9) dtn = 4.5 - dtroz;
                else if (dtw < 10.0) dtn = 4.75 - dtroz;
                else if (dtw >= 10.0) dtn = 5.0 - dtroz;
                zmiany = $"Ró¿nica temperatury w pomieszczeniu to: {dtw.ToString("F2")} stopni C.  W ci¹gu godziny zmieniono o: {dtn.ToString("F2")} stopni C";
                t1 = t1 + dtn;
                p++;
                listView1.Items.Add(zmiany);
                // zmianyList.Add(zmiany);
                if (Math.Abs(Temp1 - Temp3) < 0.01) { a = true; zmiany = $"Osi¹gniêto temperaturê {Temp3} stopni C"; }
                if (p > 50) a = true;
            } while (a == false);
            zmiany = $"Osi¹gniêto temperaturê {temp3} stopni C";
            listView1.Items.Add(zmiany);
            //zmianyList.Add(zmiany);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            textBox4.Text = "";
            listView1.Items.Clear();

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

 

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var chart = new Chart();
            chart.Show();
        }
    }
}