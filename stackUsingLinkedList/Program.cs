﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        Node top;

        public Stacks()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return(true);
            else
                return (false);
        }

        


    }
}