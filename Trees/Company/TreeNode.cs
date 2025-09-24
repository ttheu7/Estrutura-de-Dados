using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public T Id { get; set; }
        public T Name { get; set; }
        public T Role { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode() { }

        public TreeNode(T data, TreeNode<T> parent = null)
        {
            Data = data;
            Parent = parent;
        }

        //Retorna o nível/altura da árvore fazendo o caminho inverso
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}