using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Notebook
{
    internal class PeopleList
    {
        public List<Element> elements = new List<Element>();
        public string listName = "ERR";
        public string creatingDate = "ERR";
        public string updatingDate = "ERR";

        public PeopleList(string listName = "ERR", string creatingDate = "ERR", string updatingDate = "ERR")
        {
            this.listName = listName;
            this.creatingDate = creatingDate;
            this.updatingDate = updatingDate;
        }
    }
}
