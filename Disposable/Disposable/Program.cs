using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //начинаем работать с объектом myClass  
            //работаем с объектом myClass  
            //закончили работать с объектом myClass  
            if (myClass is IDisposable)
            {
                myClass.Dispose();
            }
        }
    }

    class MyClass : IDisposable
    {
        public void Dispose()
        {
            // Очистка неуправляемых ресурсов
        }
    }
}

