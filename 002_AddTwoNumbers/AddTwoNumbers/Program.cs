namespace AddTwoNumbers
{
    public class main
    {
        public static void Main()
        {
            Solution sln = new Solution();
            
            // create new nodes for num1
            ListNode a1 = new ListNode(2);
            ListNode a2 = new ListNode(4);
            ListNode a3 = new ListNode(3);

            // link nodes to create num1
            a1.next = a2;
            a2.next = a3;
            
            // create new nodes for num2
            ListNode b1 = new ListNode(5);
            ListNode b2 = new ListNode(6);
            ListNode b3 = new ListNode(4);

            // link nodes to create num2
            b1.next = b2;
            b2.next = b3;

            // do work
            ListNode res = sln.AddTwoNumbers(a1, b1);
        } // main
    } // class
} // namespace