using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Form15._3
{
    class Node     // Узел для списка, стека, очереди
    {
        public string inf;
        public Node next;
        public Node(string inf, Node next)            // Конструктор
        {
            this.inf = inf;
            this.next = next;
        }
    }
    class MyQueue    // Класс Очередь
    {
        public Node head;                            // голова 
        public Node tail;
        public int count;                       // число элементов

        public MyQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool QueueIsEmpty()              // проверка на пустоту
        {
            return head == null;
        }

        public void InQueue(string inf)            // положить в хвост очереди
        {
            Node p = new Node(inf, null);
            if (QueueIsEmpty())
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
            }
            count++;
        }

        public string OutQueue()                   // взять из головы очереди
        {
            Node p = head;
            head = head.next;
            count--;
            return p.inf;
        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            Node p = head;
            while (p != null)
            {
                Array.Resize(ref st, ++L);
                st[L - 1] = p.inf.ToString();
                p = p.next;
            }
            return st;
        }

    }
}
