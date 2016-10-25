using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Purchasing.Domain
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
