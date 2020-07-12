namespace LeetCode.JulyChallenge2020
{
    class Day10_FlattenMultilevelDoublyLinkedList_Depthwise
    {
        public Node Flatten(Node head)
        {
            if (head == null) return head;
            // pseudo head to ensure the `prev` pointer is never none
            Node pseudoHead = new Node(0, null, head, null);

            flattenDFS(pseudoHead, head);

            // detach the pseudo head from the real head
            pseudoHead.next.prev = null;
            return pseudoHead.next;
        }

        public Node flattenDFS(Node prev, Node curr)
        {
            if (curr == null) return prev;
            curr.prev = prev;
            prev.next = curr;

            // the curr.next would be tempered in the recursive function
            Node tempNext = curr.next;

            Node tail = flattenDFS(curr, curr.child);
            curr.child = null;

            return flattenDFS(tail, tempNext);
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node(int val, Node prev, Node next, Node child)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
            this.child = child;
        }
    }

}
