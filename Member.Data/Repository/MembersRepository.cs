using System;
using System.Collections.Generic;
using System.Text;
using Member.Data.Model;
using Member.Data.Interface;
using System.Linq;

namespace Member.Data.Repository
{
    public class MembersRepository : IMembers
    {
        public static List<Members> lisMembers = new List<Members>
        {
            new Members{MemberId=1, FirstName="Kirtesh", LastName="Shah", Address="Vadodara" },
            new Members{MemberId=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Members{MemberId=3, FirstName="Dilip", LastName="Shah", Address="Vadodara" },
            new Members{MemberId=4, FirstName="Atul", LastName="Shah", Address="Vadodara" },
            new Members{MemberId=5, FirstName="Swati", LastName="Shah", Address="Vadodara" },
            new Members{MemberId=6, FirstName="Rashmi", LastName="Shah", Address="Vadodara" },
        };
        public List<Members> GetAllMember()
        {
            return lisMembers;
        }

        public Members GetMember(int id)
        {
            return lisMembers.FirstOrDefault(x => x.MemberId == id);
        }

        public int SaveMember(Members members)
        {            
            lisMembers.Add(members);
            return 1;
        }

        public int UpdateMember(int id, Members members)
        {
            Members memberData = lisMembers.Single(x => x.MemberId == id);
            memberData.FirstName = members.FirstName;
            memberData.LastName = members.LastName;
            memberData.Address = members.Address;            
            return 1;
        }

        public int DeleteMember(int id)
        {
            var memberData = lisMembers.Single(x => x.MemberId == id);
            lisMembers.Remove(memberData);
            return 1;
        }
    }
}
