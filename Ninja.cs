using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    public class Ninja
    {
        string Name = "Ninja";
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        public Ninja()
        {
            this.calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public Ninja(string name)
        {
            Name = name;
            this.calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        

        public bool IsFull
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