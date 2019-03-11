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

        public async Task<IActionResult> Index()
        {
            var items = await _service.GetReviews();
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return await Task.FromResult(View("Add"));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Review model)
        {
            if (ModelState.IsValid)
            {
                await _service.AddReview(model);
                return RedirectToActionPermanent("Index");
            }

            return View(model);
        }
    }
}
