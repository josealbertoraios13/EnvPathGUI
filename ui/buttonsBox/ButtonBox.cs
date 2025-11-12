using System;
using System.Diagnostics;
using System.Numerics;
using Gtk;
using ui.scrollBox;

namespace ui.buttonsBox
{
    public class ButtonsBox : Box
    {
        public ButtonsBox() : base(Orientation.Horizontal, 5)
        {
            AddButton(new Image(Stock.Add, IconSize.Button), "add");
            AddButton(new Image(Stock.Remove, IconSize.Button), "remove");
            AddButton(new Image(Stock.Save, IconSize.Button), "save");
        }

        private void AddButton(Image image, string type)
        {
            var button = new Button();
            button.Image = image;

            switch (type)
            {
                case "add":
                    button.Clicked += ScrollBox.Create;
                    break;
                case "remove":
                    button.Clicked += ScrollBox.Remove;
                    break;
                case "save":
                    break;            
            }

            Add(button);
        }
    }
}