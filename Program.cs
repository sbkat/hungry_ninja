using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetTooth MichaelChoi = new SweetTooth("Michael Choi");
            SpiceHound CodingNinja = new SpiceHound("Coding Ninja");
            Buffet Buffet = new Buffet();
            MichaelChoi.Consume(Buffet.Serve());
            MichaelChoi.Consume(Buffet.Serve());
            MichaelChoi.Consume(Buffet.Serve());
            MichaelChoi.Consume(Buffet.Serve());
            MichaelChoi.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            CodingNinja.Consume(Buffet.Serve());
            Console.WriteLine("MihcaelChoi consumed 5 items, CodingNinja consumed 8 items.");
        }
    }
}
