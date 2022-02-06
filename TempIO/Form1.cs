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
        Logika.FileReader fileReader;


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
                temp3 = textBox4.Text.ToString();
                Temp3 = Convert.ToDouble(temp3);
                material = comboBox1.SelectedItem?.ToString();
                if (material is null) throw new Exception("Materia³ nie wybrany");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Pole puste!\n{ex.Message}", "ERROR", MessageBoxButtons.OK);
                return;
            }


            temp2 = TextBox2.Text.ToString();
            if (!string.IsNullOrEmpty(temp2))
                Temp2 = Convert.ToDouble(temp2);
            else
                fileReader = new FileReader();
           
            

            if (material == "Beton") lambda = 2.86;
            else if (material == "Cegła") lambda = 1.3;
            else if (material == "Cement") lambda = 3.45;
            else if (material == "Drewno") lambda = 3.33;
            else if (material == "Pustak") lambda = 1.25;
            else if (material == "Styropian + Beton") lambda = 5.36;
            else if (material == "Styropian + Ceg³a") lambda = 3.8;
            else if (material == "Styropian + Cement") lambda = 5.95;
            else if (material == "Styropian + Drewno") lambda = 5.83;
            else if (material == "Styropian + Pustak") lambda = 3.55;

            var logikaRozmytaHandler = new Logika.LogikaRozmyta();

            label6.Text = "Pocz¹tkowa ró¿nica temperatury pomiêdzy t¹ w pomieszczeniu a chcian¹ to: " + (Temp3 - Temp1).ToString("F2") + " stopni C.";


            string zmiany;
            var coutner = fileReader.TempList != null ? fileReader.TempList.Count : 50;
            
            for (int i = 0; i < coutner; i++)
            {
                Temp2 = fileReader.TempList != null ? fileReader.TempList[i].Item2 : Temp2;
                logikaRozmytaHandler.Work(Temp1, Temp2, Temp3, lambda);
                Temp1 += logikaRozmytaHandler.FinalResult;
                zmiany = $"Różnica temperatury w pomieszczeniu to: {logikaRozmytaHandler.Difference.ToString("F2")} stopni C.  W ciągu godziny zmieniono o: {logikaRozmytaHandler.FinalResult.ToString("F2")} stopni C. Obecna temperatura to: {logikaRozmytaHandler.TempIn.ToString("F2")} ";

                listView1.Items.Add(zmiany);
                zmianyList.Add(zmiany);
                if (Math.Abs(Temp1 - Temp3) < 0.01)
                {
                    break;
                }
            }
            zmiany = $"Osiągnięto temperaturę {temp3} stopni C";
            listView1.Items.Add(zmiany);
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