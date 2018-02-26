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

    
    // [TestMethod]
    // public void SortAsc_ReturnSortedList_Void()


    //TODO write a test to make sure category ID is getting saved.

  }
}
