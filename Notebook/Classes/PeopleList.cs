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
        public List<Element> Elements = new List<Element>();
        public string ListName = "ERR";
        public string CreatingDate = "ERR";
        public string UpdatingDate = "ERR";

        public PeopleList(
            string listName = "ERR",
            string creatingDate = "ERR",
            string updatingDate = "ERR")
        {
            this.ListName = listName;
            this.CreatingDate = creatingDate;
            this.UpdatingDate = updatingDate;
        }
    }
}
