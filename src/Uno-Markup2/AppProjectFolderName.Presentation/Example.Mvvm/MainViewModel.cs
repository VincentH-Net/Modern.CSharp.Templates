﻿using Microsoft.Extensions.Localization;

namespace $namespacePrefix$.Presentation.CsMarkup2Example;

public partial class MainViewModel : ObservableObject
{
    INavigator _navigator;

    public MainViewModel(
        IStringLocalizer localizer,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
    }

    public string? Title { get; }

    public string? Name { get; set; }

    [RelayCommand]
    async Task GoToSecond()
    {
        await _navigator.NavigateViewModelAsync<SecondViewModel>(this, data: new Entity(Name ?? ""));
    }
}
