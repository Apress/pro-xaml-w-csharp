using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Purchasing.Domain.Service
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        void AddOrder(Order order);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Order RetreieveOrderById(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        void RemoveOrder(Order order);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void RemoveOrderById(int id);

        /// <summary>
        /// 
        /// </summary>
        void Commit();
    }
}
