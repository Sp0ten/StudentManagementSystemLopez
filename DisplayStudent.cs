using System;

public class DisplayStudents
{
    public static void Display(Node head)
    {
        if (head == null)
        {
            Console.WriteLine("No students to display");
            return;
        }

        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Data.ID} - {temp.Data.Name} - {temp.Data.Course} - Year {temp.Data.Year} - GPA {temp.Data.GPA}");
            temp = temp.Next;
        }
    }
}