using System;
using System.Diagnostics;
using System.Numerics;
using Gtk;

namespace ui.buttonsBox
{
    public class ButtonsBox : Box
    {
        public ButtonsBox() : base(Orientation.Horizontal, 5)
        {
            AddButton(new Image(Stock.Add, IconSize.Button));
            AddButton(new Image(Stock.Remove, IconSize.Button));
            AddButton(new Image(Stock.Save, IconSize.Button));
        }

        private void AddButton(Image image)
        {
            var button = new Button();
            button.Image = image;
            Add(button);
        }
    }
}