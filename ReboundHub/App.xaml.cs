﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.UserProfile;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ReboundHub;
/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        this.InitializeComponent();
        this.UnhandledException += App_UnhandledException;
    }

    private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
    {
        // Log or handle the exception
        Debug.WriteLine($"Unhandled exception: {e.Exception.Message}");
        e.Handled = true; // Prevent the application from terminating
    }

    /// <summary>
    /// Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected async override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        if (string.Join(" ", Environment.GetCommandLineArgs().Skip(1)).Contains("CONTROL"))
        {
            var win = new ControlPanelWindow();
            cpanelWin = win;
            win.Show();
            win.SetWindowSize(1250, 750);
            win.CenterOnScreen();
            await Task.Delay(10);
            win.BringToFront();
            m_window = null;
            return;
        }
        if (string.Join(" ", Environment.GetCommandLineArgs().Skip(1)).Contains("UAC"))
        {
            var win = new UACWindow();
            win.Show();
            await Task.Delay(10);
            win.BringToFront();
            m_window = null;
            return;
        }
        if (string.Join(" ", Environment.GetCommandLineArgs().Skip(1)).Contains("UNINSTALL"))
        {
            var win = new UninstallationWindow();
            win.Show();
            await Task.Delay(10);
            win.BringToFront();
            m_window = null;
            return;
        }
        else
        {
            m_window = new MainWindow();
            m_window.Activate();
        }
    }

    public static Window m_window;

    public static ControlPanelWindow cpanelWin;
}
