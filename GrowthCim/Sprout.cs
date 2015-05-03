using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthCim
{
    class Sprout : GrowthStage
    {
        // Ground conditions - roots can penetrate, provides sturctual support, room to lay roots
        // Environment - encapsulates sun and wind - can calculate temperature at a point.

        public override void Grow(SunCondition sun, WindCondition wind, SoilCondition soil, Plant plant)
        {
            // Depends upon: <b>carbon dioxide<b>, sunlight, water, ambient temperature, wind chill, soil nutrients, 
            // room for roots, competition for water-bourne nutrients.

            // Split plant into different components: plant.Grow() -> state.Grow() -> roots.Expand()
            //                                                                     -> roots.Drink()
            //                                                                     -> leaves.Photosynthesize()
            //                                                                     -> genitals.Flower()

            // Plant has a single pool of nutrient points from which it can assign its components nutrients
            // Components will have a priority order in which they receive nutrients
            // Once a component has accrued enough nutrient points it can upgrade / expand with a new additional thing 
            // e.g. a new leaf or flower or root node.

            // PLANT COMPONENTS
            // roots
            // leaves - deciduous?
            // genitals
            // traps

            // roots
            // leaves
            // flowers
            // fruit
            // seeds / pods
            // stalks
            // traps

            // Annual, biennial, perenial: affected by temperature:  plants that are annual in alpine or temperate 
            // regions can be biennial or perennial in warmer climates. 

            // The growth rate of plants is extremely variable. Some mosses grow less than 0.001 millimeters per 
            // hour (mm/h), while most trees grow 0.025-0.250 mm/h. Some climbing species, such as kudzu, which do 
            // not need to produce thick supportive tissue, may grow up to 12.5 mm/h.

            // Etiolation: is a process in flowering plants grown in partial or complete absence of light. It is 
            // characterized by long, weak stems; smaller, sparser leaves due to longer internodes; and a pale yellow 
            // color (chlorosis).

            // Chlorosis: is a condition in which leaves produce insufficient chlorophyll. As chlorophyll is 
            // responsible for the green color of leaves, chlorotic leaves are pale, yellow, or yellow-white. The 
            // affected plant has little or no ability to manufacture carbohydrates through photosynthesis and may 
            // die unless the cause of its chlorophyll insufficiency is treated.

            // ...iron which is a needed component in the production of chlorophyll.

            // NUTRIENT PRIORITIES AND LIFE-CYCLE
            // Nutrient priorities differ between annual, biennial, and perenial species. Temperature can also affect
            // whether a species is annual... etc. State objects will hold priority table and assign nutrients to 
            // different components. States will also allow (and determine) for movement between annual, biennial, 
            // and perenial.

        }
    }
}
