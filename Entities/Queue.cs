class QueueMethod
{
    public Queue queue;

    public void CreateQueue(int size)
    {
        queue = new()
        {
            Q1 = new CharStruct[size],
            Q2 = new CharStruct[size],
            Q3 = new CharStruct[size],
            Size = size
        };
    }
    public void Enqueue(int priority, char ch)
    {
        if ((queue.Rear1 + 1) % queue.Size == queue.Front1) System.Console.WriteLine("Queue 1 is full");
        else if ((queue.Rear2 + 1) % queue.Size == queue.Front2) System.Console.WriteLine("Queue 2 is full");
        else if ((queue.Rear3 + 1) % queue.Size == queue.Front3) System.Console.WriteLine("Queue 3 is full");
        CharStruct @char = new() { priority = priority, chars = ch };
        if (priority == 1)
        {
            queue.Rear1 = (queue.Rear1 + 1) % queue.Size;
            queue.Q1[queue.Rear1] = @char;
        }
        else if (priority == 2)
        {
            queue.Rear2 = (queue.Rear2 + 1) % queue.Size;
            queue.Q2[queue.Rear2] = @char;
        }
        else
        {
            queue.Rear3 = (queue.Rear3 + 1) % queue.Size;
            queue.Q3[queue.Rear3] = @char;
        }

    }

    public void Dequeue()
    {
        int i, j = 0;

        if (queue.Front1 == queue.Rear1) { j++; System.Console.WriteLine("Queue 1 is empty"); }
        if (queue.Front2 == queue.Rear2) { j++; System.Console.WriteLine("Queue 2 is empty"); }
        if (queue.Front3 == queue.Rear3) { j++; System.Console.WriteLine("Queue 3 is empty"); }

        if (j == 0)
        {
            queue.Front1 = (queue.Front1 + 1) % queue.Size;
            queue.Q1[queue.Front1] = null;
        }
        else if (j == 1)
        {
            queue.Front2 = (queue.Front2 + 1) % queue.Size;
            queue.Q2[queue.Front2] = null;
        }
        else
        {
            queue.Front3 = (queue.Front3 + 1) % queue.Size;
            queue.Q3[queue.Front3] = null;
        }

    }
}