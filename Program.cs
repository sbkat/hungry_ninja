using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja MichaelChoi = new Ninja("Michael Choi");
            Buffet Buffet = new Buffet();
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
            MichaelChoi.Eat(Buffet.Serve());
        }
    }
}
