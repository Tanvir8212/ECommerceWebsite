using ECommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommerceWebsite.Controllers.API
{
    public class ProductController : ApiController
    {
        MyDbContext DbContext;

        public ProductController()
        {
            DbContext = new MyDbContext();
        }


        [HttpGet]
        [Route("Product/getAllProducts")]
        public List<Product> getAllProducts()
        {
            return DbContext.Products.ToList();
        }

        [HttpGet]
        [Route("Product/getProductBySubCategory")]
        public List<Product> getProductBySubCategory(SubCatagory subCatagory)
        {
            return DbContext.Products.Where(p => p.SubCatagory == subCatagory).ToList();
        }

    }
}
