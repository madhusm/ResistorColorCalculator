using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorColorCalculator.Models;
using ResistorColorCalculator.Controllers;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace TestResistorCalculator.UnitTests
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        [TestMethod]
        public void ShouldRenderDefaultView()
        {
            var sut = new HomeController();
            sut.WithCallTo(p => p.Index()).ShouldRenderDefaultView();

        }
        [TestMethod]
        public void ShouldRenderDefaultViewOnPost()
        {
            var sut = new HomeController();
            var res = new Resistor();
            res.BandAColor = "Brown";
            res.BandBColor = "green";
            res.BandCColor = "Silver";
            res.BandDColor = "Violet";
            sut.WithCallTo(p => p.Index(res)).ShouldRenderDefaultView();

        }
        [TestMethod]
        public void ShouldRenderDefaultViewOnPostOnInValidModel()
        {
            var sut = new HomeController();
            sut.ModelState.AddModelError("BandAColor", "BandAColor is Requried");
            var res = new Resistor();
            sut.WithCallTo(p => p.Index(res)).ShouldRenderDefaultView();

        }
        [TestMethod]
        public void ShouldHaveViewBags()
        {
            var sut = new HomeController();
            //sut.ViewBag.Message.ToString().Should().ShouldBeEquivalentTo("");

        }
    }
}
