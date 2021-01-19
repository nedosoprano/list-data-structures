using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryStack;
using ClassLibraryQueue;

namespace Lab3App
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception my = new Exception("Упс... Что-то пошло не так...\n");
            try
            {
                while (true)
                {
                    Console.WriteLine("Выберете тип ССД:\n" +
                    "1 - Создать стек\n" +
                    "2 - Создать очередь\n" +
                    "3 - Завершение работы программы");
                    int operation = Convert.ToInt32(Console.ReadLine());
                    if (operation == 1)
                    {
                        Stack headStack = new Stack();
                        Stack topStack = new Stack();
                        int size = 0;
                        while (true)
                        {
                            Console.Write("Введите максимальный размер стека(<= 10): ");
                            size = Convert.ToInt32(Console.ReadLine());
                            if (size > 10) Console.WriteLine("Максимальный размер стека больше допустимого, повторите ввод");
                            else break;
                        }
                        while (true)
                        {
                            Console.WriteLine("\nМеню работы со стеком:\n" +
                            "1 - уничтожение стека (автоматически завершает работу со стеком)\n" +
                            "2 - возвращение элемента из вершины стека\n" +
                            "3 - вставка элемента в вершину стека\n" +
                            "4 - удаление элемента из вершины стека\n" +
                            "5 - определение количества элементов в стеке\n" +
                            "6 - определить, пуст ли стек\n" +
                            "7 - вывод элементов стека\n" +
                            "8 - завершение работы со стеком");
                            int operStack = Convert.ToInt32(Console.ReadLine());
                            if ((operStack == 1) || (operStack == 8))
                            {
                                Stack.Delete(headStack);
                                break;
                            }
                            if (operStack == 2)
                            {
                                if (Stack.IsEmpty(headStack)) Console.WriteLine("Стек пуст!");
                                else Console.WriteLine($"Элемент вершины стека = {topStack.item}");
                                continue;
                            }
                            if (operStack == 3)
                            {
                                if (Stack.CountElements(headStack) >= size) Console.WriteLine("Стек полон! Невозможно добавить новые элементы!");
                                else
                                {
                                    Console.Write("Введите новый элемент стека: ");
                                    int item = Convert.ToInt32(Console.ReadLine());
                                    Stack newElement = new Stack(topStack, item);
                                    if (Stack.IsEmpty(headStack)) headStack = newElement;
                                    topStack = newElement;
                                    Console.WriteLine("Элементы стека:\n" + Stack.Print(headStack));
                                }
                                continue;
                            }
                            if (operStack == 4)
                            {
                                if (Stack.IsEmpty(headStack)) Console.WriteLine("Стек пуст!");
                                else
                                {
                                    Stack.DeleteElem(headStack, topStack);
                                    if (Stack.IsEmpty(headStack)) Console.WriteLine("Теперь стек пуст!");
                                    else Console.WriteLine("Элементы стека:\n" + Stack.Print(headStack));
                                }
                            }
                            if (operStack == 5)
                            {
                                if (Stack.IsEmpty(headStack)) Console.WriteLine("Стек пуст!");
                                else Console.WriteLine("Количество элементов стека {0}", Stack.CountElements(headStack));
                                continue;
                            }
                            if (operStack == 6)
                            {
                                if (Stack.IsEmpty(headStack)) Console.WriteLine("Стек пуст!");
                                else Console.WriteLine("Стек заполнен!");
                                continue;
                            }
                            if (operStack == 7)
                            {
                                if (Stack.IsEmpty(headStack)) Console.WriteLine("Стэк пуст!");
                                else Console.WriteLine("Элементы стека:\n" + Stack.Print(headStack));
                                continue;
                            }
                            if (operStack > 8) Console.WriteLine("Неверный № операции, повторите ввод");
                        }
                    }
                    if (operation == 2)
                    {
                        Queue frontQueue = new Queue();
                        Queue backQueue = new Queue();
                        int size = 0;
                        while (true)
                        {
                            Console.Write("Введите максимальный размер очереди(<= 10): ");
                            size = Convert.ToInt32(Console.ReadLine());
                            if (size > 10) Console.WriteLine("Максимальный размер очереди больше допустимого, повторите ввод");
                            else break;
                        }
                        while (true)
                        {
                            Console.WriteLine("\nМеню работы с очередью:\n" +
                            "1 - уничтожение очереди (автоматически завершает работу с очередью)\n" +
                            "2 - выборка элемента из очереди\n" +
                            "3 - вставка элемента в конец очереди\n" +
                            "4 - удаление элемента из начала очереди\n" +
                            "5 - определение количества элементов в очереди\n" +
                            "6 - определить, пуста ли очередь\n" +
                            "7 - вывод элементов очереди\n" +
                            "8 - завершение работы с очередью");
                            int operQueue = Convert.ToInt32(Console.ReadLine());
                            if ((operQueue == 1) || (operQueue == 8))
                            {
                                Queue.Delete(frontQueue);
                                break;
                            }
                            if (operQueue == 2)
                            {
                                if (Queue.IsEmpty(frontQueue)) Console.WriteLine("Очередь пуста!");
                                else Console.WriteLine($"Первый элемент очереди = {frontQueue.value}");
                                continue;
                            }
                            if (operQueue == 3)
                            {
                                if (Queue.CountElements(frontQueue) >= size) Console.WriteLine("Очередь заполнена! Невозможно добавить новые элементы!");
                                else
                                {
                                    Console.Write("Введите новый элемент очереди: ");
                                    int item = Convert.ToInt32(Console.ReadLine());
                                    Queue newElement = new Queue(backQueue, item);
                                    if (Queue.IsEmpty(frontQueue)) frontQueue = newElement;
                                    backQueue = newElement;
                                    Console.WriteLine("Элементы сточереди:\n" + Queue.Print(frontQueue));
                                }
                                continue;
                            }
                            if (operQueue == 4)
                            {
                                if (Queue.IsEmpty(frontQueue)) Console.WriteLine("Очередь пуста!");
                                else
                                {
                                    Queue.DeleteElem(frontQueue);
                                    if (Queue.IsEmpty(frontQueue)) Console.WriteLine("Теперь очередь пуста!");
                                    else Console.WriteLine("Элементы стека:\n" + Queue.Print(frontQueue));
                                }
                            }
                            if (operQueue == 5)
                            {
                                if (Queue.IsEmpty(frontQueue)) Console.WriteLine("Очередь пуста!");
                                else Console.WriteLine("Количество элементов очереди {0}", Queue.CountElements(frontQueue));
                                continue;
                            }
                            if (operQueue == 6)
                            {
                                if (Queue.IsEmpty(frontQueue)) Console.WriteLine("Очередь пуста!");
                                else Console.WriteLine("Очередь заполнена!");
                                continue;
                            }
                            if (operQueue == 7)
                            {
                                if (Queue.IsEmpty(frontQueue)) Console.WriteLine("Очередь пуста!");
                                else Console.WriteLine("Элементы очереди:\n" + Queue.Print(frontQueue));
                                continue;
                            }
                            if (operQueue > 8) Console.WriteLine("Неверный № операции, повторите ввод");
                        }
                    }
                    if (operation == 3) break;
                }
            }
            catch (Exception e) { Console.WriteLine("\n" + e.Message); }
        }
    }
}
