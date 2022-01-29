namespace Logika
{
    public class LogikaRozmyta : ILogikaRozmyta
    {
        #region params
        // Różnica temperatur
        private double uNiska { set; get; }  
        private double uSredna { set; get; }  
        private double uDuza { set; get; }  

        private List<double> zbiorRozmyty = new List<double>();
        #endregion
        
        public LogikaRozmyta() 
        {

        }

        #region private
        private void Rozmyj(double input)
        {
            if (input < 0) throw new Exception("input cant be below 0");
            if(input >= 0 && input <= 5)
            {
                uNiska = 1;
                uSredna = 0;
                uDuza = 0;
            }
            else if(input > 5 && input <= 10)
            {
                uNiska = 1-(input-5)/5;
                uSredna = (input-5)/10;
                uDuza = 0;
            }
            else if(input > 10 && input <= 15)
            {
                uNiska = 0;
                uSredna = 1;
                uDuza = 0;
            }
            else if (input > 15 && input <= 30)
            {
                uNiska = 0;
                if(input < 20)
                    uSredna = 1-(input - 15)/5;
                else
                    uSredna = 0;
                
                uDuza = (input-15)/15;
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
            for(double x = 0 ; x <= 5; x += 0.5)
            {
                double value;
                var temp = new List<double>();
                temp.Add(Math.Min(1 - x / 2, uNiska));
                temp.Add(Math.Min((x - 1) / 1.5, uSredna));
                temp.Add(Math.Min(1 - (x - 2.5) / 1.5, uSredna));
                temp.Add(Math.Min((x - 3) / 2, uDuza));

                value = temp.Min();
                zbiorRozmyty.Add(value);
            }
        }
        #endregion

        #region public
        public void Work(double roznica)
        {
            try
            {
                Rozmyj(roznica);
                Wnioskuj();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}