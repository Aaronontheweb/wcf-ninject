using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wcf_ninject.DI
{
    public interface IRepository
    {
        int CountUsers();
    }

    public class LinqToSQLRepository : IRepository
    {
        public int CountUsers()
        {
            return 10;
        }
    }
}
