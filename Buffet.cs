using System;
using System.Collections.Generic;


namespace hungry_ninja
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Pizza", 150, false, false),
                new Food("Cajun fried chicken", 20, true, false),
                new Food("Crawfish", 300, true, false),
                new Food("Sour patch kids", 250, false, true),
                new Food("Mashed potatoes", 400, false, false),
                new Food("Pad thai", 450, true, false),
                new Food("Sweet and sour chicken", 150, false, true),
                new Drink("Coke", 150, false, true),
                new Drink("Beer", 250, false, false),
                new Drink("Orange Juice", 150, false, false),
            }; 
        }
        
        public IConsumable Serve()
        {
            Random rand = new Random();
            int randIdx = rand.Next(Menu.Count);
            return Menu[randIdx];
        }
    }
}