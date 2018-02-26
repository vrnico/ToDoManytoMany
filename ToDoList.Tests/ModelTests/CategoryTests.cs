using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Item.DeleteAll();
      Category.DeleteAll();
    }

    public CategoryTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo_test;";
    }

    [TestMethod]
    public void Delete_DeletesCategoryAssociationsFromDatabase_CategoryList()
    {
      //Arrange
      Item testItem = new Item("Mow the lawn", "2018-02-26");
      testItem.Save();

      string testName = "Home stuff";
      Category testCategory = new Category(testName);
      testCategory.Save();

      //Act
      testCategory.AddItem(testItem);
      testCategory.Delete();

      List<Category> resultItemCategories = testItem.GetCategories();
      List<Category> testItemCategories = new List<Category> {};

      //Assert
      CollectionAssert.AreEqual(testItemCategories, resultItemCategories);
    }


  }
}
