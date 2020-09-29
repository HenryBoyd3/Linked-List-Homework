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
            Node current = head;
            if (isHeadNull())
            {
                return "list empty"; 
            }
            //if first item is the node looking for
            if (current.data == question)
            {
                return question + " is here";
            }
            while (current.next != null)
            {

                current = current.next;
                // to not skip the last item in the list
                if (current.data == question)
                {
                    return question + " is here";
                }

            }
            return "that item isn't in our system.";
        }
        public void PrintAllNodes()
        {
            Node current = head;

            if (isHeadNull())
            {
                Console.WriteLine("list Is empty");
                return;
            }
            else //first item of the list
            {
                Console.WriteLine(current.data);
            }
            
            while (current.next != null)
            {
                current = current.next;
                Console.WriteLine(current.data);
            }

        }

        public string RemoveNode(string item)
        {
            Node current = head;
            Node previous = null;
            //checks if list is empty
            if (isHeadNull())
            {
                return "list empty";
            }
            //checks if the list has only one item and if that item is the item to be removed 
            if (current.next == null && current.data == item)
            {
                return item + " removed.";
            }
            //checks if the first item in the list of more then one item is the item to be removed
            if (current.next != null && current.data == item)
            {
                head = current.next;
                return item + " removed.";
            }
            //searches through the list to see if the item exists
            while (current.next != null && current.data != item)
            {
                previous = current;
                current = current.next;
            }
            //respons if item not found
            if (current.next == null && current.data != item)
            {
                return item + " not found";
            }
            //if item was found it will remove the node and keep the list linked.
            previous.next = current.next;
            return item + " removed.";
        }

        public Node MoveDownList()
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            return current;
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
