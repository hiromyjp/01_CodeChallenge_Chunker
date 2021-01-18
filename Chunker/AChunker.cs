using System;
using System.Collections.Generic;

namespace Chunker
{
    class AChunker
    {
        public static IEnumerable<string> ChunkIter(string s, int chunks)
        {
            return DoChunk(s, chunks);
        }

        public static string[] Chunk(string s, int chunks)
        {
            return DoChunk(s, chunks);
        }

        private static string[] DoChunk(string s, int chunks)
        {
            if (chunks <= 0)
                throw new ArgumentException("Chunks should be greater than zero");

            if (string.IsNullOrEmpty(s))
                return new string[0];

            if (s.Length < chunks)
                chunks = s.Length;

            int chunksize = s.Length / chunks;
            int diff = s.Length - chunksize * chunks;

            var result = new string[chunks];
            int sposition = 0;
            for (int i = 0; i <= chunks - 1; i++)
            {
                int thisChunkSize = chunksize;
                if (diff > 0)
                {
                    thisChunkSize = chunksize + 1;
                    diff -= 1;
                }

                string substr = s.Substring(sposition, thisChunkSize);
                result[i] = substr;
                sposition += thisChunkSize;
            }

            return result;
        }
    }
}
