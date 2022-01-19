namespace Logika
{
    public class LogikaRozmyta : ILogikaRozmyta
    {
        private 
        private List<(double, double)> valueCollection;
        
        public LogikaRozmyta() 
        {
            valueCollection = new List<(double, double)>();
            GenerateValueCollection();
        }

        #region private

        private void GenerateValueCollection() 
        {
        
        }

        #endregion
    }
}