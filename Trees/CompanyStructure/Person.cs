using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company
{
    public class Person<T>
    {
        public T id { get; set; }
        public T name { get; set; }
        public T role { get; set; }
        public Person<T> parent { get; set; }
        public List<Person<T>> Children { get; set; }

        public Person() { }

        public Person(T id, T name, T role, T parent)
        {
            Id = id;
            Name = name;
            Role = role;
            Parent = parent;
        }
        
        public int GetHeight()
        {
            int height = 1;
            Person<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}