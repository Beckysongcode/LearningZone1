﻿using LearningZone0.Data.Services;
using Microsoft.AspNetCore.Mvc;
using s4587831Milestone3.Data.Cart;
using s4587831Milestone3.Data.ViewModels;

namespace s4587831Milestone3.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ICoursesService _coursesService;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(ICoursesService coursesService, ShoppingCart shoppingCart)
        {
            _coursesService = coursesService;
            _shoppingCart = shoppingCart;
        }
        public IActionResult ShoppingCart ()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _coursesService.GetCourseByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _coursesService.GetCourseByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}