Imports DevExpress.Xpf.Core
Imports System.Linq
Imports System.Windows

Namespace HamburgerSubMenuThemeSelectorBehavior
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Public Sub New()
			For Each theme As Theme In Theme.Themes.ToList()
				Select Case theme.Category
					Case Theme.Office2007Category
						theme.ShowInThemeSelector = False
					Case Theme.MetropolisCategory
						theme.ShowInThemeSelector = False
					Case Else
				End Select
				If theme.Name = "DeepBlue" Then
					theme.ShowInThemeSelector = False
				End If
			Next theme
		End Sub
	End Class
End Namespace
