using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {
    [Route("/categories")]
    public ActionResult Index()
    {
      List<Category> allCats = Category.GetAll();
      return View("Index", allCats);
    }

    [HttpGet("/categories/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/categories")]
    public ActionResult Create()
    {
        Category newCategory = new Category(Request.Form["category-name"]);
        newCategory.Save();
        return RedirectToAction("Success", "Home");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Detail(int id)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category selectedCategory = Category.Find(id);
        List<Item> categoryItems = selectedCategory.GetItems();
        List<Item> allItems = Item.GetAll();
        model.Add("category", selectedCategory);
        model.Add("categoryItems", categoryItems);
        model.Add("allItems", allItems);
        return View(model);
    }

    [HttpPost("/categories/{id}/items")]
    public ActionResult CreateItem(int id)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category foundCategory = Category.Find(id);
        List<Item> categoryItems = foundCategory.GetItems();
        Item newItem = new Item(Request.Form["new-item"]);

        categoryItems.Add(newItem);
        newItem.Save();
        model.Add("items", categoryItems);
        model.Add("category", foundCategory);
        return View("Detail", model);
    }

    [HttpPost("/categories/{categoryId}/items/new")]
      public ActionResult AddItem(int categoryId)
      {
          Category category = Category.Find(categoryId);
          Item item = Item.Find(Int32.Parse(Request.Form["item-id"]));
          category.AddItem(item);
          return RedirectToAction("Success", "Home");
      }

    [HttpGet("/categories/{id}/delete")]
    public ActionResult DeleteCategory(int id)
    {
      Category thisCategory = Category.Find(id);
      thisCategory.Delete();
      return RedirectToAction("Index");
    }
  }
}
