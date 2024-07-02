using Microsoft.AspNetCore.Mvc;
using PieShop.Controllers;
using PieShop.ViewModels;
using PieShopTests.Mocks;

namespace PieShopTests.Controllers;

public class PieControllerTests
{
    [Fact]
    public void List_EmptyCategory_ReturnsAllPies()
    {
        //Arange
        var mockPieRepository = RepositoryMock.GetPieRepository();
        var mockcategoryRepostitory = RepositoryMock.GetCategoryRepository();

        var pieController = new PieController(mockPieRepository.Object, mockcategoryRepostitory.Object);

        //Act
        var result = pieController.List("");

        //Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
        Assert.Equal(10, pieListViewModel.Pies.Count());
    }
}