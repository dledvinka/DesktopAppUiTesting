using System.Windows.Controls;
using TestedApp.ViewModels;

namespace TestedApp.Views;

public partial class Stocks : UserControl
{
    public Stocks()
    {
        InitializeComponent();
        this.DataContext = new StocksViewModel();
    }
}