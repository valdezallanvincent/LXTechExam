using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Interface
{
    public interface IWordBLL
    {
        string GetReversedWord(string words);
        string GetSortedWord(string words);
    }
}
