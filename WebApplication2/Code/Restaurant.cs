using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Restaurant
    {
        static String name;
        static List<branch> branches = new List<branch>();


        public Restaurant(String name1)
        {
            name = name1;
        }

        public static String getName()
        {
            return name;
        }
        public static void setName(String newName)
        {
            this.name = newName;
        }

        public static void addBranch(String ID, String Address)
        {
            branch newBranch = new branch(ID, Address);
            branches.Add(newBranch);
        }

        public static void removeBranch(String ID)
        {
            for (int i = 0; i < branches.Count; i++)
            {
                if (branches.ElementAt(i).getID().ToLower() == ID.ToLower())
                {
                    branches.RemoveAt(i);
                }
            }

        }

        public static branch getBranch(String ID) {

            for (int i = 0; i < branches.Count; i++)
            {
                if (branches.ElementAt(i).getID().ToLower() == ID.ToLower())
                {
                    return branches.ElementAt(i);
                }
            }

            return null;


        }

        public static List<branch> getBranch()
        {
            return branches;
        }
    }
}