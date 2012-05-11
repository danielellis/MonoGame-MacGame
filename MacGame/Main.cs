using System;
using MonoMac.Foundation;
using MonoMac.AppKit;

/// <summary>
/// Main class.
/// </summary>
class MainClass {
    /// <summary>
    /// The entry point of the program, where the program control starts and ends.
    /// </summary>
    /// <param name='args'>
    /// The command-line arguments.
    /// </param>
    static void Main (string [] args) {
        NSApplication.Init ();
        NSApplication.Main (args);
    }
}

/// <summary>
/// App delegate.
/// </summary>
[MonoMac.Foundation.Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate {
    /// <summary>
    /// The game.
    /// </summary>
    MacGame game;

    /// <summary>
    /// Called when Mac app is finished launching.
    /// </summary>
    /// <param name='notification'>
    /// Notification.
    /// </param>
    public override void FinishedLaunching (NSObject notification) {
        game = new MacGame();
        game.Run();
    }
}