using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    public abstract class Ninja
    {
        string Name = "Ninja";
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        
        public Ninja()
        {
            this.calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public Ninja(string name)
        {
            Name = name;
            this.calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public abstract bool IsFull {get;}

        public abstract void Consume(IConsumable item);
        
        // public bool IsFull
        // {
        //     get
        //     {
        //         if(calorieIntake > 1200) 
        //         {
        //             return true;
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //     }
        // }
        
        public void Eat(Food item)
        {
            if(IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name} - Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("Warning! The ninja is full and cannot eat anymore.");
            }
        }

    }
}