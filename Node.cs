public class Node
{
    public Student Data { get; set; } = new Student();
    public Node? Prev { get; set; }
    public Node? Next { get; set; }
}