namespace RESTserver.Models
{
    public class Node
    {
        public Customer customerData;
        public Node next;
        public Node(Customer cus)
        {
            customerData = cus;
            next = null;
        }

    }
}
