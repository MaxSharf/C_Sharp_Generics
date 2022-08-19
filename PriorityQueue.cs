using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Generics
{
    public class PriorityQueue<T>
    {
        public T? _value;
        private PriorityQueue<T> _next;
        private PriorityQueue<T> _prev;
        private int _priority;
        public T? Value { get; set; }
        public PriorityQueue<T> Next { get; set; }
        public int Priority { get; set; }
        public PriorityQueue<T> Prev { get; set; }
        public PriorityQueue(T? value, int priority)
        {
            Value = value;
            Priority = priority;
        }
        public PriorityQueue()
        {
            _value = default(T);
        }
        public PriorityQueue(T value)
        {
            _value = value;
        }
    }
    internal class Queue<T>
    {
        public PriorityQueue<T> Head;
        public int amount;
        public Queue()
        {
            Head = new PriorityQueue<T>();
            amount = 0;
        }
        public T Peek()
        {
            return this.Head.Value;
        }
        public void Push(T value, int Priority)
        {
            PriorityQueue<T> node_elem = new PriorityQueue<T>(value, Priority);
            if (this.Head == null || Head.Priority < Priority)
            {
                node_elem.Next = this.Head;
                Head = node_elem;
            }
            else
            {
                PriorityQueue<T> buff = Head;
                while (buff.Next != null && buff.Next.Priority <= Priority)
                {
                    buff = buff.Next;
                    node_elem.Next = buff.Next;
                    buff.Next = node_elem;
                }
            }
            this.amount++;
        }
        public void Pop()
        {
            PriorityQueue<T> node_elem = this.Head;
            if (node_elem == null)
            {
                this.Head = null;
            }
            else
            {
                this.Head = this.Head.Next;
            }
            this.amount--;
        }
        public void Print()
        {
            int Count = this.amount;
            PriorityQueue<T> node_elem = this.Head;
            while (Count != 0)
            {
                Console.Write($"{node_elem.Value}");
                Count--;
                node_elem = node_elem.Next;
            }
        }
}
