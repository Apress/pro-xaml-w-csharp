using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing.Domain.Service.Interfaces
{
    public interface IOrderService
    {
        Invoice CreateInvoice(Order order);
    }
}
