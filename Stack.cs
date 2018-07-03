using System;
using System.Collections.Generic;

namespace OOP
{
    public class Stack
    {
        private List<Node> _list = new List<Node>();
        public Stack(){};
        public void Push(Node node){
            _list.Add(node);
        }
        public void Pop(){
            _list.RemoveAt(_list.Count-1);
        }
        public void ClearStack(){
            _list.Clear();
        }

    }
    public class Node{
        private readonly val;
        public Node(val)
        {
            this.val = val;
        }
    }
}