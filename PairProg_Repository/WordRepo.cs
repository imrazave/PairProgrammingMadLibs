using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProg_Repository
{
    public class WordRepo
    {
        private List<Word> _listOfWords = new List<Word>();
        // Create
        public void AddWordToList(Word word)
        {
            _listOfWords.Add(word);
        }

        // Read

        public List<Word> GetWordList()
        {
            return _listOfWords;
        }

        //Update
        // Delete

        public void DeleteList()
        {
            _listOfWords.Clear();
        }
    }
}
