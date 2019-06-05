using System;
using System.Collections.Generic;

namespace OOP
{
    public class Stack
    {
        private List<Node> _list = new List<Node>();
        public Stack(){}
        public void Push(Node node){
            _list.Add(node);
        }
        public void Pop(){
            _list.RemoveAt(_list.Count-1);
        }
        public void ClearStack(){
            _list.Clear();
        }
<<<<<<< HEAD
        //test commit 2
=======
>>>>>>> subTest2

    }
    public class Node{
        private readonly int _val;
        public Node(int _val)
        {
            this._val = _val;
        }
    }
}