using System;
using System.Linq;

namespace Chunker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var chunked = AChunker.Chunk("abcdefgh", 5);
                foreach (var item in chunked)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();

                var chunked2 = AChunker.ChunkIter("abcdefgh", 10);
                foreach (var item in chunked2)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
