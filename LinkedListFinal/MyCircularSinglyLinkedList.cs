using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListFinal
{
    public class Node
    {
        /// <summary>
        /// Bir sonraki node.
        /// </summary>
        public Node next;
        public string data;

        /// <summary>
        /// Node classının kurucu metodu.
        /// </summary>
        /// <param name="data"></param>
        public Node(string data)
        {
            this.data = data;
        }

    }

    /// <summary>
    /// Dairesel linked list yapısı işlevi gören bileşen
    /// </summary>
    public partial class MyCircularSinglyLinkedList : Component
    {
        public MyCircularSinglyLinkedList()
        {
            InitializeComponent();
        }

        public MyCircularSinglyLinkedList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        Node Head;
        Node Tail;
        /// <summary>
        /// Listeyi oluşturmaya yarayan metot
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node CreateList(string data)
        {
            this.Head = new Node(data);
            Tail = this.Head;
            return this.Head;
        }
        /// <summary>
        /// Head'in get edilmesini sağlar
        /// </summary>
        /// <returns></returns>
        public Node GetHead()
        {
            return this.Head;
        }
        /// <summary>
        /// Head'in set edilmesini sağlar
        /// </summary>
        /// <param name="head"></param>
        public void SetHead(Node head)
        {
            this.Head = head;
        }
        /// <summary>
        /// Tail'in get edilmesini sağlar
        /// </summary>
        /// <returns></returns>
        public Node GetTail()
        {
            return Tail;
        }
        /// <summary>
        /// Tail'in set edilmesini sağlar
        /// </summary>
        /// <param name="tail"></param>
        public void SetTail(Node tail)
        {
            this.Tail = tail;
            this.Head = tail.next;
        }
        /// <summary>
        /// Yeni bir data eklenmesi yapan metot
        /// </summary>
        /// <param name="data"></param>
        public void AddNew(string data)
        {
            Node node = new Node(data);
            Tail.next = node;
            node.next = Head;
            Tail = node;
        }
        /// <summary>
        /// Data silme işlemini yapan metot
        /// </summary>
        /// <param name="data"></param>
        public void Remove(string data)
        {
            if (data == Head.data)
            {
                Tail.next = Head.next;
                Head = Head.next;
            }
            
            Node temp = Head.next;
            Node tempParent = Head;

            while (tempParent.next != Head)
            {
                if (temp.data == data)
                {
                    if (data == Tail.data)
                    {
                        tempParent.next = Tail.next;
                        Tail.next = null;
                        Tail = tempParent;
                    }
                    else
                    {
                        tempParent.next = temp.next;
                        temp = temp.next;
                    }
                }
                else
                {
                    tempParent = temp;
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Dairesel liste içinde arama yapan metot
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Search(string data)
        {
            if (data == Head.data)
            {
                return Head;
            }
            Node temp = Head.next;
            Node tempParent = Head;
            while (temp != Head)
            {
                if (temp.data == data)
                {
                    return temp;
                }
                else
                {
                    tempParent = temp;
                    temp = temp.next;
                }
            }
            return null;
        }
        /// <summary>
        /// Dairesel listedeki dataları yazdıran metot
        /// </summary>
        public void Print()
        {
            this.AddNew(" ");
            Node x = Head;
            Trace.WriteLine(x.data);
            while (x.next.next != Head)
            {
                x = x.next;
                Trace.WriteLine(x.data);
            }
            this.Remove(" ");
        }
    }
}

