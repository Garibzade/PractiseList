using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseGenericList.Models
{
    internal class GenericList<T>
    {
        T[] _arr;
        public int Capacity { get; set; }
        public int Count { get; private set; }
        private Type _listType;
        public GenericList(Type type)
        {
           

            _arr = new T[Capacity];
            _listType = type;
        }
        public GenericList(int capacity, Type type)
        {
            Capacity = capacity;
            _arr = new T[Capacity];
            _listType = type;
        }

        public GenericList()
        {
        }

        public T this[int num]
        {
            get { return _arr[Count]; }
            set { _arr[Count] = value; }

        }
        public void Add(T item)
        {
            //if (item.GetType().Name == _listType.Name) {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Capacity + Count);
                }
        //        _arr[Count] = item;
        //        Count++; 

        //}
            else { throw new Exception(); }
        }
        public void GetInfo()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
