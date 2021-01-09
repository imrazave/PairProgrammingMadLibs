using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProg_Repository
{
    public enum WordType
    {
        Adjective = 1,
        Noun,
        Verb
    }

    // Plain Old C# Object
    public class Word
    {
        public string WordContent { get; set; }
        public WordType WordTypes { get; set; }

        public Word() { }
        public Word(string wordContent, WordType wordTypes) 
        {
            WordTypes = wordTypes;
            WordContent = wordContent;
        }
    }
}
