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

    
  }
}
