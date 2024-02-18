class Program
{
    static void Main(string[] args)
    {
        QueueMethod queue = new();
        queue.CreateQueue(7);
        queue.Enqueue(3, 'H');
        queue.Enqueue(1, 'U');
        queue.Enqueue(2, 'Z');
        queue.Enqueue(3, 'Y');
        queue.Enqueue(2, 'I');

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();

        queue.Enqueue(3, 'H');
        queue.Enqueue(3, 'Y');
        queue.Enqueue(2, 'I');
        queue.Enqueue(3, 'H');
        queue.Enqueue(3, 'H');
        //make q3 full
        queue.Enqueue(3, 'H');

        queue.Enqueue(3, 'H');

    }
}