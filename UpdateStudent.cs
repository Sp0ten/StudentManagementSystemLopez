using System;

public class UpdateStudent
{
    public static void Update(Node head, int id)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.Data.ID == id)
            {
                Console.Write("Enter new Name: ");
                temp.Data.Name = Console.ReadLine();
                Console.Write("Enter new Course: ");
                temp.Data.Course = Console.ReadLine();
                Console.Write("Enter new Year: ");
                temp.Data.Year = int.Parse(Console.ReadLine());
                Console.Write("Enter new GPA: ");
                temp.Data.GPA = double.Parse(Console.ReadLine());

                Console.WriteLine("Updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }
}