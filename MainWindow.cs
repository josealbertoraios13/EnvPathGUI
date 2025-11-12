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
        Resizable = false;

        mainBox.StyleContext.AddClass("main-box");
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
        var label = new Label("Paths");
        label.Xalign = 0;

        var buttonBox = new ButtonsBox();
        buttonBox.StyleContext.AddClass("buttons-box");

        var scrollBox = new ScrollBox();

        AddWidget(label, buttonBox, scrollBox);
    }
}