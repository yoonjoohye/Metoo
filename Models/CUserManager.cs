using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME_TOO.Models
{
    public class CUserManager
    {
        Metoo_KeyDataContext theUserContext;
        public CUserManager()
        {
            theUserContext = new Metoo_KeyDataContext();
        }
        public int AddUser(ref CUser aUser)
        {
            Metoo_Key tmpUser = new Metoo_Key();
            tmpUser.key = aUser.key;

            theUserContext.Metoo_Key.InsertOnSubmit(tmpUser);
            theUserContext.SubmitChanges();

            return 1;
        }
        public List<CUser> GetUsers()
        {
            IQueryable<Metoo_Key> tmpR = theUserContext.Metoo_Key.OrderByDescending(x => x.key);

            List<Metoo_Key> tmpL = tmpR.ToList<Metoo_Key>();
            List<CUser> resUsers = new List<CUser>();

            foreach (Metoo_Key iter in tmpL)
            {
                CUser tmpUser = new CUser();
                tmpUser.key = iter.key;
                resUsers.Add(tmpUser);
            }
            return resUsers;
        }

    }
}