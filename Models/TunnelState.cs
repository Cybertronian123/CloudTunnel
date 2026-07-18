namespace CloudTunnel.Models;

public class TunnelState
{
    public string Host { get; set; } = "127.0.0.1";

    public int Port { get; set; } = 8096;

    public string PublicUrl { get; set; } = string.Empty;

    public TunnelStatus Status { get; set; } = TunnelStatus.Stopped;
}