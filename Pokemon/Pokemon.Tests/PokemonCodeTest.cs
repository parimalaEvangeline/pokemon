using Pokemon;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pokemon.Tests
{
    [TestClass]
    public class PokemonCodeTest
    {

        [TestMethod()]
        public void OnePikachu_Should_make_total_six()
        {
            PokemonCode pokemon = new PokemonCode();
            double result = pokemon.total(1, 0, 0);
            Assert.AreEqual(6.00, result);
        }
        [TestMethod()]
        public void TwoPikachu_Should_make_total_twelve()
        {
            PokemonCode pokemon = new PokemonCode();
           double result = pokemon.total(2, 0, 0);
           Assert.AreEqual(12.00, result);
        }
       [TestMethod()]
      public void ThreePikachu_Should_make_total_Nine_something()
      {
        PokemonCode pokemon = new PokemonCode();
        double result = pokemon.total(1, 0, 1);
        Assert.AreEqual(9.90, result);
       }
    [TestMethod()]
    public void TwoPikachuTwoSquirtle_Should_make_total_As_Nineteen_Something(){
     PokemonCode pokemon = new PokemonCode();
    double result = pokemon.total(2, 0, 2);
    Assert.AreEqual(19.80, result);
    }
        [TestMethod()]
        public void ThreePikachuThreeSquirtle_Should_Make_total_as_twentyNine_something()
        {
            PokemonCode pokemon = new PokemonCode();
            double result = pokemon.total(3, 0, 3);
            Assert.AreEqual(29.70, result);
        }
        [TestMethod()]
        public void TwoPikachuOneSquirtle_Should_Make_total_as_Fifteen_something()
        {
            PokemonCode pokemon = new PokemonCode();
            double result = pokemon.total(2, 0, 1);
            Assert.AreEqual(15.90, result);
        }
        [TestMethod()]
        public void OnePikachuOneSquirtleOneCharmander_Should_Make_total_as_Twelve_something()
        {
            PokemonCode pokemon = new PokemonCode();
            double result = pokemon.total(1, 1, 1);
            Assert.AreEqual(12.80, result);
        }
        [TestMethod()]
        public void TwoPikachuOneSquirtleOneCharmander_Should_Make_total_as_Eighteen_something()
        {
            PokemonCode pokemon = new PokemonCode();
            double result = pokemon.total(2, 1, 1);
            Assert.AreEqual(18.80, result);
        }
       
    }
}
