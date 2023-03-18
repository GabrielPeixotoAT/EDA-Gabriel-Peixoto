using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public class Ellement : INode
    {
        public string Value { get; set; }
        public INode? Next { get; set; }
        public INode? Prev { get; set; }

        public Ellement(string value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public class Ellement<T> : INode<T>
    {
        public T Value { get; set; }
        public INode<T>? Next { get; set; }

        public Ellement(T value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}