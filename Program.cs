using System;

using Gtk;
using ui;

public class Program
{
    public static void Main(string[] args)
    {
        Application.Init();

        var cssProvider = new CssProvider();
        cssProvider.LoadFromPath("ui/style/style.css");
        StyleContext.AddProviderForScreen(Gdk.Screen.Default, cssProvider, (uint)StyleProviderPriority.Application);

        var window = new MainWindow("Environment Path GUI");
        window.ShowAll();

        Application.Run();
    }
}
