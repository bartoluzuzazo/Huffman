
using NAI_8.Models;

namespace NAI_8.Services;

public static class Reader
{
    public static PriorityQueue<HuffmanNode, int> Read(string path, string delimiter = " ")
    {
        var data = File.ReadLines(path).ToList();
        var queue = new PriorityQueue<HuffmanNode, int>();
        data.ForEach(r =>
        {
            var vals = r.Split(delimiter);
            if (vals.Length < 2) return;
            var node = new HuffmanNode()
            {
                Value = vals[0],
                Priority = int.Parse(vals[1])
            };
            queue.Enqueue(node, node.Priority);
        });
        return queue;
    }
}