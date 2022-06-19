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
        public string name = "";
        public string phone = "-";
        public string birthday = "-.-.-";
        public string personalData = "-";
        public string restdentialAddress = "-";
        public string locale = "-";
        public string familarPeoplePosition = "-";
        public string firstMeeting = "-";
        public string goodSides = "-";
        public string extraInfo = "-";
        public string creatingDate = "ERR";
        public string updatingDate = "ERR";

        public void CopyElement(Element original)
        {
            this.creatingDate = original.creatingDate;
            this.updatingDate = original.updatingDate;
            this.name = original.name;
            this.phone = original.phone;
            this.birthday = original.birthday;
            this.personalData = original.personalData;
            this.restdentialAddress = original.restdentialAddress;
            this.locale = original.locale;
            this.familarPeoplePosition = original.familarPeoplePosition;
            this.firstMeeting = original.firstMeeting;
            this.goodSides = original.goodSides;
            this.extraInfo = original.extraInfo;
        }

        public static bool operator == (Element e1, Element e2)
        {
            return
                (e1.name == e2.name &&
                e1.phone == e2.phone &&
                e1.birthday == e2.birthday &&
                e1.personalData == e2.personalData &&
                e1.restdentialAddress == e2.restdentialAddress &&
                e1.locale == e2.locale &&
                e1.familarPeoplePosition == e2.familarPeoplePosition &&
                e1.firstMeeting == e2.firstMeeting &&
                e1.goodSides == e2.goodSides &&
                e1.extraInfo == e2.extraInfo);
        }

        public static bool operator != (Element e1, Element e2)
        {
            return !(e1 == e2);
        }
    }
}
