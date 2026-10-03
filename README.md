# GVE — Geolocation & Tracking Mobile Application

**GVE (Geolocation & Tracking Application)** is a cross-platform mobile application designed to monitor and visualize the geographic position of connected modules and tracking collars.

The application combines **GPS geolocation, interactive maps, QR Code scanning and REST API communication** to provide a mobile interface for managing and monitoring connected tracking equipment.

> **Project status:** Active development / prototype
> **Platforms:** Android & iOS
> **Framework:** Xamarin.Forms

---

## 📱 Overview

GVE provides a mobile interface for operators who need to identify, locate and monitor connected modules or collars.

The application communicates with a remote REST API to retrieve tracking information and displays geographic positions directly on a map.

### Main workflow

```text
        ┌─────────────────────┐
        │   Mobile Application│
        │      GVE / GveApp   │
        └──────────┬──────────┘
                   │
          REST API / JSON
                   │
                   ▼
        ┌─────────────────────┐
        │    Remote Backend   │
        │                     │
        │ Modules / Positions │
        └──────────┬──────────┘
                   │
                   ▼
        ┌─────────────────────┐
        │ GPS / Tracking Data │
        └──────────┬──────────┘
                   │
                   ▼
             Google Maps
```

---

## ✨ Features

### 🔐 Authentication

The application provides an authentication interface for accessing the mobile application.

Current functionality includes:

* User login
* Username/password authentication interface
* Administrator access
* Location permission request
* Protected application areas

---

### 📍 GPS Geolocation

Geolocation is one of the main features of GVE.

The application can:

* Retrieve GPS coordinates
* Display the current device location
* Retrieve module/collar positions from a remote API
* Display geographic positions on a map
* Refresh location information
* Navigate and zoom on the map
* Display geographic areas around a position

Each position can contain information such as:

```text
Module ID
Collar ID
Latitude
Longitude
Location date
```

---

### 🗺️ Interactive Map

GVE integrates map visualization to provide a geographic view of connected equipment.

The map interface supports:

* Module/collar markers
* Current device position
* Geographic positioning
* Zoom and map navigation
* Position visualization
* Geographic radius around a location

This provides operators with a visual representation of the equipment being monitored.

---

### 📡 Collar Tracking

The application is designed to monitor connected tracking collars/modules.

The tracking interface can provide information such as:

* Collar identifier
* Module identifier
* UID
* Position
* Distance
* Battery level
* Tracking time
* Additional equipment information

The application architecture is designed to support the monitoring of individual tracking devices.

---

### 📦 Module Management

GVE includes a module management section.

Users can:

* Display available modules
* Retrieve modules from the REST API
* View module identifiers
* View collar numbers
* View module labels
* Access the module creation workflow

The application consumes the module endpoint:

```text
/api/modules
```

---

### 📷 QR Code Module Registration

GVE integrates QR Code scanning to simplify the identification and registration of modules.

The workflow includes:

```text
Add Module
    ↓
Open QR Scanner
    ↓
Scan QR Code
    ↓
Retrieve QR Value
    ↓
Validate Data
    ↓
Associate Module
```

The application handles invalid QR codes and allows the user to retry the scanning operation.

---

### 🔔 Notifications

A notification section is included in the application.

It provides a structure for displaying:

* Notification date
* Notification message
* Notification list

> **Current status:** The current version uses demonstration data. A complete server-side notification system is not yet implemented.

---

### ⚙️ Settings

The application includes a settings section.

The current version provides the basic structure for this section, while advanced configuration features remain under development.

---

### ❓ Help & About

GVE also includes:

* Help section
* About section
* Application information
* Additional information screens

Some of these screens are currently basic application views.

---

## 🌐 REST API Integration

GVE communicates with a remote backend through REST APIs.

The application retrieves JSON data from remote endpoints and uses this information to update the mobile interface.

Example API resources include:

```text
/api/modules
/api/positions
/api/position/{collar}
```

### Data flow

```text
Mobile App
    │
    │ HTTP / REST
    ▼
Remote API
    │
    │ JSON
    ▼
GveApp
    │
    ├── Modules
    ├── Positions
    └── Tracking information
```

> **Security note:** API credentials and sensitive configuration values should not be committed to the repository.

---

## 🏗️ Project Architecture

The solution follows a cross-platform mobile architecture based on Xamarin.Forms.

```text
GveApp.sln
│
├── GveApp
│   │
│   ├── Shared application logic
│   ├── Views
│   ├── Models
│   ├── Services
│   ├── API communication
│   └── Application resources
│
├── GveApp.Android
│   │
│   └── Android-specific implementation
│
└── GveApp.iOS
    │
    └── iOS-specific implementation
```

The shared project contains the common application logic, while Android and iOS projects provide platform-specific implementations.

---

## 🛠️ Technology Stack

