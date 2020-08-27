using System.Collections.Generic;
using catsAPI.Models;

namespace catsAPI.DB
{
    public static class FakeDB
    {
        public static List<Cat> Cats { get; set; } = new List<Cat>(){
            new Cat("Mr. Snibbley", "Grey and stuff"),
            new Cat("Whiskers", "Mostly white with some brown spots"),
            new Cat("Felix", "Black with some white on his chest")
        };
    }
}