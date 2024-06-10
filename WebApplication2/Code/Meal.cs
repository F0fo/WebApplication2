using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public class Meal
    {
        String ID;
        List<MealItem> mealItems;

        public Meal(String newID)
        {
            this.ID = newID;
            this.mealItems = new List<MealItem>();
        }

        public void setID(String inID)
        {
            this.ID = inID;
        }

        public String getID()
        {
            return this.ID;
        }


    }
}