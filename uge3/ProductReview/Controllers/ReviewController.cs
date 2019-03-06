using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductReview.Models;
using ProductReview.Services;

namespace ProductReview.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _service;
        public ReviewController(IReviewService service)
        {
            _service = service;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Review model)
        {
            if (ModelState.IsValid) 
            {
                _service.AddReview(model);
                return RedirectToActionPermanent("Index");
            }

            return View(model);
        }
    }
}
