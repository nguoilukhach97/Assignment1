using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class NodeTree
    {
        public int Data { get; set; }
        public NodeTree Left { get; set; }
        public NodeTree Right { get; set; }
        public NodeTree(int data)
        {
            this.Data = data;
            Left = Right = null;
        }
        public void Insert(int data)
        {
            if(data <Data)
            {
                if (Left == null) 
                    Left = new NodeTree(data);
                else
                    Left.Insert(data);
            }
            if (data > Data)
            {
                if (Right == null)
                    Right = new NodeTree(data);
                else
                    Right.Insert(data);
            }
        }
    }
}
