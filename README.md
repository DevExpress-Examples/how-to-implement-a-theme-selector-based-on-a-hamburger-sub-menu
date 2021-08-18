# How to Implement a Theme Selector Based on a Hamburger Sub Menu

[HamburgerSubMenuThemeSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenuThemeSelectorBehavior) automatically populates the associated [HamburgerSubMenu](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.HamburgerSubMenu) with all available themes and allows you to choose a theme applied to your application.

<img width="340" alt="HamburgerSubMenuThemeSelectorBehavior_vcKMBqClvU" src="https://user-images.githubusercontent.com/12169834/129886342-4fdc7873-323f-4f21-b260-fa98012c627a.png">

Refer to the [MainWindow.xaml](https://github.com/DevExpress-Examples/how-to-implement-a-theme-selector-based-on-a-hamburger-sub-menu/blob/19.2.12%2B/CS/HamburgerSubMenuThemeSelectorBehavior/MainWindow.xaml) (VB: [MainWindow.xaml](https://github.com/DevExpress-Examples/how-to-implement-a-theme-selector-based-on-a-hamburger-sub-menu/blob/19.2.12%2B/VB/HamburgerSubMenuThemeSelectorBehavior/MainWindow.xaml)) file to get the code sample that displays a **HamburgerSubMenu** with a theme selector.

## Hide a Theme from a Theme Selector

You can use the [Theme.ShowInThemeSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Theme.ShowInThemeSelector) property to specify whether a theme or a theme category is visible in the **HamburgerSubMenuThemeSelectorBehavior**. 

Refer to the [Application.xaml.cs](https://github.com/DevExpress-Examples/how-to-implement-a-theme-selector-based-on-a-hamburger-sub-menu/blob/19.2.12%2B/CS/HamburgerSubMenuThemeSelectorBehavior/App.xaml.cs) (VB: [Application.xaml.vb](https://github.com/DevExpress-Examples/how-to-implement-a-theme-selector-based-on-a-hamburger-sub-menu/blob/19.2.12%2B/VB/HamburgerSubMenuThemeSelectorBehavior/Application.xaml.vb)) file to get the code sample that hides [Office2007](https://docs.devexpress.com/WPF/7407#office-2007-themes) and [Metropolis](https://docs.devexpress.com/WPF/7407#metropolis-themes) theme categories, the [DeepBlue](https://docs.devexpress.com/WPF/7407#other-themes) application theme from the theme selector.

