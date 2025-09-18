using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trees
{

    // <T> -> especificação de um tipo genérico (Generics)

    public class TreeNode<T>
    {
        //Atributo Data do tipo Generic T armazenará o valor de fato
        public T Data { get; set; }

        //Atributo referência ao nó pai da árvore
        public TreeNode<T> Parent { get; set; }

        //Atributo lista dos nós filhos, também do tipo Generic "T"
        public List<TreeNode<T>> Children { get; set; }

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

