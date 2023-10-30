using Builder.Studios;

namespace Builder.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio Studio { get; set; }

        public Studio GetStudio => Studio;

        public abstract void SetFlooringType();

        public abstract void SetFinancingType();

        public abstract void SetStudioValue();
    }
}
