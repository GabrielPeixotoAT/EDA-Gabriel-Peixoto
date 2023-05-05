using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public interface INode
    {
        public string Value { get; set; }

        string ToString();
    }

    public interface INode<T>
    {
        public T Value { get; set; }
        
        string ToString();
    }
}