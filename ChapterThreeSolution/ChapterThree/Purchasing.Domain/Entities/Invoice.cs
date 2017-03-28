using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace Purchasing.Domain
{
    /// <summary>
    /// Represents an invoice of a finalized Order
    /// </summary>
    public class Invoice
    {
        private int _Id;
        private double _OrderTotal;
        private DateTime _InvoiceDate;
        
        /// <summary>
        /// The unique id of the Invoice
        /// </summary>
        public int Id 
        {
            get { return _Id; }
        }

        /// <summary>
        /// The total cost of the order
        /// </summary>
        public double OrderTotal
        {
            get { return _OrderTotal; }
            set { _OrderTotal = value; }
        }

        /// <summary>
        /// The date in which the invoice was created.
        /// </summary>
        public DateTime InvoiceDate
        {
            get { return _InvoiceDate; }
        }

        public Invoice()
        {
            _InvoiceDate = DateTime.Now;
        }

        public Invoice(int id)
        {
            _Id = id;
            _InvoiceDate = DateTime.Now;
        }
    }
}
