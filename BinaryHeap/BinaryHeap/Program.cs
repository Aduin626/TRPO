using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class BinaryHeap
    {
        private int[] heap;
        private int size;

        // Конструктор: задает размер кучи и инициализирует пустой массив
        public BinaryHeap(int capacity)
        {
            heap = new int[capacity];
            size = 0;
        }

        // Добавление элемента в кучу
        public void Add(int element)
        {
            if (size == heap.Length)
            {
                throw new InvalidOperationException("Куча переполнена");
            }

            heap[size] = element;
            UpHeap(size);
            size++;
        }

        // Удаление корневого элемента из кучи
        public int Remove()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Куча пуста");
            }

            int root = heap[0];
            size--;
            heap[0] = heap[size];
            DownHeap(0);
            return root;
        }

        // Получение значения корневого элемента
        public int Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Куча пуста");
            }

            return heap[0];
        }

        // Просеивание элемента вверх
        private void UpHeap(int i)
        {
            int parent = (i - 1) / 2;

            if (i > 0 && heap[i] < heap[parent])
            {
                Swap(i, parent);
                UpHeap(parent);
            }
        }

        // Просеивание элемента вниз
        private void DownHeap(int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int smallest = i;

            if (left < size && heap[left] < heap[smallest])
            {
                smallest = left;
            }

            if (right < size && heap[right] < heap[smallest])
            {
                smallest = right;
            }

            if (smallest != i)
            {
                Swap(i, smallest);
                DownHeap(smallest);
            }
        }

        // Обмен двух элементов в массиве
        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        // Демонстрация работы кучи
        public static void Main(string[] args)
        {
            BinaryHeap heap = new BinaryHeap(10);

            // Добавляем элементы
            heap.Add(3);
            heap.Add(4);
            heap.Add(7);
            heap.Add(1);
            heap.Add(8);

            // Выводим корневой элемент (1)
            Console.WriteLine("Peek: " + heap.Peek());

            // Удаляем корневой элемент (1)
            Console.WriteLine("Remove: " + heap.Remove());

            // Выводим новый корневой элемент (3)
            Console.WriteLine("Peek: " + heap.Peek());
            Console.ReadKey();
        }
        

    }


}
