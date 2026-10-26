namespace lab02_24862_24845
{
    public class AlcoholCalculator
    {
        
        public double CalculateTotalVolume(double vesselVolume, int quantity)
        {
            return vesselVolume * quantity;
        }

        
        public double CalculatePureAlcohol(double vesselVolume, double percentage, int quantity)
        {
            double totalVolume = CalculateTotalVolume(vesselVolume, quantity);
            return totalVolume * (percentage / 100.0);
        }
    }
}