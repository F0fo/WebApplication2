using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class MenuSection
    {

        String name;
        List<MenuItem> menuItems;

        public MenuSection(String inName)
        {
            this.menuItems = new List<MenuItem>();
            this.name = inName;
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String inname)
        {
            this.name = inname;
        }

        public void addMenuItem(MenuItem newItem)
        {
            menuItems.Add(newItem);
        }
        public void setMenuItem(MenuItem newItem)
        {
            for (int i = 0; i < menuItems.Count; i++)
                if (menuItems.ElementAt(i).getName().ToLower() == newItem.getName().ToLower())
                    menuItems.Insert(i, newItem);
        }
    }
}