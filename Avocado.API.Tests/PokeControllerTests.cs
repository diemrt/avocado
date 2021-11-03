using Avocado.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Avocado.API.Tests
{
    public class PokeControllerTests
    {
        private readonly PokeController _pokeController;

        public PokeControllerTests()
        {
            _pokeController = new PokeController();
        }

        [Fact]
        public void BaseMessage_MustPass()
        {
            var result = _pokeController.BaseMessage();
            Assert.True(result.Equals("This is a poke"));
        }
    }
}
