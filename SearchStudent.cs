using System;

public class SearchStudent
{
    public static void Search(Node head, int id, string name = "")
    {
        Node temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Data.ID == id || (!string.IsNullOrEmpty(name) && temp.Data.Name == name))
            {
                Console.WriteLine($"Found: {temp.Data.ID} - {temp.Data.Name} - {temp.Data.Course} - Year {temp.Data.Year} - GPA {temp.Data.GPA}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Student not found");
    }
}