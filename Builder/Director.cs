using Builder.Builders;

namespace Builder
{
    public class Director
    {
        public void BuildStudio(StudioBuilder builder)
        {
            builder.SetFlooringType();
            builder.SetFinancingType();
            builder.SetStudioValue();
        }
    }
}
