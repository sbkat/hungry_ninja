using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    public class SweetTooth : Ninja
    {
        public SweetTooth(string name)
        {
            Name = name;
            this.calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public override bool IsFull
        {
            get
            {
                if(calorieIntake > 1500)
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
                if(item.IsSweet == true)
                {
                    calorieIntake += 10;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
                Console.WriteLine($"SweetTooth ate {item.Name} - Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("Warning! The SweetTooth is full and cannot eat anymore.");
            }
        }

    }
}