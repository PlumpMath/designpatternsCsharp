namespace Decorator_Pattern
{
    public class HondeCity : IVehicle
    {
        public string Make
        {
            get
            {
                return "HondaCity";
            }
        }

        public string Model
        {
            get
            {
                return "CNG";
            }
        }

        public double Price
        {
            get
            {
                return 100000;
            }
        }
    }
}
