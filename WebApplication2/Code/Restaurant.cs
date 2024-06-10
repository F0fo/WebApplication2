using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Restaurant
    {
        String name;
        List<branch> branches;


        public Restaurant(String name)
        {
            this.name = name;
            this.branches = new List<branch>();
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String newName)
        {
            this.name = newName;
        }

        public void addBranch(String ID, String Address)
        {
            branch newBranch = new branch(ID, Address);
            branches.Add(newBranch);
        }

        public void removeBranch(String ID)
        {
            for (int i = 0; i < branches.Count; i++)
            {
                if (branches.ElementAt(i).getID().ToLower() == ID.ToLower())
                {
                    branches.RemoveAt(i);
                }
            }

        }

        public branch getBranch(String ID) {

            for (int i = 0; i < branches.Count; i++)
            {
                if (branches.ElementAt(i).getID().ToLower() == ID.ToLower())
                {
                    return branches.ElementAt(i);
                }
            }

            return null;


        }


    }
}