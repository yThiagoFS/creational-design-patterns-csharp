using Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder() => Studio = new Studio28m();

        public override void SetFlooringType()
            => Studio.SetFlooringType("Ice");

        public override void SetFinancingType()
            => Studio.SetFinancingType("AnotherRandomFinancing...");

        public override void SetStudioValue()
            => Studio.SetStudioValue(300000M);
    }
}
