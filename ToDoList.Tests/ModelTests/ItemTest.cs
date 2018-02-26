using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.DeleteAll();
      Category.DeleteAll();
    }

    public ItemTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo_test;";
    }

    [TestMethod]
    public void AddCategory_AddsCategoryToItem_CategoryList()
    {
      //Arrange
      Item testItem = new Item("Mow the lawn", "2018-02-26");
      testItem.Save();

      Category testCategory = new Category("Home stuff");
      testCategory.Save();

      //Act
      testItem.AddCategory(testCategory);

      List<Category> result = testItem.GetCategories();
      List<Category> testList = new List<Category>{testCategory};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
     public void GetCategories_ReturnsAllItemCategories_CategoryList()
     {
       //Arrange
       Item testItem = new Item("Mow the lawn", "2018-02-26");
       testItem.Save();

       Category testCategory1 = new Category("Home stuff");
       testCategory1.Save();

       Category testCategory2 = new Category("Work stuff");
       testCategory2.Save();

       //Act
       testItem.AddCategory(testCategory1);
       List<Category> result = testItem.GetCategories();
       List<Category> testList = new List<Category> {testCategory1};

       //Assert
       CollectionAssert.AreEqual(testList, result);
     }

     [TestMethod]
      public void Delete_DeletesItemAssociationsFromDatabase_ItemList()
      {
        //Arrange
        Category testCategory = new Category("Home stuff");
        testCategory.Save();

        string testDescription = "Mow the lawn";
        Item testItem = new Item(testDescription, "2018-02-26");
        testItem.Save();

        //Act
        testItem.AddCategory(testCategory);
        testItem.Delete();

        List<Item> resultCategoryItems = testCategory.GetItems();
        List<Item> testCategoryItems = new List<Item> {};

        //Assert
        CollectionAssert.AreEqual(testCategoryItems, resultCategoryItems);
      }


    // [TestMethod]
    // public void SortAsc_ReturnSortedList_Void()


    //TODO write a test to make sure category ID is getting saved.

  }
}
