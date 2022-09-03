using SingleLinkedList.CLinkedLLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList.CircleLinkedLists
{
    public class CircleLinkedList
    {
        //variables created below
        CustomNode head;
        //public CustomNode head;
        CustomNode current;
        //public string data;
        public string data;
        //String data;
        int nodeCount;  //int nodeCount = 0;
        List<string> nextlist;
        public int check;

        public void appendNode(string data)
        {
            /*This method walks through the list(from at head) and continually checks if there is a node next
            to the current node in the list it adds a new node with data if there are no nodes next to the current node
            appending data :-)*/

            //check if there is a head = //if the list is empty make a node call it head
            if (head == null)
            {
                //create a head if there is non created
                head = new CustomNode(data);
                head.Next = head;       //added on 30/08
                nodeCount++;
                return;
            }
            // if there is a head -> start walking through the list starting at the head
            current = head;
            // Check if there is node next to the current node(taversing the list)
            while (current.Next != head)
            {
                // keep moving through the list one node at a time
                current = current.Next; //if there is an existing list , walk through null

            }
            // create a new node if current.next is empty :-)
            current.Next = new CustomNode(data);
            current = current.Next;
            current.Next = head;
            nodeCount++;
        }

        public void prepend(string data)
        {
            /*This method adds a New node to the beginning of the list
             it sets the current head as its next value
            it then sets the new node to be the head node */
            if (head == null)
            {
                head = new CustomNode(data);
                head.Next = head;
                nodeCount++;
                // create new node called newHead
                //CustomNode newHead = new CustomNode(data);
                //nodeCount++;
                ////set the old head node as the next value of the new head 
                //newHead.Next = head;
                ////set the newHead as the head value 
                //head = newHead;
            }
            else
            {
                // create new node called newHead
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                //loop through until we get to the tail 
                while (current.Next !=head)
                {
                    current = current.Next;
                }
                current.Next = newHead;
                //set the old head node as the next value of the new head 
                newHead.Next = head;
                //set the newHead as the head value 
                head = newHead;
            }

        }

        public void deleteWithData(string data)
        {
            //check if the list is empty first
            if (head == null)
            {
                MessageBox.Show("Cannot delete a value from an empty list!");
                //Console.WriteLine("could not delete value : list is empty");
                return;
            }
            //handle the case if the head contains the data that we want to delete 
            if (head.data.Equals(data))
            {
                //walk around the head and set the very next node to be the head
                head = head.Next;
            }
            /*we never actually delete the node = we just change the pointer 
             to point to another node (walk around the node) */

            //1. start at the beginning of the list
            current = head;

            //2. we start walking through the list until there is no nodes left
            while (current.Next != head)
            {
                //3. check if the data in each node matches the data you want to delete 
                if (current.data.Equals(data))
                {
                    //4. walk around that value 
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data" + data + "Deleted!");
                    //System.Diagnostics.Debug.WriteLine("Node Deleted");
                    //return;
                }
                //if the data does not match check the next element 
                current = current.Next;
            }
            MessageBox.Show("Could not delete data, data not present in the list!");
        }

        //Lecture D: replacing values in a linked list: profanity filter 
        public void applyProfanityFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list to clean");
                return;
            }
            if (head.data.Contains(data))
            {
                //head.data = "*******";
                string replaceString = head.data.Replace(data, "******");
                head.data = replaceString;
                MessageBox.Show(head.data);
            }
            current = head;     //set current to head 
            //head = current;     //set head to current -- WRONG WAY OF CODE 
            //added on 16/08 prog lecture from 8:30am to 10:30am 
            while (current.Next != head)
            {
                current = current.Next;

                if (head.data.Contains(data))
                {
                    //string replaceString = head.data.Replace(data, "@#$@/!");
                    string replaceString = current.data.Replace(data, "@#$@/!");
                    current.data = replaceString;
                    MessageBox.Show(current.data);
                }
            }
            MessageBox.Show("No vulgar words!");
        }

        public int Count()
        {
            return nodeCount;
        }
        //edited showNext method on 16/08 in class with sarina 
        //removed parameters for method for accessibility in windows form display
        public List<string> showNext()
        {
            nextlist = new List<string>();
            current = head;
            nextlist.Add(current.data);
            while (current.Next != head)
            {
                nextlist.Add(current.Next.data);
                current = current.Next;
            }
            return nextlist;
        }

        public void insertAfter(string nodeData, string searchData)
        {
            if (head == null)
            {
                MessageBox.Show("There is no list here");
            }
            if (head.data.Contains(searchData))
            {
                CustomNode insertNode = new CustomNode(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;
            }
            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(searchData))
                {
                    CustomNode insertNode = new CustomNode(nodeData);
                    insertNode.Next = current.Next;
                    current.Next = insertNode;
                }
            }
        }

}
}
