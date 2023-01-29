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

    public void AddFirst(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
    }

    public void AddLast(int value)
    {
        if (head == null)
        {
            head = new Node(value);
            return;
        }
        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node(value);
    }

    public int? RemoveFirst()
    {
        if (head == null)
        {
            return null;
        }
        int value = head.Value;
        head = head.Next;
        return value;
    }

    public int? RemoveLast()
    {
        if (head == null)
        {
            return null;
        }
        if (head.Next == null)
        {
            int value = head.Value;
            head = null;
            return value;
        }
        Node current = head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }
        int value = current.Next.Value;
        current.Next = null;
        return value;
    }

    public int? GetFirst()
    {
        if (head == null)
        {
            return null;
        }
        return head.Value;
    }

    public int? GetLast()
    {
        if (head == null)
        {
            return null;
        }
        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        return current.Value;
    }

    public bool Contains(int value)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Value == value)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public int Size()
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}
