<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1022677)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF MVVM Behaviors - Display a Theme Selector Based on a Hamburger Sub Menu

The [HamburgerSubMenuThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenuThemeSelectorBehavior) populates the associated [HamburgerSubMenu](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenu) with available themes and allows you to choose a theme applied to your application.

<img width="340" alt="HamburgerSubMenuThemeSelectorBehavior_vcKMBqClvU" src="https://user-images.githubusercontent.com/12169834/129886342-4fdc7873-323f-4f21-b260-fa98012c627a.png">

Refer to the [MainWindow.xaml](https://github.com/DevExpress-Examples/how-to-implement-a-theme-selector-based-on-a-hamburger-sub-menu/blob/19.2.12%2B/CS/HamburgerSubMenuThemeSelectorBehavior/MainWindow.xaml) (VB: [MainWindow.xaml](https://github.com/DevExpress-Examples/how-to-implement-a-theme-selector-based-on-a-hamburger-sub-menu/blob/19.2.12%2B/VB/HamburgerSubMenuThemeSelectorBehavior/MainWindow.xaml)) file to get the code sample that displays a **HamburgerSubMenu** with a theme selector.

## Hide a Theme from a Theme Selector

You can use the [Theme.ShowInThemeSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.ShowInThemeSelector) property to specify whether a theme or a theme category is visible in the **HamburgerSubMenuThemeSelectorBehavior**. 

In this example, the [Office2007](https://docs.devexpress.com/WPF/7407#office-2007-themes) and [Metropolis](https://docs.devexpress.com/WPF/7407#metropolis-themes) theme categories, and the [DeepBlue](https://docs.devexpress.com/WPF/7407#other-themes) application theme are hidden from the theme selector.

<!-- default file list -->
## Files to Look At

- [MainWindow.xaml](./CS/HamburgerSubMenuThemeSelectorBehavior/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HamburgerSubMenuThemeSelectorBehavior/MainWindow.xaml))
- [Application.xaml.cs](./CS/HamburgerSubMenuThemeSelectorBehavior/App.xaml.cs) (VB: [Application.xaml.vb](./VB/HamburgerSubMenuThemeSelectorBehavior/Application.xaml.vb))
<!-- default file list end -->

## Documentation

- [HamburgerSubMenuThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenuThemeSelectorBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
- [BarSubItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSubItemThemeSelectorBehavior)
- [BarSplitItemThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarSplitItemThemeSelectorBehavior)
- [RibbonGalleryItemThemePaletteSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemePaletteSelectorBehavior)

## More Examples
- [WPF MVVM Behaviors - Display Theme Selectors Based on BarItems and Hide Themes from List](https://github.com/DevExpress-Examples/wpf-mvvm-behaviors-barItems-based-theme-selectors)
