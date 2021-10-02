using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {

        public const int PageSize = 3;
        public IProductsRepository Repository { get; set; }  //because of the inversion (IocConfig.cs), no need =new xx() here

        public ViewResult List(int page=2)
        {
            var result = Repository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)  //1,2,3,   4,5,6,    7,8,9
                .Take(PageSize);


            return View(result);




        }
    }
}