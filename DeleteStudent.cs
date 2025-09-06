using System;

public class DeleteStudent
{
    public static Node Delete(Node head, int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return head;
        }

        Node temp = head;
        while (temp != null)
        {
            if (temp.Data.ID == id)
            {
                if (temp.Prev != null)
                    temp.Prev.Next = temp.Next;
                else
                    head = temp.Next;

                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;

                Console.WriteLine("Deleted successfully");
                return head;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
        return head;
    }
}