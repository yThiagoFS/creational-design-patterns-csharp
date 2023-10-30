namespace Builder.Studios
{
    public abstract class Studio
    {
        public string FlooringType { get; protected set; } = string.Empty;

        public string FinancingType { get; protected set; } = string.Empty;

        public decimal Value { get; protected set; }

        public abstract void SetFlooringType(string floor);

        public abstract void SetFinancingType(string financing);

        public abstract void SetStudioValue(decimal value);
    }
}
