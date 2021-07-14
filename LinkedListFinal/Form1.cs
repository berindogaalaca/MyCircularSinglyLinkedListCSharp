using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myCircularSinglyLinkedList1.CreateList("header");
            myCircularSinglyLinkedList1.AddNew("2.");
            myCircularSinglyLinkedList1.AddNew("3.");
            myCircularSinglyLinkedList1.AddNew("4.");
            myCircularSinglyLinkedList1.Remove("header");
            //myCircularSinglyLinkedList1.Remove("4.");
            //myCircularSinglyLinkedList1.Remove("2.");
            //Trace.WriteLine(myCircularSinglyLinkedList1.Search("2.").data);
            //myCircularSinglyLinkedList1.Print();
            MessageBox.Show(myCircularSinglyLinkedList1.GetHead().data);
           //MessageBox.Show(myCircularSinglyLinkedList1.GetTail().data);
        }
    }
}
