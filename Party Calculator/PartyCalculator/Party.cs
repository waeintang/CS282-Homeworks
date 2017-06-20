﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }

        public virtual decimal Cost
        {
            get
            {
                 return CalculateCostOfDecorations() + CostOfFoodPerPerson * NumberOfPeople;
            }
        }

           public Party(int numberOfPeople,  bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }
    }
}
