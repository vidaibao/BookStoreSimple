using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookManagementMemberRepository
    {
        // CRUD of Member table - Interact to DB

        // function return account by username / email

        public BookManagementMember? GetMember(string email)
        {
            BookManagement2023DbContext db = new BookManagement2023DbContext();
            // db hook to DB and got 3 tables
            return db.BookManagementMembers.FirstOrDefault(m => m.Email == email);
        }










    }
}
