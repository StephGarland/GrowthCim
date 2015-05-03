using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthCim
{
    class Plant
    {

        private int nFlowers;
        private int height;
        private int nLeaves;
        private GrowthStage currentStage;

        
        public Plant()
        {

        }

        public void Grow(SunCondition sun, WindCondition wind, SoilCondition soil)
        {
            currentStage.Grow(sun, wind, soil, this);
            //int waterContent = 20, nutrientValue = 20, growthRate = 100, tempe
            ature = 20, wind = 20, sunlight = 20;
            //currentStage.Grow(waterContent, nutrientValue, growthRate, temperature, wind, sunlight);
        }

    }
}
