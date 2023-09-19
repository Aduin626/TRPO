using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREE
{
    internal class Program
    {

      class BinaryTreeTraversal
       {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в двоичном дереве: ");
            int n = int.Parse(Console.ReadLine());

            int[] binaryTree = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите значение {i + 1}-го элемента: ");
                binaryTree[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nПрямой обход двоичного дерева:");
            PreOrderTraversal(binaryTree, 0);

            Console.WriteLine("\nОбратный обход двоичного дерева:");
            PostOrderTraversal(binaryTree, 0);

            Console.WriteLine("\nСимметричный обход двоичного дерева:");
            InOrderTraversal(binaryTree, 0);

            Console.ReadLine();
        }


       // Прямой обход (pre-order traversal)

        static void PreOrderTraversal(int[] binaryTree, int index)
        {
            if (index >= binaryTree.Length)
            {
                return;
            }
            Console.Write(binaryTree[index] + " ");
            PreOrderTraversal(binaryTree, 2 * index + 1);
            PreOrderTraversal(binaryTree, 2 * index + 2);
        }
        
        // Обратный обход (post-order traversal)

        static void PostOrderTraversal(int[] binaryTree, int index)
        {
            if (index >= binaryTree.Length)
            {
                return;
            }
            PostOrderTraversal(binaryTree, 2 * index + 1);
            PostOrderTraversal(binaryTree, 2 * index + 2);
            Console.Write(binaryTree[index] + " ");
        }

       
        // Симметричный обход (in-order traversal)
        static void InOrderTraversal(int[] binaryTree, int index)
        {
            if (index >= binaryTree.Length)
            {
                return;
            }
            InOrderTraversal(binaryTree, 2 * index + 1);
            Console.Write(binaryTree[index] + " ");
            InOrderTraversal(binaryTree, 2 * index + 2);
        }

  
    }

}
}
