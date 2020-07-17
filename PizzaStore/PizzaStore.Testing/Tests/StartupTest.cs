using System.Collections.Generic;
using PizzaStore.Domain.Models;
using PizzaStore.Client;
using Xunit;

namespace PizzaStore.Testing.Tests
{
    public class StartupTest
    {
        [Fact]
        public void Test_CreateOrder()
        {
            //arrange
            var sut = new Startup();//sut means "subject under test"
            var user = new User();
            var store = new Store();


            //act
            var actual=sut.CreateOrder(user, store);
            
            //assert
            Assert.NotNull(actual);
        }
    }
}