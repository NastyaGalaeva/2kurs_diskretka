using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стек_на_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
                    try
                    {
                        FixedStack<string> stack = new FixedStack<string>(8);
                        // добавляем четыре элемента
                        stack.Push("Kate");
                        stack.Push("Sam");
                        stack.Push("Alice");
                        stack.Push("Tom");

                        // извлекаем один элемент
                        var head = stack.Pop();
                        Console.WriteLine(head);    // Tom

                        // просто получаем верхушку стека без извлечения
                        head = stack.Peek();
                        Console.WriteLine(head);    // Alice
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }


                    Console.Read();
            
        }
    }

    public class FixedStack<T>
    {
        private T[] items; // элементы стека
        private int count;  // количество элементов
        const int n = 10;   // количество элементов в массиве по умолчанию
        public FixedStack()
        {
            items = new T[n];
        }
        public FixedStack(int length)
        {
            items = new T[length];
        }
        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // размер стека
        public int Count
        {
            get { return count; }
        }
        // добвление элемента
        public void Push(T item)
        {
            // если стек заполнен, выбрасываем исключение
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = item;
        }
        // извлечение элемента
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            return item;
        }
        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            return items[count - 1];
        }
    }
}
