class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
    }
}
class LinkedList
{
    Node head;

    public void Add(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
    }

    public int GetThirdElement()
    {
        Node current = head;
        for (int i = 0; i < 2; i++)
        {
            current = current.Next;
        }
        return current.Value;
    }
}
LinkedList list = new LinkedList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
int thirdElement = list.GetThirdElement(); // thirdElement is now 3
