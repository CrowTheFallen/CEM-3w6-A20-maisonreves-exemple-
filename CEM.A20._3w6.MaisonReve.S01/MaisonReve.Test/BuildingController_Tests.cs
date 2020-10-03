using System;
using Xunit;
using System.Linq;
using MaisonReve.Database.Repository;
using MaisonReve.Database.MockData;
using MaisonReve.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MaisonReve.Database.Models;
using Moq;

namespace MaisonReve.Test
{
    public class BuildingController_Tests
    {
        [Fact]
        public void BuildingIndex_Test()
        {
            //Arrange
            var mockRepo = new Mock<IBuildingRepo>();
            mockRepo.Setup(n => n.GetAllBuildings()).Returns(BuildingMockData.GetBuildingsTest());
            var controller = new BuildingsController(mockRepo.Object);


            //Act
            var result = controller.Index();


            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void BuildingIndexList_Test()
        {
            //Arrange
            var mockRepo = new Mock<IBuildingRepo>();
            mockRepo.Setup(n => n.GetAllBuildings()).Returns(BuildingMockData.GetBuildingsTest());
            var controller = new BuildingsController(mockRepo.Object);


            //Act
            var result = controller.Index();


            //Assert
            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<List<Building>>(viewResult.ViewData.Model);

        }

        [Fact]
        public void BuildingIndexNombre_Test()
        {
            //Arrange
            var mockRepo = new Mock<IBuildingRepo>();
            mockRepo.Setup(n => n.GetAllBuildings()).Returns(BuildingMockData.GetBuildingsTest());
            var controller = new BuildingsController(mockRepo.Object);


            //Act
            var result = controller.Index();


            //Assert
            var viewResult = result as ViewResult;
            var viewResultBuildings = viewResult.ViewData.Model as List<Building>;
            Assert.Equal(5, viewResultBuildings.Count);


        }
    }
}
