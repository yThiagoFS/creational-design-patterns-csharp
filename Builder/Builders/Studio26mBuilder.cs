using Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder() => Studio = new Studio26m();

        public override void SetFinancingType()
            => Studio.SetFinancingType("AnotherFinancingType");

        public override void SetFlooringType()
            => Studio.SetFlooringType("Stone");

        public override void SetStudioValue()
            => Studio.SetStudioValue(260000M);
    }
}
