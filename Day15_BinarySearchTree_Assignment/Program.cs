using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_BinarySearchTree_Assignment
{
    internal class Program
    {
        public class MyBinaryNode<T> where T : IComparable<T>
        {
            public T Key { get; }
            public MyBinaryNode<T> Left { get; set; }
            public MyBinaryNode<T> Right { get; set; }

            public MyBinaryNode(T key)
            {
                Key = key;
                Left = null;
                Right = null;
            }
        }

        public class BinarySearchTree<T> where T : IComparable<T>
        {
            private MyBinaryNode<T> root;

            public void Add(T key)
            {
                root = AddNode(root, key);
            }

            private MyBinaryNode<T> AddNode(MyBinaryNode<T> currentNode, T key)
            {
                if (currentNode == null)
                {
                    return new MyBinaryNode<T>(key);
                }

                int compareResult = key.CompareTo(currentNode.Key);

                if (compareResult < 0)
                {
                    currentNode.Left = AddNode(currentNode.Left, key);
                }
                else if (compareResult > 0)
                {
                    currentNode.Right = AddNode(currentNode.Right, key);
                }

                return currentNode;
            }

            public void PrintInOrderTraversal()
            {
                PrintInOrder(root);
            }

            private void PrintInOrder(MyBinaryNode<T> currentNode)
            {
                if (currentNode != null)
                {
                    PrintInOrder(currentNode.Left);
                    Console.Write(currentNode.Key + " ");
                    PrintInOrder(currentNode.Right);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Assignment");

            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.Add(56);
            bst.Add(30);
            bst.Add(70);

            bst.PrintInOrderTraversal();

            Console.ReadLine();
        }
    }
}
