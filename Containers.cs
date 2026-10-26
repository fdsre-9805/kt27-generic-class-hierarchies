using System;
using System.Collections.Generic;

namespace ContainersApp
{
    public class Container<T>
    {
        protected List<T> items = new();

        public virtual void Add(T item) => items.Add(item);

        public int Count => items.Count;
    }

    // T зафиксирован как string - класс уже не обобщённый
    public class StringContainer : Container<string>
    {
        public void PrintAllUpper()
        {
            foreach (string item in items)
            {
                Console.WriteLine(item.ToUpper());
            }
        }
    }

    // T остаётся открытым - работает для любого типа
    public class CountingContainer<T> : Container<T>
    {
        public int TotalAdded { get; private set; }

        public override void Add(T item)
        {
            TotalAdded++;
            base.Add(item);
        }
    }
}
