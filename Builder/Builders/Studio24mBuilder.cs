using Builder.Studios;

namespace Builder.Builders
{
    public class Studio24mBuilder : StudioBuilder
    {
        public Studio24mBuilder()
            => Studio = new Studio24m();    

        public override void SetFinancingType()
            => Studio.SetFinancingType("SomeRandomInvestingCompany");

        public override void SetFlooringType()
            => Studio.SetFlooringType("Wood");

        public override void SetStudioValue()
            => Studio.SetStudioValue(180000M);
    }
}
