using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trees
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public void Print(TreeNode<T> node, string indent = "")
        {
            if (node == null) return;

            Console.WriteLine($"{indent}{node.Data}");

            if (node.Children != null)
            {
                foreach (var child in node.Children)
                {
                    Print(child, indent + "   ");
                }
            }
        }

    }
}