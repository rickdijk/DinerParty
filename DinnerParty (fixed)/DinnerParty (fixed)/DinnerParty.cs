using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty__fixed_
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(bool healthyOption, int numberOfPeople, bool fancyDecorations)
            : base (numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPerson()
                                      + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }
    }
}
