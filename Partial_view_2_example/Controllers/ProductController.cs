using Partial_view_2_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partial_view_2_example.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        List<Product> Products = new List<Product>()
        {
            new Product{ProductID = 101, Name = "Car Tire", Price = 79.99, Photo = "~/Images/Car_Tire.jpg"},
            new Product{ProductID = 101, Name = "iPhone", Price = 599.99, Photo = "~/Images/iphone.jpg"},
            new Product{ProductID = 101, Name = "Macbook", Price = 6999.99, Photo = "~/Images/mac.jpg"},
            new Product{ProductID = 101, Name = "Ford Raptor", Price = 80999.99, Photo = "~/Images/raptor.jpg"}
        };

        public PartialViewResult Prototype()
        {
            return PartialView();
        }

        public ActionResult Index()
        {
            return View(Products);
        }
    }
}