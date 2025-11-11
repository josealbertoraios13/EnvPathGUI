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
            AddButton("Add");
            AddButton("Remove");
            AddButton("Save");
        }

        private void AddButton(string label)
        {
            var button = new Button(label);
            PackStart(button, true, true, 0);
        }
    }
}