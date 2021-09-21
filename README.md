<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1022677)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF MVVM Behaviors - Display a Theme Selector Based on a Hamburger Sub Menu

The [HamburgerSubMenuThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenuThemeSelectorBehavior) populates the associated [HamburgerSubMenu](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenu) with available themes and allows you to choose a theme applied to your application.

<img width="340" alt="HamburgerSubMenuThemeSelectorBehavior_vcKMBqClvU" src="https://user-images.githubusercontent.com/12169834/129886342-4fdc7873-323f-4f21-b260-fa98012c627a.png">

### Display Themes in the HamburgerSubMenu Preview

You can pass theme names to the https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenuThemeSelectorBehavior.PreviewThemeNames property to display a theme(s) in the https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenu preview. If you specify multiple themes, separate each theme with comma.

## Hide a Theme from a Theme Selector

You can use the [Theme.ShowInThemeSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.ShowInThemeSelector) property to specify whether a theme or a theme category is visible in the **HamburgerSubMenuThemeSelectorBehavior**. 

In this example, the [Office2007](https://docs.devexpress.com/WPF/7407#office-2007-themes) and [Metropolis](https://docs.devexpress.com/WPF/7407#metropolis-themes) theme categories, and the [DeepBlue](https://docs.devexpress.com/WPF/7407#other-themes) application theme are hidden from the theme selector.

## Save an Applied Theme to an Application Configuration File

Use the static [ApplicationThemeHelper.SaveApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.SaveApplicationThemeName) method to save the theme name specified in the static [ApplicationThemeHelper.ApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName) property to the application’s configuration file.

### Retrieve the Theme Name from the Configuration File
Call the static [ApplicationThemeHelper.UpdateApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName) method to retrieve the theme name from the configuration file.

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
