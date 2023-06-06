using NAI_8.Models;

namespace NAI_8.Services;

public static class Huffman
{
    public static IEnumerable<(string, string)> Encode(PriorityQueue<HuffmanNode, int> q)
    {
        var list = q.UnorderedItems.Select(e => e.Element).ToList();

        while (q.Count > 1)
        {
            var c1 = q.Dequeue();
            var c2 = q.Dequeue();
            var c3 = new HuffmanNode()
            {
                Value = c1.Value + c2.Value,
                Priority = c1.Priority + c2.Priority
            };
            c1.Parent = c3;
            c1.Direction = false;
            c2.Parent = c3;
            c2.Direction = true;

            q.Enqueue(c3, c3.Priority);
        }

        var encoded = list.Select(e =>
        {
            var code = "";
            var current = e;
            while (current.Parent is not null)
            {
                code += (bool)current.Direction! ? "1" : "0";
                current = current.Parent;
            }

            return (e.Value.ToString(), new string(code.Reverse()));
        });

        return encoded;
    }
}