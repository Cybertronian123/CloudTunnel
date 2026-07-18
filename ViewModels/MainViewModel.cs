using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CloudTunnel.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private string _host = "127.0.0.1";
    public string Host
    {
        get => _host;
        set
        {
            if (_host != value)
            {
                _host = value;
                OnPropertyChanged();
            }
        }
    }

    private int _port = 8096;
    public int Port
    {
        get => _port;
        set
        {
            if (_port != value)
            {
                _port = value;
                OnPropertyChanged();
            }
        }
    }

    private string _publicUrl = string.Empty;
    public string PublicUrl
    {
        get => _publicUrl;
        set
        {
            if (_publicUrl != value)
            {
                _publicUrl = value;
                OnPropertyChanged();
            }
        }
    }

    private string _status = "Stopped";
    public string Status
    {
        get => _status;
        set
        {
            if (_status != value)
            {
                _status = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}