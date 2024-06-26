using PieShop.Models;

namespace PieShop.ViewModels;

public class HomeViewModel
{
    public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
    {
        PiesOfTheWeek = piesOfTheWeek;
    }

    public IEnumerable<Pie> PiesOfTheWeek { get; }
}