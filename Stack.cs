using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStack
{
    public class Stack
    {/// <summary>
    /// Поле для элемента ССД
    /// </summary>
        public int item;
        /// <summary>
        /// Поле, указывающее на следующий элемент стека
        /// </summary>
        public Stack next;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Stack()
        {
            item = -1;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="last">прошлый элемент или голова стека</param>
        /// <param name="n">значение нового элемента</param>
        public Stack(Stack last, int n)
        {
            item = n;
            last.next = this;
        }
        /// <summary>
        /// Проверяет: пуст ли стэк
        /// </summary>
        /// <param name="head">голова стека</param>
        /// <returns></returns>
        public static bool IsEmpty(Stack head)
        {
            if (head.item == -1) return true;
            else return false;
        }
        /// <summary>
        /// Удаление стека
        /// </summary>
        /// <param name="head">голова стека</param>
        public static void Delete(Stack head)
        {
            if (IsEmpty(head)) { head = null; return; }
            Stack del;
            while (head.next != null)
            {
                del = head;
                head = head.next;
                del = null;
            }
        }
        /// <summary>
        /// Удаление элемента из верха стека
        /// </summary>
        /// <param name="head">голова стека</param>
        /// <param name="top">верх стека</param>
        public static void DeleteElem(Stack head, Stack top)
        {
            if (head == top)
            {
                head.item = -1;
                head.next = null;
            }
            else
            {
                Stack pdel = head;
                while (pdel.next != top) pdel = pdel.next;
                pdel.next = null;
                top.item = pdel.item;
                top.next = pdel.next;
            }
        }
        /// <summary>
        /// Подсчет количества элементов стека
        /// </summary>
        /// <param name="head">голова стека</param>
        /// <returns></returns>
        public static int CountElements(Stack head)
        {
            Stack now = head;
            if (IsEmpty(head)) return 0;
            int count = 1;
            while (now.next != null)
            {
                now = now.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// Вывод строки со всеми элементами стека
        /// </summary>
        /// <param name="head">голова стека</param>
        /// <returns></returns>
        public static string Print(Stack head)
        {
            Stack print = head;
            string sprint = "================================\n\t";
            while (print != null)
            {
                sprint += Convert.ToString(print.item) + " ";
                print = print.next;
            }
            sprint += "\n================================";
            return sprint;
        }
    }
}
