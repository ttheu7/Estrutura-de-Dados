using Trees;
using System.Collections.Generic;

Tree<Person> company = new Tree<Person>();

company.Root = new TreeNode<Person>
{
    Data = new Person {Id = 100, Name = "Marcin Jamro", Role = "Chief Executive Officer (CEO)" },
    Parent = null
};

company.Root.Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{ Data = new Person {Id = 1, Name = "John Smith", Role = "Head of Development" }, Parent = company.Root},
    new TreeNode<Person>{ Data = new Person {Id = 50, Name = "Mary Fox", Role = "Head of Research" }, Parent = company.Root},
    new TreeNode<Person>{ Data = new Person {Id = 150, Name = "Lily Smith", Role = "Head of Sales" }, Parent = company.Root}
};

var headNode = company.Root.Children[0]; // Head of Development
headNode.Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{ Data = new Person {Id = 12, Name = "Chris Morris", Role = "Senior Developer" }, Parent = headNode}
};

headNode.Children[0].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{ Data = new Person {Id = 45, Name = "Eric Green", Role = "Junior Developer" }, Parent = headNode.Children[0]},
    new TreeNode<Person>{ Data = new Person {Id = 21, Name = "Ashley Lopez", Role = "Junior Developer" }, Parent = headNode.Children[0]}
};

headNode.Children[0].Children[1].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{ Data = new Person {Id = 6, Name = "Emily Young", Role = "Developer Intern" }, Parent = headNode.Children[0].Children[1]}
};


var researchNode = company.Root.Children[1]; // Head of Research
researchNode.Children = new List<TreeNode<Person>>
{
    new TreeNode<Person> { Data = new Person {Id = 70, Name = "Jimmy Stewart", Role = "Senior Researcher" }, Parent = researchNode },
    new TreeNode<Person> { Data = new Person {Id = 61, Name = "Andy Wood", Role = "Senior Researcher" }, Parent = researchNode }
};

var salesNode = company.Root.Children[2];
salesNode.Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{ Data = new Person {Id = 30, Name = "Anthony Black", Role = "Senior Sales Specialist" }, Parent = salesNode},
    new TreeNode<Person>{ Data = new Person {Id = 5, Name = "Angela Evans", Role = "Senior Sales Specialist" }, Parent = salesNode},
    new TreeNode<Person>{ Data = new Person {Id = 11, Name = "Tommy Butler", Role = "Senior Account Manager" }, Parent = salesNode}
};


salesNode.Children[0].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>{ Data = new Person {Id = 96, Name = "Paula Scott", Role = "Junior Sales Specialist" }, Parent = salesNode.Children[0]},
    new TreeNode<Person>{ Data = new Person {Id = 9, Name = "Sarah Watson", Role = "Junior Sales Specialist" }, Parent = salesNode.Children[0]}
};

company.Print(company.Root);