using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public interface ICharCounter
    {
        int GivenCharacterCounter(char c, string str);
        string CharacterCounter(string str);
    }
}
