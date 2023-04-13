using Microsoft.VisualBasic;
using System;

namespace ExpandesClass
{
    public class Post
    {
        private readonly string name;
        private readonly int salary;
        private readonly Division division;

        public string Name { get => name; }
        public int Salary { get => salary; }
        public Division Division { get => division; }
        public Post(string name, int salary, Division division)
        {
            this.name = name;
            this.salary = salary;
            this.division = division;
        }
    }
}