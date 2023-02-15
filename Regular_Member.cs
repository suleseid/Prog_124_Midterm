using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    abstract internal class Regular_Member : Member
    {
        protected Regular_Member(string firstName, string lastName, int pointAmount, string memberNumber, string memberSince) : base(firstName, lastName, pointAmount, memberNumber, memberSince)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
