﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingleLinkedList.CLinkedLLists;

namespace SingleLinkedList
{
    public partial class Form1 : Form
    {
        List<string> nodeValues;
        //List<string> nodeList = new List<string>();
        CircleLinkedList sLinkedList = new CircleLinkedList();
        public Form1()
        {
            InitializeComponent();
            
            sLinkedList.appendNode("I am the head");
            sLinkedList.appendNode("I am the second 2nd Node");
            sLinkedList.appendNode("I am the third 3rd Node");

            sLinkedList.prepend("I am the new head");
            sLinkedList.prepend("Mwhahahaha I am the new head now");
            sLinkedList.prepend("Look at me, I am the captain now");

            //sLinkedList.deleteWithData("I am the second 2nd node");
            //have to comment the delete to run the applyProfanityFilter method 
            //sLinkedList.applyProfanityFilter("second");
            //sLinkedList.applyProfanityFilter("am");   //commented out to run below insertAfter method
            sLinkedList.insertAfter("I have been inserted After","Look at me, I am the captain now");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nodeValues = sLinkedList.showNext();
            foreach (var item in nodeValues)
            {
                listView1.Items.Add(item.ToString());
            }
        }
    }
}
