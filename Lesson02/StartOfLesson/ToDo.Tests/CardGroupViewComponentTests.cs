using System;
using ToDoApp.ViewComponents;
using Xunit;


namespace ToDo.Tests
{
    public class CardGroupViewComponentTests
    {
        [Fact]
        public void Component_ShouldGet4OldestItems()
        {
            //Assemble
            var component = new CardGroupViewComponent();


            //Act
            component.Invoke();



            //Assert


        }
    }
}
