namespace Logika
{
    public class LogikaRozmyta : ILogikaRozmyta
    {
        #region params
        // Różnica temperatur
        double uNiska { private set; get; }  
        double uSredna { private set; get; }  
        double uDuza { private set; get; }  
        #endregion
        
        public LogikaRozmyta() 
        {

        }

        #region private
        private void Rozmyj(double input)
        {
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

        }
        #endregion

        #region public
        public void Work(double roznica)
        {
            Rozmyj(roznica);
            Wnioskuj();
        }
        #endregion
    }
}