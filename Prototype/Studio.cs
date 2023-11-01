namespace Prototype 
{
    public class Studio : StudioModel 
    {
        private string _studioType;

        private string _financingType;

        private decimal _value;

        public Studio(string studioType, string financingType, decimal value)
        {
            _studioType = studioType;
            _financingType = financingType;
            _value = value;
        }

        public override StudioModel Clone()
        {
            Console.WriteLine($"{_studioType}, {_financingType}, {_value}");
            
            return this.MemberwiseClone() as StudioModel;
        }
    }
}