using System;
using System.Diagnostics;

using Gtk;

namespace ui.scrollBox
{
    public class ScrollBox : ScrolledWindow
    {
        private static Box mainBox = new Box(Orientation.Vertical, 5);
        private static Entry selectedItem =  new Entry();
        public ScrollBox()
        {
            SetSizeRequest(500, 650);

            ShadowType = ShadowType.In;
            HscrollbarPolicy = PolicyType.Automatic;
            VscrollbarPolicy = PolicyType.Automatic;
            BorderWidth = 2;

            UpdateContainer();

            StyleContext.AddClass("scroll-box");
        }

        public void UpdateContainer()
        {
            if (mainBox.Children.Length > 0)
            {
                mainBox = new Box(Orientation.Vertical, 5);
            }

            var localPaths = core.PathManager.GetLocalPaths();

            foreach (var path in localPaths)
            {
                var item = new Entry(path);
                item.Xalign = 0;
                item.FocusInEvent += ScrollBox.SetSelectedItem;

                mainBox.Add(item);
                mainBox.ShowAll();
            }

            Add(mainBox);
            ShowAll();
        }


        public static void Create(object? sender, EventArgs e)
        {
            var item = new Entry();
            item.Xalign = 0;

            mainBox.Add(item);
            mainBox.ShowAll();

            item.GrabFocus();
            item.FocusInEvent += SetSelectedItem;
        }

        public static void Remove(object? sender, EventArgs e)
        {
            mainBox.Remove(selectedItem);
            mainBox.ShowAll();
            selectedItem = new();
        }
        
        private static void SetSelectedItem(object? sender, EventArgs e)
        {
            if (sender != null)
                selectedItem = (Entry)sender;
        }
    }
}
