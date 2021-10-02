﻿using System;
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
        
        
        public IProductsRepository Repository { get; set; }  //because of the inversion (IocConfig.cs), no need =new xx() here

        public ViewResult List()
        {
            return View(Repository.Products);
        }
    }
}