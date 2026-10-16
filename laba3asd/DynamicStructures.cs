using System;
using System.Collections.Generic;
using System.IO;

namespace laba3asd
{
    // --- ЕЛЕМЕНТИ ТА СТРУКТУРА ДЛЯ ЧЕРГИ (ЗАВДАННЯ 1) ---
    public class QueueNode
    {
        public int Data;
        public QueueNode Next;
        public QueueNode Prior;

        public QueueNode(int data)
        {
            Data = data;
            Next = null;
            Prior = null;
        }
    }

    public class CustomQueue
    {
        public QueueNode Begin;
        public QueueNode End;

        public CustomQueue()
        {
            Begin = null;
            End = null;
        }

        public bool IsEmpty()
        {
            return Begin == null;
        }

        public void Enqueue(int data)
        {
            QueueNode newNode = new QueueNode(data);
            if (IsEmpty())
            {
                Begin = newNode;
                End = newNode;
            }
            else
            {
                End.Next = newNode;
                newNode.Prior = End;
                End = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Черга порожня!");

            int value = Begin.Data;
            Begin = Begin.Next;
            if (Begin != null)
                Begin.Prior = null;
            else
                End = null;

            return value;
        }

        public string PrintQueue()
        {
            if (IsEmpty()) return "Черга порожня.";
            List<string> items = new List<string>();
            QueueNode current = Begin;
            while (current != null)
            {
                items.Add(current.Data.ToString());
                current = current.Next;
            }
            return string.Join(" -> ", items);
        }

        // Видалення всіх парних чисел з черги
        public void RemoveEvenNumbers()
        {
            CustomQueue tempQueue = new CustomQueue();
            while (!IsEmpty())
            {
                int val = Dequeue();
                if (Math.Abs(val) % 2 != 0) // Перевірка на непарність
                {
                    tempQueue.Enqueue(val);
                }
            }
            Begin = tempQueue.Begin;
            End = tempQueue.End;
        }

        public void Clear()
        {
            Begin = null;
            End = null;
        }
    }

    // --- ЕЛЕМЕНТИ ТА СТРУКТУРА ДЛЯ СТЕКА (ЗАВДАННЯ 2) ---
    public class StackNode
    {
        public int LineNumber;
        public int Length;
        public StackNode Next;

        public StackNode(int lineNumber, int length)
        {
            LineNumber = lineNumber;
            Length = length;
            Next = null;
        }
    }

    public class CustomStack
    {
        public StackNode Top;

        public CustomStack()
        {
            Top = null;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        public void Push(int lineNumber, int length)
        {
            StackNode newNode = new StackNode(lineNumber, length);
            newNode.Next = Top;
            Top = newNode;
        }

        public StackNode Pop()
        {
            if (IsEmpty()) return null;
            StackNode temp = Top;
            Top = Top.Next;
            return temp;
        }

        public string PrintStack()
        {
            if (IsEmpty()) return "Стек порожній.";
            List<string> items = new List<string>();
            StackNode current = Top;
            while (current != null)
            {
                items.Add($"[Рядок №{current.LineNumber}: Довжина = {current.Length}]");
                current = current.Next;
            }
            return string.Join("\r\n", items);
        }

        // Пошук останнього найдовшого рядка у файлі
        public (int lineNum, int maxLen) FindLastLongestLine()
        {
            if (IsEmpty()) return (-1, -1);

            int maxLen = -1;
            int lastLongestLineNum = -1;

            StackNode current = Top;
            while (current != null)
            {
                // Оскільки стек іде від останнього рядка файлу до першого,
                // перше зустрінуте значення, суворіше БІЛЬШЕ за maxLen, є останнім найдовшим.
                if (current.Length > maxLen)
                {
                    maxLen = current.Length;
                    lastLongestLineNum = current.LineNumber;
                }
                current = current.Next;
            }

            return (lastLongestLineNum, maxLen);
        }

        public void Clear()
        {
            Top = null;
        }
    }
}