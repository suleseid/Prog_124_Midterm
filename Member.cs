using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    public abstract class Member
    {
        string _FirstName;
        string _LastName;
        int _PointAmount = 0;
        string _MemberNumber;
        string _MemberSince;

        ObservableCollection<Member> _members = new ObservableCollection<Member>();
        public Member(string firstName, string lastName, int pointAmount, string memberNumber, string memberSince)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _PointAmount = pointAmount;
            Random random = new Random();
            _MemberNumber = random.Next(1000000, 1000000).ToString();
            _MemberSince = random.Next(DateTime.Now.DayOfYear).ToString();
        }

        internal ObservableCollection<Member> members { get => _members; set => _members = value; }

        public override string ToString()
        {
            return base.ToString() + $"{_FirstName} {_LastName} -Points: {_PointAmount} -Member Id: {_MemberNumber} date: {_MemberSince}";
        }
    }
}
