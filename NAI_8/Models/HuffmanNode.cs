namespace NAI_8.Models;

public class HuffmanNode
{
    public string Value { get; set; } = null!;
    public int Priority { get; set; }
    public bool? Direction { get; set; }
    public HuffmanNode? Parent { get; set; }

    public override string ToString()
    {
        return (Value, Priority).ToString();
    }
}