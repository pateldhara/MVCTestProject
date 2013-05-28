using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MvcExampleApplication.Models
{
    internal class MemberServices
    {
        protected MemberDataBaseEntities _memberDataContext = new MemberDataBaseEntities();

        public virtual IList<Member> GetAllMember()
        {
            // Explicit assignment of default values
            List<Member> memberList = new List<Member>();
            memberList = _memberDataContext.Members.ToList();
            return memberList;
        }

        public virtual Member GetMember(int memberId)
        {
            Member member = _memberDataContext.Members.SingleOrDefault(m => m.MemberId == memberId);
            return member;
        }

        public virtual void UpdateMember(Member member)
        {
            _memberDataContext.Members.Attach(member);
            DbEntityEntry<Member> dbEntry = _memberDataContext.Entry(member);
            dbEntry.State = EntityState.Modified;
            _memberDataContext.SaveChanges();
        }

        public virtual void CreateMember(Member member)
        {
            _memberDataContext.Members.Add(member);
            _memberDataContext.SaveChanges();
        }

        //public void DeleteMember(Member member)
        //{
        //    memberDataContext.DeleteObject(member);       //.Members.DeleteObject(member);
        //    memberDataContext.SaveChanges();
        //}


    }
}