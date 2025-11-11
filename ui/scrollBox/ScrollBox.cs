using System;
using System.Diagnostics;

using Gtk;

namespace ui.scrollBox
{
    public class ScrollBox : ScrolledWindow
    {
        public ScrollBox()
        {
            SetSizeRequest(200, 300);
            ShadowType = ShadowType.In;
            HscrollbarPolicy = PolicyType.Automatic;
            VscrollbarPolicy = PolicyType.Automatic;
            BorderWidth = 2;
            
        }
    }
}
