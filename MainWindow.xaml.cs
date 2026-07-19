using Microsoft.UI.Xaml;

namespace CloudTunnel;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ExtendsContentIntoTitleBar = true;

        SetTitleBar(TitleBarControl);
    }
}