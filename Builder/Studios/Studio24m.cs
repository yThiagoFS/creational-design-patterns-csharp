namespace Builder.Studios
{
    public class Studio24m : Studio
    {
        public override void SetFinancingType(string financing)
            => FinancingType = financing;

        public override void SetFlooringType(string floor)
            => FlooringType = floor;

        public override void SetStudioValue(decimal value)
            => Value = value;
    }
}
