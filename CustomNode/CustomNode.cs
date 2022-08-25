using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList.CLinkedLLists
{
    //public class CustomNode    < = > code from youtube video = https://www.youtube.com/watch?v=ayqIO5F-0ng
    /*this class is the Node class that allows us to create and delete Nodes
       it has two constructors one that accepts data and one that does not
       It also creates a node that will serve as our next value"*/
    public class CustomNode     //does this need to be internal class CustomNode = NO in YT Video
    {
        public CustomNode Next; //set object of node class = next 
        public string data;

        //blank constructor 
        public CustomNode()
        {
            
        }
        public CustomNode(string data)
        {
            this.data = data;
        }


    }
}
