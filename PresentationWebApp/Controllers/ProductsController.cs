﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;

namespace PresentationWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly ICategoriesService _categoriesService;
        private readonly IWebHostEnvironment _env;
        public ProductsController(IProductsService productsService, ICategoriesService categoriesService, IWebHostEnvironment env)
        {
            _productsService = productsService;
            _categoriesService = categoriesService;
            _env = env;
        }

        public IActionResult Index()
        {
            var list = _productsService.GetProducts();
            return View(list);
        }

        public IActionResult Details(Guid id)
        {
            var p = _productsService.GetProduct(id);
            return View( p);
        }

        //the engine will load a page with empty fields
        [HttpGet]
        [Authorize (Roles = "Admin")] //is going to be accessed only by authenticated users
        public IActionResult Create()
        {
            //fetch a list of categories
            var listOfCategeories = _categoriesService.GetCategories();

            //we pass the categories to the page
            ViewBag.Categories = listOfCategeories;

            return View();
        }

        //here details input by the user will be received
        [HttpPost]
        [Authorize (Roles = "Admin")]
        public IActionResult Create(ProductViewModel data, IFormFile f)
        {
            try
            {

                if (f != null)
                {
                    if (f.Length > 0)
                    {
                        //F:\School\Level 6 Year 2\Semester 1\Enterprise Programming\First Example\SWD62BEP\Presentation\PresentationWebApp\wwwroot
                        string newFileName = Guid.NewGuid() + System.IO.Path.GetExtension(f.FileName);
                        string newFileNameWithAbsolutePath = _env.WebRootPath + @"\images" + newFileName;

                        using (var stream = System.IO.File.Create(newFileNameWithAbsolutePath))
                        {
                            f.CopyTo(stream);
                        }
                        data.ImageUrl = @"\images" + newFileName;
                    }
                }

                _productsService.AddProduct(data);
                TempData["feedback"] = "Product was added Successfully";
            }
            catch (Exception e)
            {
                //Log error
                TempData["warning"] = "Product was not added";
            }

            //We resend the list of categories since the page will reload
            var listOfCategories = _categoriesService.GetCategories();

            //We pass the categories to the page
            ViewBag.Categories = listOfCategories;

            return View(data);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _productsService.DeleteProduct(id);
                ViewData["feedback"] = "Product was deleted";
            }
            catch (Exception ex)
            {
                //Log your error
                ViewData["warning"] = "Product was not deleted"; //Change from ViewData to TempData
            }

            return RedirectToAction("Index");
        }
    }
}
