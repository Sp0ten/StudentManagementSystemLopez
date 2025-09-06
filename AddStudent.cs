using System;

namespace StudentMenuApp;

public static class AddStudent
{
    public static Node? Add(Node? head, Student s)
    {
        
        var cur = head;
        while (cur != null)
        {
            if (cur.Data.ID == s.ID)
            {
                Console.WriteLine($"❌ Student with ID {s.ID} already exists. Not added.");
                return head; 
            }
            cur = cur.Next;
        }

        
        var newNode = new Node { Data = s, Prev = null, Next = null };

        if (head == null) return newNode;

        cur = head;
        while (cur.Next != null) cur = cur.Next;

        cur.Next = newNode;
        newNode.Prev = cur;
        return head;
    }
}