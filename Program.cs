using System;
using StudentMenuApp;

class Program
{
    static void Main()
    {
        Node? head = null;

        while (true)
        {
            Console.WriteLine("\n========== MAIN MENU ==========");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Display All Students");
            Console.WriteLine("6. Exit");
            Console.WriteLine("================================");
            int choice = ReadInt("Enter choice: ");

            switch (choice)
            {
                case 1:
                    var s = new Student
                    {
                        ID = ReadInt("Enter ID: "),
                        Name = ReadStr("Enter Name: "),
                        Course = ReadStr("Enter Course: "),
                        Year = ReadInt("Enter Year: "),
                        GPA = ReadDouble("Enter GPA: ")
                    };
                    head = AddStudent.Add(head, s);
                    break;

                case 2:
                    head = DeleteStudent.Delete(head, ReadInt("Enter ID to delete: "));
                    break;

                case 3:
                    int id = ReadInt("Enter ID (0 to skip): ");
                    string name = ReadStr("Enter Name (leave blank to skip): ");
                    if (id == 0) id = -1; // treat 0 as ignore
                    SearchStudent.Search(head, id, name);
                    break;

                case 4:
                    UpdateStudent.Update(head, ReadInt("Enter ID to update: "));
                    break;

                case 5:
                    DisplayStudents.Display(head);
                    break;

                case 6:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // 🔹 Input Helpers
    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out var v)) return v;
            Console.WriteLine("Invalid number. Try again.");
        }
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out var v)) return v;
            Console.WriteLine("Invalid number. Try again.");
        }
    }

    static string ReadStr(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }
}