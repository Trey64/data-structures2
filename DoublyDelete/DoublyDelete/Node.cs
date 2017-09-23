﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyDelete
{
    public class Node
    {
        public int Data { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
    }
}