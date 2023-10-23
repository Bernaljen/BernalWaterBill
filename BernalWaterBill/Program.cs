namespace BernalCashier
{
    public class program
    {
        public static void Main(string[] args)
        {
            // Input
            Console.Write("Enter the previous meter reading: ");
            int previousReading = int.Parse(Console.ReadLine());

            Console.Write("Enter the current meter reading: ");
            int currentReading = int.Parse(Console.ReadLine());

            //Processing
            int gallonsUsed = currentReading - previousReading;
            double totalCharge;

            if ((gallonsUsed / 1000.0) * 7 < 16.67)
            {
                totalCharge = 16.67;
            }
            else
            {
                totalCharge = (gallonsUsed / 1000.0) * 7;
            }

            // Output
            Console.WriteLine("Number of gallons used: " + gallonsUsed);
            Console.WriteLine("Total charge for water: " + totalCharge.ToString("F2") + "pesos");
        }
    }
}