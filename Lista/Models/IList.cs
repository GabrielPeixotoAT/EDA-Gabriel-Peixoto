using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDA_Gabriel_Peixoto.Lista.Models
{
    public interface IList
    {
        public INode head { get; set; }

        void Add(INode ellement);
        void AddOrdered(INode ellement);
        void Remove(INode ellement);
        void ConsolePrint();
        void ConsolePrintReverse();
    }

    public interface IList<T>
    {
        void Add(INode<T> ellement);
        void Remove(INode<T> ellement);
        void ConsolePrint();
    }
}