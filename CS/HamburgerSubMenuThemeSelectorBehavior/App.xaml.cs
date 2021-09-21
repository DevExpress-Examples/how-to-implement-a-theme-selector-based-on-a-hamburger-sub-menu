using DevExpress.Xpf.Core;
using System.Linq;
using System.Windows;

namespace HamburgerSubMenuThemeSelectorBehavior
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public App() {
            foreach (Theme theme in Theme.Themes.ToList()) {
                switch (theme.Category) {
                    case Theme.Office2007Category:
                        theme.ShowInThemeSelector = false;
                        break;
                    case Theme.MetropolisCategory:
                        theme.ShowInThemeSelector = false;
                        break;
                    default:
                        break;
                }
                if (theme.Name == "DeepBlue") {
                    theme.ShowInThemeSelector = false;
                }
            }
        }
    }
}
