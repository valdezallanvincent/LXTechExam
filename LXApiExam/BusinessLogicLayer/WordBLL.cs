using BusinessLogicLayer.Interface;
using System;
using System.Linq;

namespace BusinessLogicLayer
{
    public class WordBLL: IWordBLL
    {
        public string GetReversedWord(string words)
        {
            string resultMsg = "";
            for (int x = words.Length - 1; x >= 0; x--)
            {
                resultMsg += words[x].ToString();
            }
            return resultMsg;
        }

        public string GetSortedWord(string words)
        {
            var wordList = words.Split(' ').ToList();
            wordList = wordList.OrderBy(str => str).ToList(); ;
            string resultMsg = string.Join(" ", wordList).Trim(' ');
            return resultMsg;
        }
    }
}
