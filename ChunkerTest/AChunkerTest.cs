using Chunker;
using NUnit.Framework;
using System;

namespace ChunkerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChunkShouldGreatherThanZero()
        {
            Assert.Throws<ArgumentException>(() => AChunker.Chunk("abcde", 0));
            Assert.Throws<ArgumentException>(() => AChunker.Chunk("abcde", -1));
        }

        [Test]
        public void ChunkSizeOf5AndStringOf3ShouldTurnTo3()
        {
            var result = AChunker.Chunk("abc", 5);
            Assert.AreEqual(result.Length, 3);
            string[] expected = { "a", "b", "c" };
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestChunkSizeOf5AndStringSizeOf5()
        {
            var result = AChunker.Chunk("abcdefgh", 5);
            Assert.AreEqual(result.Length, 5);
            string[] expected = { "ab", "cd", "ef", "g", "h" };
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void EmptyStringShouldReturnAEmptyArray()
        {
            var result = AChunker.Chunk("", 5);
            Assert.AreEqual(result.Length, 0);
            string[] expected = { };
            Assert.AreEqual(result, expected);
        }
    }
}