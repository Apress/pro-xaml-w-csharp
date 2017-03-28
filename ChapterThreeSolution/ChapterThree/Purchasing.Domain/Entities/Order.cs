using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchasing.Domain
{
    /// <summary>
    /// Represents a customer's order
    /// </summary>
    public class Order
    {
        #region "private members"
        
        private int _Id;
        private IList<LineItem> _LineItems;
        private double _OrderTotal;
        
        #endregion

        #region "public properties"

        public int Id
        {
            get { return _Id; }
        }

        public int LineItemCount
        {
            get
            {
                return _LineItems.Count();
            }
        }

        #endregion

        #region "constructor"

        public Order()
        {
            _LineItems = new List<LineItem>();
        }

        public Order(int id)
        {
            _Id = id;
            _LineItems = new List<LineItem>();
        }

        #endregion

        #region "public methods"

        public void AddLineItem(LineItem lineItem)
        {
            _LineItems.Add(lineItem);
        }

        public double CalculateOrderTotal()
        {
            foreach (var lineItem in _LineItems)
            {
                _OrderTotal += lineItem.Price;
            }

            return _OrderTotal;
        }

        #endregion
    }
}
