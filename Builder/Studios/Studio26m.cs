using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Studios
{
    public class Studio26m : Studio
    {
        public override void SetFinancingType(string financing)
           => FinancingType = financing;

        public override void SetFlooringType(string floor)
            => FlooringType = floor;

        public override void SetStudioValue(decimal value)
            => Value = value;
    }
}
