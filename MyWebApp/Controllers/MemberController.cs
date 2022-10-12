using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Member.Data.Interface;
using Member.Data.Model;
using Member.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private IMembers members = new MembersRepository();

        [HttpGet("GetAllMembers")]
        public ActionResult<IEnumerable<Members>> GetAllMembers()
        {
            return members.GetAllMember();

        }
        
        [HttpGet("GetMemberById/{id}")]
        public ActionResult<Members> GetMemberById(int id)
        {
            return members.GetMember(id);
        }

        [HttpPost("Members")]
        public ActionResult<int> SaveMember(Members _members)
        {
            return members.SaveMember(_members);
        }

        [HttpPut("Members/{id}")]
        public ActionResult<int> UpdateMember(int id, Members _members)
        {
            return members.UpdateMember(id, _members);
        }

        [HttpDelete("Members/{id}")]
        public ActionResult<int> DeleteMember(int id)
        {
            return members.DeleteMember(id);
        }
    }
}
