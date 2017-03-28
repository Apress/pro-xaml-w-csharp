using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch4DesignPatterns.Entity;
using Ch4DesignPatterns.Repository.Interfaces;
using Ch4DesignPatterns.UnitOfWork.Interfaces;

namespace Ch4DesignPatterns.Repository
{
    //TODO consider adding repositories to the unit of work to
    //implement an entity framework Uow with DBSet<Product> collections. 

    public class ProductRepository : IProductRepository
    {
        private IUnitOfWork _UnitOfWork;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork">
        /// Unit of work dependency which 
        /// will be injected into the constructor.
        /// </param>
        public ProductRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            _UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Retrieve all products from the db 
        /// </summary>
        /// <returns>A collection of Product entities.</returns>
        public IEnumerable<Product> GetProducts()
        {
            if (_UnitOfWork == null)
                throw new NullReferenceException();

            return _UnitOfWork.Products;
        }

        /// <summary>
        /// Retrieve a product from the db by it's id
        /// </summary>
        /// <param name="id">The unique product identifier</param>
        /// <returns>A product with the specified id.</returns>
        public Product GetProduct(int id)
        {
            if (_UnitOfWork == null)
                throw new NullReferenceException();

            return 
                _UnitOfWork.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Create a new Product instance
        /// and add it to the UnitOfWork.
        /// </summary>
        /// <param name="createInDatabase">
        /// If true, the new product will be saved
        /// to the database to receive an id.
        /// If false, return a new product instance.
        /// </param>
        /// <returns>A new Product entity.</returns>
        public Product NewProduct(bool createInDatabase)
        {
            var newProduct = new Product();

            if (createInDatabase)
                return _UnitOfWork.Save(newProduct);
            else
                _UnitOfWork.Add(newProduct);
                
            return newProduct;
        }

        /// <summary>
        /// Insert or Update a product to the db
        /// </summary>
        /// <param name="product">The product to save.</param>
        /// <returns>
        /// The product that was saved to the db.
        /// If the Product exists, an update is performed.
        /// If the Product is new, the retuned product will
        /// have a unique Id from the database system.
        /// </returns>
        public Product SaveProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            if (_UnitOfWork == null)
                throw new NullReferenceException();

            return _UnitOfWork.Save(product);
        }
    }
}
