using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Table
    {

        List<TableSeat> TableSeats;
        String TableNO;
        int SeatCount;
        Boolean Available;
        Order tablOrder;

        public Table(String inNO, int SeatCount)
        {
            this.TableSeats = new List<TableSeat>();
            this.Available = true;
            this.TableNO = inNO;
            this.SeatCount = SeatCount;
            this.tablOrder = new Order(inNO);
        }
        public int getSeatCount()
        {
            return this.SeatCount;
        }

        public String getTableNo()
        {
            return this.TableNO;
        }
        public bool isAvailable()
        {
            return this.Available;
        }
        public void setSeatCount(int newIn)
        {
            this.SeatCount = newIn;
        }
        public void setAvailable(bool newA)
        {
            this.Available = newA;
        }
        public void setTableNO(String newNO)
        {
            this.TableNO = newNO;
        }

        public override string ToString()
        {
            return this.TableNO;
        }
    }
}