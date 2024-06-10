using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Menu
    {
        String name;
        List<MenuSection> MenuSections;

        public Menu(String newName)
        {
            this.name = newName;
            this.MenuSections = new List<MenuSection>();
        }

        public void addMenuSection(MenuSection inMenu)
        {
            MenuSections.Add(inMenu);
            
        }

        public void removeMenuSection(String sectionName)
        {
            for (int i = 0; i < MenuSections.Count; i++)
            {
                if (MenuSections.ElementAt(i).getName().ToLower() == sectionName.ToLower())
                    MenuSections.RemoveAt(i);
            }

        }
        public String getName()
        {
            return this.name;
        }
        public void setName(String inName)
        {
            this.name = inName;
        }
    }
}