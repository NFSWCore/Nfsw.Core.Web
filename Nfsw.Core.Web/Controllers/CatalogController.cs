using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Victory.DataLayer.Serialization;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class CatalogController : Controller
    {
        [HttpGet("productsInCategory")]
        public List<ProductTrans> ProductsInCategory(long userId, string categoryName, string clientProductType, string currencyType, string language)
        {
            List<ProductTrans> productTrans = new List<ProductTrans>();

            return productTrans;
        }
    }
}