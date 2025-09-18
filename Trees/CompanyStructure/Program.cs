using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Tree<Person> company = new Tree<Person>();
company.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Marcim Janro", "CEO"),
    Parent = null
};

company.Root.Children = new List<Person<Person>>
{
    
}