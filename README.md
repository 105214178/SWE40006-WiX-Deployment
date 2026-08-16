# SWE40006 WiX Deployment Assignment

This repository contains my work for the Desktop Application Deployment assignment in SWE40006 – Software Deployment and Evolution.

I used C#, Visual Studio and WiX Toolset to create Windows applications and package them as MSI installers.

## Tools used

- Windows 11 ARM virtual machine using UTM
- Visual Studio
- C#
- .NET
- WiX Toolset 4
- HeatWave extension
- NuGet Package Manager
- Git and GitHub

## Assignment progress

- [x] Task 1.1 – Pass level
- [x] Task 1.2 – Credit level
- [x] Task 1.3 – Distinction level
- [ ] Task 1.4 – High Distinction level

## Task 1.1 – Hello World application

For Task 1.1, I:

- Created and tested a simple C# Hello World application.
- Created a WiX installer project.
- Built an MSI installer.
- Installed and ran the application.
- Confirmed that the application appeared in Windows Installed Apps.
- Uninstalled the application and confirmed that its installed folder was removed.

## Task 1.2 – Student Task Tracker

For Task 1.2, I created my own C# console application called Student Task Tracker.

The application:

- Asks the user to enter two study tasks.
- Stores the tasks in a list.
- Displays the entered tasks.
- Was packaged as an MSI installer using WiX.
- Was tested through installation, execution and uninstallation.

## Task 1.3 – External dependencies

For Task 1.3, I added two external NuGet dependencies:

- `Humanizer.Core`
- `Newtonsoft.Json`

Humanizer is used to format the application title. Newtonsoft.Json is used to convert the task list into JSON text.

The WiX installer includes both external DLL files:

- `Humanizer.dll`
- `Newtonsoft.Json.dll`

I confirmed that both DLLs were installed in the Student Task Tracker folder and that the installed application ran successfully.

## Repository structure

- `Task1.1/HelloWorldApp` – the C# Hello World application.
- `Task1.1/WixExample` – the WiX installer for the Hello World application.
- `Task1.2/StudentTaskTracker` – my custom C# application.
- `Task1.2/StudentTaskTrackerInstaller` – the WiX installer containing the application and external DLL dependencies.

## Task 1.4 – Distribution

Task 1.4 will contain the GitHub Release and WinGet package submission details after they are completed.

## Student

Unna Nusen  
SWE40006 – Software Deployment and Evolution
