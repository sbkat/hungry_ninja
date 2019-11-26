using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    public abstract class Ninja
    {
        public string Name = "Ninja";
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
    }
}