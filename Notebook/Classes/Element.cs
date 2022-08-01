using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Notebook
{
    internal class Element
    {
        public string Name = "";
        public string Phone = "-";
        public string Birthday = "-.-.-";
        public string PersonalData = "-";
        public string ResidentialAddress = "-";
        public string Locale = "-";
        public string FamilarPeoplePosition = "-";
        public string FirstMeeting = "-";
        public string Skills = "-";
        public string ExtraInfo = "-";
        public string CreatingDate = "ERR";
        public string UpdatingDate = "ERR";

        public void CopyElement(Element original)
        {
            this.CreatingDate = original.CreatingDate;
            this.UpdatingDate = original.UpdatingDate;
            this.Name = original.Name;
            this.Phone = original.Phone;
            this.Birthday = original.Birthday;
            this.PersonalData = original.PersonalData;
            this.ResidentialAddress = original.ResidentialAddress;
            this.Locale = original.Locale;
            this.FamilarPeoplePosition = original.FamilarPeoplePosition;
            this.FirstMeeting = original.FirstMeeting;
            this.Skills = original.Skills;
            this.ExtraInfo = original.ExtraInfo;
        }

        public static bool operator == (Element e1, Element e2)
        {
            return
                (e1.Name == e2.Name &&
                e1.Phone == e2.Phone &&
                e1.Birthday == e2.Birthday &&
                e1.PersonalData == e2.PersonalData &&
                e1.ResidentialAddress == e2.ResidentialAddress &&
                e1.Locale == e2.Locale &&
                e1.FamilarPeoplePosition == e2.FamilarPeoplePosition &&
                e1.FirstMeeting == e2.FirstMeeting &&
                e1.Skills == e2.Skills &&
                e1.ExtraInfo == e2.ExtraInfo);
        }

        public static bool operator != (Element e1, Element e2)
        {
            return !(e1 == e2);
        }
    }
}
