//подключение пространства имен
using System;
using System.Collections.Generic;
using System.Globalization;


// Стек (Stack) - это структура данных, работающая по принципу "последним пришел - первым вышел" (LIFO).
// Очередь (Queue) представляет собой структуру данных, которая работает по принципу FIFO
// Очередь полезна, когда важен порядок элементов, и необходимо обработать элементы в порядке их добавления

namespace Stack_Queue_Deque
{
    //объявляем класс Example
    class Example
    {
        //определяем главный метот который будет вызываться всегда в начале программы
        static void Main()
        {
            //Использование стека
            Console.WriteLine("Использование стека");
            Stack<int> stack = new Stack<int>(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Вершина стека: " + stack.Peek()); // Должно вывести "Вершина стека: 3"
            Console.WriteLine("Количество элементов в стеке: " + stack.Count()); // Должно вывести "Количество элементов в стеке: 3"

            Console.WriteLine("Извлекаем элементы из стека:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("Вершина стека: " + stack.Peek());
            Console.WriteLine("Количество элементов в стеке: " + stack.Count());

            Console.ReadKey();

            //Использование очереди
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while (queue.Count > 0)
            {
                int item = queue.Dequeue();
                Console.WriteLine(item);
            }
            Console.ReadKey();


            //Использование дека


            LinkedList<int> deque = new LinkedList<int>();

            // Добавляем элементы в начало и конец дека.
            deque.AddFirst(1);
            deque.AddLast(2);
            deque.AddLast(3);
            deque.AddLast(4);

            // Извлекаем и выводим элементы с начала и с конца дека.
            while (deque.Count > 0)
            {
                int firstItem = deque.First.Value;
                int lastItem = deque.Last.Value;

                deque.RemoveFirst();
                deque.RemoveLast();

                Console.WriteLine($"First: {firstItem}, Last: {lastItem}");
            }
            Console.ReadKey();


            //инициализация целочисленного массива и его элементов
            int n = 3;
            int[] a = new int[n];
            string str;
            int i;
            a[0] = 1;
            a[1] = -8;
            a[2] = 14;




            //переменная в которую будет сохраняться сумма массива 
            int sum = 0;

            //цикл который сумирует все элементы массива
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            //переменная строки которая будет выводится после подсчета суммы
            str = "Сумма массива равна " + sum;

            //вывод строки в консоль
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();



            //вызовы методов все последующих заданий

            Symbol();
            Dynamic();
            Double();
            arraySort.array();
        }

        //Объявляю метод symbol
        static void Symbol()
        {
            //инициализация строкового массива и его элементов
            int n = 5;
            string[] a = new string[n];
            string str;
            int i;
            a[0] = "Миссисипи";
            a[1] = "Нил";
            a[2] = "Амазонка";
            a[3] = "Енисей";
            a[4] = "Белая";

            //переменная строки в которую будут записываться значения массива
            str = "";

            //цикл который добавляет по одному элементу в переменную и переносит коретку на новую строчку
            for (i = 0; i < n; i++)
            {
                str += a[i] + "\n";
            }
            //вывод строки в консоль
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }

        static void Dynamic()
        {
            //инициализация массива с плавающей точкой и его элементов
            double[] a = new double[] { -8, 13, 26, 14, 17, 21, -34, 28 };
            int n = a.Length;

            //строковая переменная 
            string str;
            //переменная для цикла
            int i;
            //переменная для записи суммы
            double sum = 0;
            //цикл в котором выводится каждый элемент массива и прибавляется к общей сумме
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
                sum += a[i];
            }

            //переменная для среднего арифметического
            double avg;
            //подсчет сред арифметического
            avg = sum / n;
            //образование и вывод строки 
            str = "Сумма массива равна " + sum + "\nСреднее арифметическое массива равно  " + avg;
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }

        static void Double()
        {
            //переменные для прохода по циклу
            int t, i;
            //инициализация многомерного массива
            int[,] table = new int[3, 4];

            //цикл который проходит по массиву и выводит элемент строки после операции на новой строчке и так для каждого столбца
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.WriteLine(table[t, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }


    }

    //Класс для сортировки
    class arraySort
    {
        //печатает массив с пробелом
        public static void print(int[] alpha)
        {
            foreach (int i in alpha)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }

        public static void array()
        {

            int[] alpha = { -4, 8, 28, -6, -98, -47, 12 };
            //Отобразить исходный массив

            Console.WriteLine("Исходный массив ...");
            //Вызываем метод print с аргументом alpha
            print(alpha);

            //Найти значение 8
            int pattern = 8;
            int indx = Array.BinarySearch(alpha, pattern);
            Console.WriteLine("Индекс элемента массива со значением 8: " + indx);

            //Сортируем массив
            Array.Sort(alpha);
            Console.WriteLine("Сортировка по возрастанию ...");
            //Отображаем массив после сортировки
            print(alpha);

            //Сортируем массив по убыванию
            Array.Reverse(alpha);
            //Отображаем массив после сортировки по убыванию
            Console.WriteLine("Сортировка по убыванию ...");
            print(alpha);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }

    //класс стека
    class Stack<T>
    {
        private T[] items;
        private int top; // Индекс вершины стека

        public Stack(int capacity)
        {
            items = new T[capacity];
            top = -1; // Инициализируем вершину как -1 (стек не имеет элементов)
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                Console.WriteLine("Стек переполнен");
            }
            else
            {
                items[++top] = item; // Увеличиваем top и добавляем элемент на вершину стека
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст!");
                return default(T);
            }
            else
            {
                T item = items[top--]; // Удаляем элемент с вершины стека и уменьшаем top
                return item;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст!");
                return default(T);
            }
            else
            {
                return items[top]; // Возвращаем элемент с вершины стека без удаления
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Count()
        {
            return top + 1; // Кол-во элемнтов в стеке
        }
    }



    class Deque<T>
    {
        private T[] arr;
        private int front;
        private int rear;
        private int capacity;
        private int count;

        public Deque(int size = 10)
        {
            arr = new T[size];
            front = -1;
            rear = 0;
            capacity = size;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void AddFront(T item)
        {
            if ((front == 0 && rear == capacity - 1) || (front == rear + 1))
            {
                throw new Exception("Deque is full");
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
            {
                front = capacity - 1;
            }
            else
            {
                front--;
            }

            arr[front] = item;
            count++;
        }

        public void AddLast(T item)
        {
            if ((front == 0 && rear == capacity - 1) || (front == rear + 1))
            {
                throw new Exception("Deque is full");
            }

            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (rear == capacity - 1)
            {
                rear = 0;
            }
            else
            {
                rear++;
            }

            arr[rear] = item;
            count++;
        }

        public T RemoveFront()
        {
            if (front == -1)
            {
                throw new Exception("Deque is empty");
            }

            T item = arr[front];

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == capacity - 1)
            {
                front = 0;
            }
            else
            {
                front++;
            }

            count--;

            return item;
        }

        public T RemoveLast()
        {
            if (front == -1)
            {
                throw new Exception("Deque is empty");
            }

            T item = arr[rear];

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (rear == 0)
            {
                rear = capacity - 1;
            }
            else
            {
                rear--;
            }

            count--;

            return item;
        }

        public T PeekFront()
        {
            if (front == -1)
            {
                throw new Exception("Deque is empty");
            }

            return arr[front];
        }

        public T PeekLast()
        {
            if (front == -1)
            {
                throw new Exception("Deque is empty");
            }

            return arr[rear];
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }

        public bool IsFull()
        {
            return ((front == 0 && rear == capacity - 1) || (front == rear + 1));
        }
    }



}
//dfdfcc