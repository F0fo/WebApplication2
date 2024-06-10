using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class TableSeat
    {
        String seatID;
        List<Meal> seatMeal;

        public TableSeat(String inID)
        {
            this.seatID = inID;
            this.seatMeal = new List<Meal>();
        }

        public void setSeatID(String inID)
        {
            this.seatID = inID;
        }

        public String getSeatID()
        {

            return this.seatID;
        }
    }
}