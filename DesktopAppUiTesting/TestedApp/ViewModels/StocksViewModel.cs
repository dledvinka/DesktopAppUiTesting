using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace TestedApp.ViewModels;

public class StocksViewModel : ObservableObject
{
    private string? _text;

    public string? Text
    {
        get => _text;
        set => SetProperty(ref _text, value, nameof(Text));
    }
}