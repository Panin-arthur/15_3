using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form15._3
{
    public partial class Form15_3 : Form
    {
        public Form15_3()
        {
            InitializeComponent();
        }
        private void DoIt_Click(object sender, EventArgs e)
        {
            RemoveLastNeg(queue);
            Outbox.Lines = queue.Printer();
        }

        MyQueue queue = new MyQueue();
        private void button1_Click(object sender, EventArgs e)
        {
            queue = GenerateQueue(-10, 10, 10);
            Outbox.Lines = queue.Printer();
        }

        //MyQueue GenerateQueue(int a, int n)
        //{
        //MyQueue q = new MyQueue();
        //генератор
        //  return q;
        //}

        MyQueue GenerateQueue(int a, int b, int n) //Создаём очередь
        {
            MyQueue q = new MyQueue();
            var rnd = new Random();
            int i = 0;
            while (i < n)
            {
                q.InQueue(rnd.Next(a, b).ToString());
                i++;
            }
            return q;
        }

        //void RemoveLastNeg(MyQueue q)
        //{
        //вынимаем и вставляем
        //}

        void RemoveLastNeg(MyQueue q)
        {
            MyQueue tmp = new MyQueue();
            int idx = -1, qc = q.count;
            for (int i = 0; i < qc; i++)
            {
                string s = q.OutQueue();
                if (int.Parse(s) < 0) idx = i;
                tmp.InQueue(s);
            }
            if (idx != -1)
                for (int i = 0; i < qc; i++)
                {
                    string s = tmp.OutQueue();
                    if (idx == i) continue;
                    q.InQueue(s);
                }
        }
    }
}
