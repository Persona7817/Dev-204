using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALab1
{
    public class UProgram


    {
        private List<Degree> degreeAvail = new List<Degree>();
        private string uprogName;

        public string UprogName { get => uprogName; set => uprogName = value; }
        internal List<Degree> DegreeAvail { get => degreeAvail; set => degreeAvail = value; }

        public UProgram(string uprogname)
        {
            this.UprogName = uprogname;
        }

        public UProgram(string uprogname, List<Degree> degreeavail)
        {
            this.UprogName = uprogname;
            this.DegreeAvail = degreeavail;
        }

        public void AddDegree(Degree degree)
        {

            DegreeAvail.Add(degree);
        }
    }
}
