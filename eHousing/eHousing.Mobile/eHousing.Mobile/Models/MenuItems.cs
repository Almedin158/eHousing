using System;
using System.Collections.Generic;
using System.Text;

namespace eHousing.Mobile.Models
{
    public enum MenuType
    {
        Estates,
        EditProfile,
        Logout
    }
    public class MenuItems
    {
        public MenuType ID { get; set; }
        public string Title { get; set; }
    }
}