| Technology        | Usage                    |
| ----------------- | ------------------------ |
| **C#**            | Application development  |
| **Xamarin.Forms** | Cross-platform mobile UI |
| **Android**       | Mobile platform          |
| **iOS**           | Mobile platform          |
| **REST API**      | Backend communication    |
| **JSON**          | Data exchange            |
| **GPS**           | Geolocation              |
| **Google Maps**   | Geographic visualization |
| **QR Code**       | Module identification    |
| **HTTP**          | API communication        |

---

## 📂 Repository Structure

```text
GveApp/
│
├── GveApp/
│   ├── Models/
│   ├── Views/
│   ├── Services/
│   ├── Resources/
│   └── ...
│
├── GveApp.Android/
│
├── GveApp.iOS/
│
├── GveApp.sln
├── .gitignore
├── .gitattributes
└── README.md
```

---

## 🚀 Getting Started

### Prerequisites

To work with the project, you will need a compatible Xamarin development environment with:

* Visual Studio
* C# development tools
* Xamarin.Forms
* Android SDK for Android development
* iOS development environment for iOS builds
* Access to the required REST API
* Google Maps configuration where required

> Xamarin.Forms is a legacy technology and has reached end of support. This repository represents the technology used by the original application. A future modernization path could target .NET MAUI.

---

## 🔧 Installation

Clone the repository:

```bash
git clone https://github.com/malado04/GveApp.git
cd GveApp
```

Open the solution:

```text
GveApp.sln
```

Then restore the required NuGet dependencies and select the desired platform:

```text
GveApp.Android
```

or:

```text
GveApp.iOS
```

---

## 🔌 Backend Configuration

Before running the application, verify the API configuration used by the mobile application.

The backend is responsible for providing resources such as:

```text
Modules
Positions
Tracking information
```

For production deployments, API URLs and sensitive configuration should be externalized rather than hard-coded into the application.

---

## 🧪 Project Status

### Implemented / available in the current codebase

* [x] Mobile authentication interface
* [x] GPS location access
* [x] Module/collar geolocation
* [x] Map visualization
* [x] Module listing
* [x] REST API communication
* [x] JSON data consumption
* [x] QR Code scanning
* [x] Android project
* [x] iOS project
* [x] Shared Xamarin.Forms application

### In progress / prototype

* [ ] Complete server-side notification system
* [ ] Advanced application settings
* [ ] Complete help/documentation screens
* [ ] Production-grade backend integration
* [ ] Automated tests
* [ ] Modern mobile framework migration

---

## 🔮 Future Improvements

Potential improvements include:

### Mobile modernization

Migration from:

```text
Xamarin.Forms
```

to:

```text
.NET MAUI
```

### Backend

A modern backend could provide:

```text
REST API
Authentication
Device management
Position management
Real-time tracking
Notifications
Audit logs
```

### Real-time tracking

Future versions could integrate:

* WebSockets
* SignalR
* Push notifications
* Real-time position updates
* Geofencing
* Tracking history

### Security

Potential improvements include:

* Token-based authentication
* Secure API configuration
* HTTPS-only communication
* Role-based access control
* Secure local storage
* API authorization
* Audit logging

---

## 🎯 Business Use Cases

GVE can serve as a foundation for applications involving:

* Connected equipment monitoring
* GPS tracking
* Field equipment management
* Asset tracking
* Mobile geolocation
* Connected devices
* Geographic monitoring
* QR-based equipment identification

---

## 📸 Screenshots

Screenshots can be added here to demonstrate the main application workflows.

Recommended screenshots:

```text
1. Login
2. Dashboard / Home
3. Interactive map
4. Module list
5. Module details
6. QR Code scanner
7. Notifications
8. Settings
```

Example:

```markdown
![Login](docs/screenshots/login.png)
![Map](docs/screenshots/map.png)
![Modules](docs/screenshots/modules.png)
```

---

## 📌 Engineering Highlights

This project demonstrates experience in:

* Cross-platform mobile development
* C# development
* Xamarin.Forms architecture
* REST API integration
* JSON data processing
* GPS and geolocation
* Geographic map visualization
* QR Code integration
* Mobile/backend communication
* Platform-specific Android/iOS development

---

## 👨‍💻 Author

**Amadou Malado Ndiaye**

Software Engineer | Full Stack Developer | Software Architecture

### Core technologies

```text
Java
Spring Boot
Laravel
PHP
Angular
TypeScript
C#
PostgreSQL
MySQL
Docker
Linux
REST APIs
```

---

## 📄 License

This project is provided for portfolio, demonstration and development purposes.

---

## ⭐ Project

If you find this project useful or interesting, feel free to explore the repository and follow the development.

**Repository:**
https://github.com/malado04/GveApp

 WhatApp +221 77 560 42 72 / +221 76 618 15 75
