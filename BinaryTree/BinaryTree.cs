using BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class BinaryTree
    {
        public NodeTree root { get; set; }
        public BinaryTree()
        {
            root = null;
        }
        public void InsertNode(int data)
        {
            if (root == null)
                root = new NodeTree(data);
            else
                root.Insert(data);
        }
        public void PreOrder(NodeTree node)
        {
            if (node == null) return;
            Console.Write(node.Data +" ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
        public void InOrder(NodeTree node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Data+" ");
            InOrder(node.Right);
        }
        public void PostOrder(NodeTree node)
        {
            if (node == null) return;
            PreOrder(node.Left);
            PreOrder(node.Right);
            Console.Write(node.Data + " ");
        }
        public bool Search(NodeTree node, int x)
        {
            if (node == null) return false;
            if (node.Data == x) return true;
            return x > node.Data ? Search(node.Right, x) : Search(node.Left, x);
            
        }
    }
}
