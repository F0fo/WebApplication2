using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Order
    {
        String ID;
        List<Meal> meals;
        public Order(String newID)
        {
            this.ID = newID;
            this.meals = new List<Meal>();
        }

        public String getID()
        {
            return this.ID;
        }
        public void setID(String newID)
        {
            this.ID = newID;
        }
    }
}