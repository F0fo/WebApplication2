using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplication2
{
    public class branch
    {
        String ID;
        String Address;
        List<Menu> menus;
        List<Table> tables;
        List<Employee> employees;
        public branch(String ID, String Address)
        {
            this.ID = ID;
            this.Address = Address;
            this.menus = new List<Menu>();
            this.tables = new List<Table>();
            this.employees = new List<Employee>();
        }

        public String getID()
        {
            return this.ID;
        }
        public String getAddress()
        {
            return this.Address;
        }

        public void setID(String inID)
        {
            this.ID = inID;
        }

        public void setAddress(String inAddress)
        {
            this.Address = inAddress;
        }
        public void addMenu(String Name)
        {   
            this.menus.Add(new Menu(Name));
        }

        public void removeMenu(String Name)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                if (menus.ElementAt(i).getName().ToLower() == Name.ToLower())
                {
                     menus.RemoveAt(i);
                }
            }
        }

        public Menu GetMenu(String Name)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                if (menus.ElementAt(i).getName().ToLower() == Name.ToLower())
                {
                    return menus.ElementAt(i);
                }
            }
            return null;
        }

        public void addTable(String inNO, int SeatCount)
        {
            this.tables.Add(new Table(inNO, SeatCount));
        }

        public Table GetTable(String InNO)
        {
            for(int i = 0;i < tables.Count; i++)
            { 
                if(tables.ElementAt(i).getTableNo().ToLower() == InNO.ToLower())
                {
                    return tables.ElementAt(i);
                }
            }
            return null;
        }

        public void RemoveTable(String InNO)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                if (tables.ElementAt(i).getTableNo().ToLower() == InNO.ToLower())
                {
                    tables.RemoveAt(i);
                }
            }
        }

        public void AddEmployee(String newName, String newPhone, String newAdd)
        {
            employees.Add(new Employee(newName, newPhone, newAdd));
        }

        public void RemoveEmployee(String Name)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                if (employees.ElementAt(i).getName().ToLower() == Name.ToLower())
                {
                    employees.RemoveAt(i);
                }
            }
        }

        public Employee GetEmployee(String Name)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                if (employees.ElementAt(i).getName().ToLower() == Name.ToLower())
                {
                    return employees.ElementAt(i);
                }
            }

            return null;
        }

        public List<Table> getTableList()
        {
            return tables;
        }

        public override string ToString()
        {
            return ID;
        }
    }
}