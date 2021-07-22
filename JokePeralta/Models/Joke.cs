using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokePeralta.Models
{
    public class Joke
    {
        public int JokeID { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        //public string JokeAuthor { get; set; }
        public Joke()
        {

        }
    }
}
