namespace Logika
{
    public class LogikaRozmyta : ILogikaRozmyta
    {
        #region params
        // Różnica temperatur

        private double Power { get; set; } = 1.1;
        private double uNiska { set; get; }
        private double uSredna { set; get; }
        private double uDuza { set; get; }

        private List<(double, double)> zbiorRozmyty = new List<(double, double)>();

        public double Lambda { set; get; }
        public double Difference { set; get; }

        public double Difference2 { set; get; }
        public double ExpectedTemp { set; get; }
        public double TempIn { set; get; }
        public double TempOut { set; get; }

        public bool a = false;

        public double FinalResult { set; get; }
        #endregion

        public LogikaRozmyta()
        {

        }

        #region private
        private void Rozmyj(double input)
        {
            if (input < 0) throw new Exception("input cant be below 0");
            if (input >= 0 && input <= 5)
            {
                uNiska = 1;
                uSredna = 0;
                uDuza = 0;
            }
            else if (input > 5 && input <= 10)
            {
                uNiska = 1 - (input - 5) / 5;
                uSredna = (input - 5) / 10;
                uDuza = 0;
            }
            else if (input > 10 && input <= 15)
            {
                uNiska = 0;
                uSredna = 1;
                uDuza = 0;
            }
            else if (input > 15 && input <= 30)
            {
                uNiska = 0;
                if (input < 20)
                    uSredna = 1 - (input - 15) / 5;
                else
                    uSredna = 0;

                uDuza = (input - 15) / 15;
            }
            else if (input > 30)
            {
                uNiska = 0;
                uSredna = 0;
                uDuza = 1;
            }
        }

        private void Wnioskuj()
        {
            for (double x = 0; x <= 5; x += 0.1)
            {
                double value;
                var temp = new List<double>();
                double tempValue;

                tempValue = 1 - x / 2;
                if (tempValue >= 0 && tempValue <= 1)
                    temp.Add(Math.Min(tempValue, uNiska));

                tempValue = (x - 1) / 1.5;
                if (tempValue >= 0 && tempValue <= 1)
                    temp.Add(Math.Min(tempValue >= 0 ? tempValue : 1, uSredna));

                tempValue = 1 - (x - 2.5) / 1.5;
                if (tempValue >= 0 && tempValue <= 1)
                    temp.Add(Math.Min(tempValue >= 0 ? tempValue : 1, uSredna));

                tempValue = (x - 3) / 2;
                if (tempValue >= 0 && tempValue <= 1)
                    temp.Add(Math.Min(tempValue >= 0 ? tempValue : 1, uDuza));

                value = temp.Max();
                zbiorRozmyty.Add((x, value));
            }
        }

        private void Result()
        {
            double suma = 0, waga = 0;
            for (int i = 0; i < zbiorRozmyty.Count; i++)
            {
                if (zbiorRozmyty[i].Item2 > 0)
                {
                    suma += suma + zbiorRozmyty[i].Item1 * zbiorRozmyty[i].Item2;
                    waga += waga + zbiorRozmyty[i].Item2;
                }
            }
            FinalResult = (suma / waga);
            if (a)
                FinalResult = FinalResult - Difference2 / (Lambda * 48);
            else 
                FinalResult = (-1)*(FinalResult) - Difference2 / (Lambda * 48);

            FinalResult *= Power;
        }
        #endregion

        #region public
        public void Work(double tempIn, double tempOut, double expectedTemp, double lambda)
        {

            TempIn = tempIn;
            TempOut = tempOut;
            ExpectedTemp = expectedTemp;
            Difference = (tempIn - ExpectedTemp);
            Difference2 = tempOut - TempIn;
            a = Difference <= 0 ? true : false;
            Difference = Math.Abs(Difference);
            Lambda = lambda;

            try
            {
                Rozmyj(Difference);
                Wnioskuj();
                Result();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}