using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    enum Language
    {
        Ukraіnian = 0,
        Russian = 1,
        English = 2
    }

    internal class ProgVarStorage
    {
        public Language AppLanguage = Language.Ukraіnian;
        public string ListNameFormVariant = "ERR";
        public string ElementFormVariant = "ERR";
        public string PrevWindow = "ERR";
        public string Name = "ERR";
        public string ReviewListName = "ERR";
        public string ReviewElementName = "ERR";
    }
}
