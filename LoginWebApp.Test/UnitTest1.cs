using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;

namespace LoginWebApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        private AutoMocker _autoMocker;
        [TestMethod]
        public void TestMethod1()
        {
            // Make fack claims principle instance
            //var fackClaimPrinciple = new Mock<ClaimsPrincipal>();

            //// Setup fack data
            //IEnumerable<Claim> claims = new List<Claim>() 
            //                            {
            //                                new Claim(ClaimTypes.Name, "user@hotmail.com")
            //                            }.AsEnumerable();
            //fackClaimPrinciple.Setup(e => e.Claims).Returns(claims);

            //// Assign to current thread principle
            //Thread.CurrentPrincipal = fackClaimPrinciple.Object;

            //// Act
            //ViewResult result = homeController.Index() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
        }

        public void Index_should_return_private_view_for_authenticated_user()
        {
            //var logger = new NullLogger<HomeController>();
            //var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
            //                            new Claim(ClaimTypes.NameIdentifier, "SomeValueHere"),
            //                            new Claim(ClaimTypes.Name, "gunnar@somecompany.com")
            //                            // other required and custom claims
            //                       }, "TestAuthentication"));
            //var controller = new LoginWebApp.Pages.Account.LoginModel();
            //controller.ControllerContext = new ControllerContext();
            //controller.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            //var result = controller.Index() as ViewResult;
            //var viewName = result.ViewName;

            //Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
    }
}
