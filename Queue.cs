using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryQueue
{
    public class Queue
    {/// <summary>
     /// Поле для элемента ССД
     /// </summary>
        public int value;
        /// <summary>
        /// Поле, указывающее на следующий элемент очереди
        /// </summary>
        public Queue next;
        /// <summary>
        /// Констрктор без параметров
        /// </summary>
        public Queue()
        {
            value = -1;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="last">прошлый элемент или начало очереди</param>
        /// <param name="m">значение нового элемента</param>
        public Queue(Queue last, int m)
        {
            value = m;
            last.next = this;
        }
        /// <summary>
        /// Проверяет: пуста ли оередь
        /// </summary>
        /// <param name="front">Начало очереди</param>
        /// <returns></returns>
        public static bool IsEmpty(Queue front)
        {
            if (front.value == -1) return true;
            else return false;
        }
        /// <summary>
        /// Удаление очереди
        /// </summary>
        /// <param name="front">Начало очереди</param>
        public static void Delete(Queue front)
        {
            if (IsEmpty(front)) { front = null; return; }
            Queue del;
            while (front.next != null)
            {
                del = front;
                front = front.next;
                del = null;
            }
        }
        /// <summary>
        /// Удаление элемента из начала очереди
        /// </summary>
        /// <param name="front">Начало очереди</param>
        public static void DeleteElem(Queue front)
        {
            if (front.next == null) front.value = -1;
            else
            {
                front.value = front.next.value;
                front.next = front.next.next;
            }
        }
        /// <summary>
        /// Подсчет количества элементов очереди
        /// </summary>
        /// <param name="front">Начало очереди</param>
        /// <returns></returns>
        public static int CountElements(Queue front)
        {
            Queue now = front;
            if (IsEmpty(front)) return 0;
            int count = 1;
            while (now.next != null)
            {
                now = now.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// Вывод строки со всеми элементами очереди
        /// </summary>
        /// <param name="front">Начало очереди</param>
        /// <returns></returns>
        public static string Print(Queue front)
        {
            Queue print = front;
            string sprint = "================================\n\t";
            while (print != null)
            {
                sprint += Convert.ToString(print.value) + " ";
                print = print.next;
            }
            sprint += "\n================================";
            return sprint;
        }
    }
}
