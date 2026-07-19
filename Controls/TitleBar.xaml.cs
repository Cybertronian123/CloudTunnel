using CloudTunnel.Models;
using Microsoft.UI.Xaml.Controls;

namespace CloudTunnel.Controls;

public sealed partial class TitleBar : UserControl
{
    public TitleBar()
    {
        InitializeComponent();

        StatusBadge.SetStatus(TunnelStatus.Stopped);
    }
}