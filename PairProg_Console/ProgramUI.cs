using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PairProg_Repository;

namespace PairProg_Console
{
    class ProgramUI
    {
        private WordRepo _wordRepo = new WordRepo();

        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool keepRunning = true;
           // while (keepRunning)
            {

                Console.WriteLine("Welcome to Mad Libs.  Please enter a noun...");
                var inputNoun = Console.ReadLine();
                Console.WriteLine("Please enter a noun...");
                var inputNoun2 = Console.ReadLine();
                Console.WriteLine("Please enter a verb...");
                var inputVerb = Console.ReadLine();
                Console.WriteLine("Please enter a verb...");
                var inputVerb2 = Console.ReadLine();
                Console.WriteLine("Please enter an adjective...");
                var inputAdjective = Console.ReadLine();
                Console.WriteLine("Please enter an adjective...");
                var inputAdjective2 = Console.ReadLine();
                Console.WriteLine("Please enter an adjective...");
                var inputAdjective3 = Console.ReadLine();

                var noun = new Word(inputNoun, WordType.Noun);
                var noun2 = new Word(inputNoun2, WordType.Noun);
                var verb = new Word(inputVerb, WordType.Verb);
                var verb2 = new Word(inputVerb2, WordType.Verb);
                var adjective = new Word(inputAdjective, WordType.Adjective);
                var adjective2 = new Word(inputAdjective2, WordType.Adjective);
                var adjective3 = new Word(inputAdjective3, WordType.Adjective);

                _wordRepo.AddWordToList(noun);
                _wordRepo.AddWordToList(verb);
                _wordRepo.AddWordToList(adjective);
                _wordRepo.AddWordToList(noun2);
                _wordRepo.AddWordToList(verb2);
                _wordRepo.AddWordToList(adjective2);
                _wordRepo.AddWordToList(adjective3);

                var unorderedList = _wordRepo.GetWordList();

                var orderedList = unorderedList.OrderBy(item => item.WordTypes == WordType.Adjective ? 1 : 2)
                  .ThenBy(item => item.WordTypes == WordType.Noun ? 1 : 2)
                  .ThenBy(item => item.WordTypes == WordType.Verb ? 1 : 2);

                foreach (Word item in orderedList)
                {
                    Console.WriteLine(item.WordContent);
                }

                foreach (Word item in orderedList)
                {
                    switch (item.WordTypes)
                    {
                        case WordType.Noun:
                            
                            // Noun
                            break;
                        case WordType.Adjective:
                            // Verb
                            break;
                        case WordType.Verb:
                            // Adjective
                            break;
                    }
                }
                

                orderedList.IndexOf
                orderedList.WordTypes.noun.[index position1] = noun1;

                "Example text string " + noun1 
                ". Example text string " + adjective1.


                // Display Options To The User
                // Get the user's input
                // 




            }
        }
    }
}
