using System.Collections.Generic;

namespace BusTicket.WebAdmin.Data
{
    public static class NavData
    {
        public static List<NavItem> Items = new List<NavItem>
        {
            new NavItem("Dashboard", "Home", "dashboard"),
            new NavItem("DirectEvent", "DirectEvent", "flash_on"),
            new NavItem("Seferler", "GridPanel", "grid_on"),
            new NavItem("Login", "Login", "dashboard"),
            new NavItem("Sefer Ekle", "AddExpedition", "dashboard")
        };
    }

    public class NavItem
    {
        public NavItem(string name, string path, string iconCls)
        {
            Name = name;
            Path = path;
            IconCls = iconCls;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string IconCls { get; set; }
    }
}
