using System;
using System.Diagnostics;
using System.IO;

using Gtk;

namespace ui.scrollBox
{
    public class ScrollBox : ScrolledWindow
    {
        private Box mainBox = new Box(Orientation.Vertical, 5);
        public ScrollBox()
        {
            SetSizeRequest(500, 600);

            ShadowType = ShadowType.In;
            HscrollbarPolicy = PolicyType.Automatic;
            VscrollbarPolicy = PolicyType.Automatic;
            BorderWidth = 2;

            UpdateContainer();

            StyleContext.AddClass("scroll-box");
        }

        public void UpdateContainer()
        {
            if(mainBox.Children.Length > 0)
            {
                mainBox = new Box(Orientation.Vertical, 5);
            }

            var localPaths = core.PathManager.GetLocalPaths();

            foreach (var path in localPaths)
            {
                var label = new Label(path);
                label.Xalign = 0;

                mainBox.Add(label);
                mainBox.ShowAll();
            }

            Add(mainBox);
            ShowAll();
        }
        
    }
}
