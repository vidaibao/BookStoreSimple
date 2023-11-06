using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementMemberService
    {
        // this class interact with UI get or push data
        // call repository to get or update data

        public BookManagementMember? CheckLogin(string email, string password)
        {
            BookManagementMemberRepository repo = new BookManagementMemberRepository();
            BookManagementMember? account = repo.GetMember(email);
            //if (account == null) { return null; } // email not exits
            //if (account.Password == password) { return account; }
            //return null; // wrong password
            return account != null && account.Password == password ? account : null;
        }
    }
}
