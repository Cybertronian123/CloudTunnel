# ☁️ CloudTunnel

> A modern, lightweight Windows desktop application for creating and managing Cloudflare Tunnels with a beautiful native WinUI 3 interface.

CloudTunnel eliminates the need to interact with the terminal when exposing a local application over the internet using **Cloudflare Tunnel (cloudflared)**. Simply enter your local host and port, click **Start**, and CloudTunnel handles the rest.

---

## ✨ Features

### Current

- Modern WinUI 3 interface
- Custom Windows title bar
- Reusable status badge
- MVVM architecture
- Native Windows application
- Clean project structure
- Ready for Cloudflared integration

### Planned

- 🚀 Start / Stop Cloudflare Tunnel
- 🌐 Display generated `trycloudflare.com` URL
- 📋 One-click Copy URL
- 📂 Remember Host & Port
- 📄 Live Cloudflared logs
- 🟢 Real-time status updates
- 🌙 Light / Dark / System themes
- 🪟 System tray support
- ⚙️ Run Cloudflared as a Windows Service
- 🔄 Auto reconnect
- 📦 Installer support
- 🔔 Notifications

---

# Screenshots

> Screenshots coming soon.

---

# Tech Stack

| Technology | Purpose |
|------------|---------|
| WinUI 3 | Native Windows UI |
| .NET 9 | Application Framework |
| C# | Programming Language |
| MVVM | Application Architecture |
| Cloudflared | Tunnel Backend |

---

# Project Structure

```text
CloudTunnel
│
├── Assets
│
├── Config
│
├── Controls
│   ├── StatusBadge.xaml
│   └── TitleBar.xaml
│
├── Helpers
│
├── Models
│   ├── TunnelState.cs
│   └── TunnelStatus.cs
│
├── Runtime
│   └── cloudflared.exe
│
├── Services
│   ├── ClipboardService.cs
│   ├── CloudFlaredRunner.cs
│   └── SettingsService.cs
│
├── Styles
│
├── ViewModels
│   └── MainViewModel.cs
│
├── Views
│   └── MainView.xaml
│
├── App.xaml
├── MainWindow.xaml
└── MainWindow.xaml.cs
```

---

# Roadmap

## Phase 1 — Foundation ✅

- [x] WinUI 3 project
- [x] MVVM architecture
- [x] Project organization
- [x] Custom title bar
- [x] Status badge
- [x] Initial UI

---

## Phase 2 — Tunnel Management

- [ ] Start Cloudflared
- [ ] Stop Cloudflared
- [ ] Restart Tunnel
- [ ] Capture stdout
- [ ] Parse generated URL
- [ ] Display tunnel URL
- [ ] Copy URL

---

## Phase 3 — User Experience

- [ ] Card-based dashboard
- [ ] Mica backdrop
- [ ] Theme support
- [ ] Settings page
- [ ] Live logs
- [ ] Status animations
- [ ] Better icons

---

## Phase 4 — Production

- [ ] Windows Service
- [ ] System Tray
- [ ] Auto Start
- [ ] Installer
- [ ] Auto Updates

---

# How It Works

```text
User
   │
   ▼
CloudTunnel UI
   │
   ▼
CloudFlaredRunner
   │
   ▼
cloudflared.exe
   │
   ▼
Cloudflare Network
```

CloudTunnel acts as a graphical wrapper around `cloudflared.exe`, providing a simple interface while handling process management, URL extraction, status updates, and user interactions.

---

# Architecture

```text
                App
                 │
                 ▼
           MainWindow
                 │
                 ▼
            TitleBar
                 │
                 ▼
            MainView
                 │
                 ▼
         MainViewModel
                 │
                 ▼
       CloudFlaredRunner
                 │
                 ▼
         cloudflared.exe
```

---

# Planned Workflow

```text
Start Tunnel
      │
      ▼
Launch cloudflared.exe
      │
      ▼
Read Console Output
      │
      ▼
Extract Public URL
      │
      ▼
Update ViewModel
      │
      ▼
Refresh UI
```

---

# Design Goals

- Native Windows experience
- Minimalistic interface
- Fast startup
- No Electron
- Lightweight
- Fluent Design
- Clean architecture
- Easy to maintain
- Open source friendly

---

# Development Status

| Component | Status |
|----------|--------|
| Project Setup | ✅ |
| Window Framework | ✅ |
| Title Bar | ✅ |
| Status Badge | ✅ |
| Main UI | 🚧 |
| Cloudflared Integration | ⏳ |
| Settings | ⏳ |
| Service Mode | ⏳ |

---

# Requirements

- Windows 11
- .NET 9 SDK
- Cloudflared executable

---

# License

This project is licensed under the MIT License.

---

# Contributing

Contributions, feature requests, and bug reports are welcome.

If you'd like to contribute:

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Open a Pull Request

---

# Inspiration

CloudTunnel aims to provide the simplicity of applications like:

- Docker Desktop
- Dev Home
- Windows Terminal
- GitHub Desktop

while remaining lightweight and focused on Cloudflare Tunnel management.

---

# Author

Developed with ❤️ using WinUI 3 and C#.