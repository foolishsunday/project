using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTreeProject
{
    public class BinaryTree
    {
        private Node _head;     //头指针
        private string cStr;    //用于构造二叉树的字符串

        public string Result = "";

        public Node Head        
        {
            get { return _head; }
        }

        //构造方法
        public BinaryTree(string constructStr)
        {
            cStr = constructStr;
            _head = new Node(cStr[0]);      //添加头节点
            Add(_head,0);                     //给头节添加孩子节点
        }

        private void Add(Node parent, int index)
        {
            int leftIndex = 2 * index + 1;  //计算左孩子索引
            if (leftIndex < cStr.Length)    //如果索引没超过字符串长度
            {
                if (cStr[leftIndex] != '#') //'#'表示空结点
                {
                    parent.Left = new Node(cStr[leftIndex]);    //递归调用Add方法给左孩子添加孩子节点

                    Add(parent.Left,leftIndex);
                }
            }

            int rightIndex = 2 * index + 2;
            if (rightIndex < cStr.Length)
            {
                if (cStr[rightIndex] != '#')
                {
                    parent.Rigth = new Node(cStr[rightIndex]);
                    Add(parent.Rigth,rightIndex);
                }
            }
        }

        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Result += node.ToString();
                PreOrder(node.Left);        //递归
                PreOrder(node.Rigth);      
            }
        }
        public void MidOrder(Node node)
        {
            if (node != null)
            {
                MidOrder(node.Left);
                Result += node.ToString();
                MidOrder(node.Rigth);
            }
        }

        public void AfterOrder(Node node)
        {
            if (node != null)
            {
                AfterOrder(node.Left);
                AfterOrder(node.Rigth);
                Result += node.ToString();
            }
        }
    }
}
