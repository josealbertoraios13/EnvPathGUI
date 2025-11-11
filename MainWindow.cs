using System;
using System.Diagnostics;

using Gtk;
using ui.buttonsBox;
using ui.scrollBox;

public class MainWindow : Window
{
    private Box mainBox = new Box(Orientation.Vertical, 5);
    public MainWindow(string title) : base(title)
    {
        SetDefaultSize(500, 600);
        SetSizeRequest(500, 600);
        Resizable = false;

        Add(mainBox);

        DeleteEvent += (o, args) => Application.Quit();

        ConfigContent();
    }

    private void AddWidget(params Widget[] widgets)
    {
        foreach (var widget in widgets)
        {
            mainBox.Add(widget);
        }
    }

    private void ConfigContent()
    {
        var localLabel = new Label("Local Path");
        localLabel.Xalign = 0.1f;

        var localButtonBox = new ButtonsBox();

        var localScrollBox = new ScrollBox();

        var globalLabel = new Label("Global Path");
        globalLabel.Xalign = 0.1f;

        var globalButtonBox = new ButtonsBox();

        AddWidget(localLabel, localButtonBox, localScrollBox, globalLabel, globalButtonBox);
    }
}