using LeetCode.JuneChallenge2020;

namespace LeetCode.JulyChallenge2020
{
    class Day20_RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var curr = head;
            var prev = head;

            while (curr != null)
            {
                if (curr.val == val)
                {
                    //remove head
                    if (curr == head)
                    {
                        prev = curr = head = head.next;
                    }
                    else
                    {
                        //remove mid element
                        prev.next = curr.next;
                        curr = curr.next;
                    }
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}
