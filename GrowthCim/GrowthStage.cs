using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthCim
{
    abstract class GrowthStage
    {
        public abstract void Grow(SunCondition sun, WindCondition wind, SoilCondition soil, Plant plant);
    }
}
