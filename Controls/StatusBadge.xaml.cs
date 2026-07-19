using CloudTunnel.Models;
using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

namespace CloudTunnel.Controls;

public sealed partial class StatusBadge : UserControl
{
    public StatusBadge()
    {
        InitializeComponent();
    }

    public void SetStatus(TunnelStatus status)
    {
        switch (status)
        {
            case TunnelStatus.Stopped:

                StatusText.Text = "Stopped";

                StatusDot.Fill = new SolidColorBrush(Colors.Red);

                BadgeBorder.Background =
                    new SolidColorBrush(Color.FromArgb(50, 255, 0, 0));

                break;

            case TunnelStatus.Starting:

                StatusText.Text = "Starting";

                StatusDot.Fill = new SolidColorBrush(Colors.Gold);

                BadgeBorder.Background =
                    new SolidColorBrush(Color.FromArgb(50, 255, 215, 0));

                break;

            case TunnelStatus.Running:

                StatusText.Text = "Running";

                StatusDot.Fill = new SolidColorBrush(Colors.LimeGreen);

                BadgeBorder.Background =
                    new SolidColorBrush(Color.FromArgb(50, 50, 205, 50));

                break;
        }
    }
}