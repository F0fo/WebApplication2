using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class MealItem
    {
        String name;
        public MealItem(String newName)
        {
            this.name = newName;
        }

        public String getname()
        {
            return this.name;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }
    }
}
