using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    public class SpiceHound : Ninja
    {
        public SpiceHound(string name)
        {
            Name = name;
            this.calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public override bool IsFull
        {
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            if(!IsFull)
            {
                if(item.IsSpicy == true)
                {
                    calorieIntake -= 5;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
                Console.WriteLine($"Spicehound ate {item.Name} - Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("Warning! The SweetTooth is full and cannot eat anymore.");
            }
        }

    }
}