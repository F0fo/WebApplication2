﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class MenuItem
    {

        String name;
        String ingredient;
        double price;
        MealItem mealItem;

        MenuItem(String newName, String newIngredient, double newPrice)
        {
            this.name = newName;
            this.ingredient = newIngredient;
            this.price = newPrice;
        }

        public String getName()
        {
            return this.name;
        }
        public String getIngredient()
        {
            return this.ingredient;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }

        public void setIngredient(String newIn)
        {
            this.ingredient = newIn;
        }
        public void setPrice(double newPrice)
        {
            this.price = newPrice;
        }
    }
}