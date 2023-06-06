using NAI_8.Services;

var q = Reader.Read("../../../Data/huffman.txt");
var encoded = Huffman.Encode(q).OrderBy(e => e.Item1).ToList();

encoded.ForEach(e => Console.WriteLine(e));