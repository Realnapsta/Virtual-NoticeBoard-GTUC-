using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_NoticeBoard_GTUC_.Models
{
    public enum MenuItemType
    {
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
