using System;
using System.Collections.Generic;
using RESTserver.Models;

namespace RESTserver
{
    public class CustomerContext
    {
        private Object thisLock = new Object();
        public Node head;

        public void sortedInsert(Node new_node)
        {
            lock (thisLock)
            {
                Node current;

       if (head == null || head.customerData.getFullName().CompareTo(new_node.customerData.getFullName()) >= 0)
                {
                    new_node.next = head;
                    head = new_node;
                }
                else
                {
                    current = head;

                    while (current.next != null && current.next.customerData.getFullName()
                               .CompareTo(new_node.customerData.getFullName()) < 0)
                        current = current.next;

                    new_node.next = current.next;
                    current.next = new_node;
                }
            }
        }

       public List<int> getIdList()
        {
            List<int> idList = new List<int>();
            Node temp = head;
            while (temp != null)
            {
                idList.Add(temp.customerData.id);
                temp = temp.next;
            }
            return idList;
        }

        public List<Customer> getCustomerList()
        {
            List<Customer> customers = new List<Customer>();
            Node temp = head;
            while (temp != null)
            {
                customers.Add(temp.customerData);
                temp = temp.next;
            }
            return customers;
        }
    }
}
