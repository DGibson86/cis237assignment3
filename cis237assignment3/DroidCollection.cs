using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Node
    {
        public Node Next
        {
            get;
            set;
        }

        public string Data
        {
            get;
            set;
        }
    }

    class DroidCollection
    {
        // private variale to hold the current position of where we are in the linked list
        private Node current;

        // holds the last postion in the list
        private Node last;

        // a public property that will point to the head node. first in the list
        public Node Head
        {
            get;
            set;
        }

        // constructor. it will set the head to null because there is nothing in the list yet
        public DroidCollection()
        {
            Head = null;
        }

        public void Add(string content)
        {
            // make a new node to add to the linked list
            Node node = new Node();
            // set the data to the passed in contect
            node.Data = content;

            // this will add the first element to our list
            if(Head == null)
            {
                Head = node;
            }
            // not the first node so set the new node to the current node's next variable
            else
            {
                last.Next = node;
            }
            // move down the list. set current to the next node we added
            last = node;
        }

        public bool Delete(int entryNumber)
        {
            // set current to head. need to walk through it from the beginning
            current = Head;

            // if the position is the very first node in the list
            if (entryNumber == 1)
            {
                // set the head to the next node in the list
                Head = current.Next;
                // delete the current.next pointer so there is no reference from current to 
                // another node
                current.Next = null;
                // current = null for the garbage collector;
                current = null;
                // it was successfull so, return true
                return true;
            }

            // check to make sure that at least a positive nuber was entered
            // should also check to make sure that the postion is less that the
            // size of the array so that we aren't looking for something that doesn't 
            // exist. adding a size property will be more work
            // TODO: add a size property
            if (entryNumber > 1)
            {
                // make a temp node that starts at the head. this way we don't need to actually
                // move the head pointer. we can just use the temp node
                Node tempNode = Head;
                // set the previous node to null. it will be used for the delete
                Node previousTempNode = null;
                // start a counter to know if we have reached the position yet ot not
                int count = 0;

                // while the temp node is not null, we can continue to walk through the 
                // linked list. if it is null, then we have reached the end
                while (tempNode != null)
                {
                    // if the count is the same as the position entered - 1, then we have found
                    // the one we would like to delete
                    if (count == entryNumber - 1)
                    {
                        // set the last node's next property to the tempnodes next property
                        previousTempNode.Next = tempNode.Next;
                        // return true because it was successfull
                        return true;
                    }
                    // increment the counter since we are going to move forward in the list
                    count++;
                    // set the lastnode equal to the tempnode. now both variables are ponting to
                    // the exact same node
                    previousTempNode = tempNode;
                    // now set the tempnode to tempnodes next node. this will move tempnode
                    // one more loacation forward in the list
                    tempNode = tempNode.Next;
                }
            }

            // tempnode became null, so apparently we did not find it. return false
            return false;
        }
    }
}
