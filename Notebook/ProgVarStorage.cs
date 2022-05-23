using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    enum Language
    {
        Ukranian = 0,
        Russian = 1,
        English = 2
    }
    internal class ProgVarStorage
    {
        public Language language;
        public string listNameFormVariant;
        public int index;
    }
}
