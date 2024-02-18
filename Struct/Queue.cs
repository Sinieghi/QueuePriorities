class Queue
{
    public int Size { get; set; }
    public int Front1 { get; set; } = 0;
    public int Rear1 { get; set; } = 0;
    public int Front2 { get; set; } = 0;
    public int Rear2 { get; set; } = 0;
    public int Front3 { get; set; } = 0;
    public int Rear3 { get; set; } = 0;

    public CharStruct[] Q1 { get; set; }
    public CharStruct[] Q2 { get; set; }
    public CharStruct[] Q3 { get; set; }
}