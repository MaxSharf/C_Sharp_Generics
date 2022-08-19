using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Generics
{
   public  class MyQueue<T>
    {
        private T[]? _queue;
        private int? _count;
        private int? _MaxCount;

        public MyQueue(int _maxCount)
        {
            try
            {
                _maxCount = _maxCount;
                _queue = new T[_maxCount];
                _count = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception Handler: {e}");
            }

            void Clear() => _count = 0;

            bool isEmpty()
            {
                return _count == 0;
            }


            int Count()
            {
                return (int)_count;
            }

            bool isFull()
            {
                return _count == _maxCount;
            }

            void Add(T item)
            {
                if (!isFull())
                    _queue[(int)_count++] = item;
            }

            bool Move()
            {
                if (!isEmpty())
                {
                    T item = _queue[0];

                    for (int i = 1; i < _count; i++)
                        _queue[i - 1] = _queue[i];

                    _queue[(int)_count - 1] = item;
                    return true;
                }
                else
                    return false;
            }

            void Print(string msg)
            {
                Console.WriteLine($"{msg}   ");
                for (int i = 0; i < _count; i++)
                    Console.WriteLine($" {_queue[i]}  ");
            }
        }
        }
}
