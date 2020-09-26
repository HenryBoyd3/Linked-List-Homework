using System;
using System.Collections.Generic;
using System.Text;


namespace Linked_List_Homework
{
    class LinkedList
    {
        Node head = null;

        public string GetFirst()
        {
            if (isHeadNull())
                return "no head";

            return head.data;
        }
        
        public void AddFirst(string data) //not used but was part of the Assignment
        {
            Node newNode = new Node(data);
            if (isHeadNull())
            {
                head = newNode;
                return;
            } 
            //adds item to the front of the list
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void AddLast(string data)
        {
            Node newNode = new Node(data);
            if (isHeadNull())
            {
                head = newNode;
                return;
            }
            //addes the list to the end of the list
            else
            {
                Node Last = MoveDownList();
                Last.next = newNode;
            }
        }
        public string SearchNodes(string question)
        {
            Node temp = head;
            if (isHeadNull())
            {
                return "list empty"; 
            }
            //if first item is the node looking for
            if (temp.data == question)
            {
                return question + " is here";
            }
            while (temp.next != null)
            {

                temp = temp.next;
                // to not skip the last item in the list
                if (temp.data == question)
                {
                    return question + " is here";
                }

            }
            return "that item isn't in our system.";
        }
        public void PrintAllNodes()
        {
            Node temp = head;

            if (isHeadNull())
            {
                Console.WriteLine("list Is empty");
                return;
            }
            else //first item of the list
            {
                Console.WriteLine(temp.data);
            }
            
            while (temp.next != null)
            {
                temp = temp.next;
                Console.WriteLine(temp.data);
            }

        }
        public Node MoveDownList()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public string RemoveNode(string item)
        {
            Node temp = head;
            Node previous = null;
            //checks if list is empty
            if (isHeadNull())
            {
                return "list empty";
            }
            //checks if the list has only one item and if that item is the item to be removed 
            if (temp.next == null && temp.data == item)
            {
                return item + " removed.";
            }
            //checks if the first item in the list of more then one item is the item to be removed
            if (temp.next != null && temp.data == item)
            {
                head = temp.next;
                return item + " removed.";
            }
            //searches through the list to see if the item exists
            while (temp.next != null && temp.data != item)
            {
                previous = temp;
                temp = temp.next;
            }
            //respons if item not found
            if (temp.next == null && temp.data != item)
            {
                return item + " not found";
            }
            //if item was found it will remove the node and keep the list linked.
            previous.next = temp.next;
            return item + " removed.";
        }
        private bool isHeadNull()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
    }
}
