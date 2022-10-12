using System;
using System.Collections.Generic;
using System.Text;
using Member.Data.Model;

namespace Member.Data.Interface
{
    public interface IMembers
    {
        List<Members> GetAllMember();
        Members GetMember(int id);

        int SaveMember(Members members);

        int UpdateMember(int id, Members members);

        int DeleteMember(int id);
    }
}
