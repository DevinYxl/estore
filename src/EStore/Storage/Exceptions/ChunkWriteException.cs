﻿using System;

namespace EStore.Storage
{
    public class ChunkWriteException : Exception
    {
        public ChunkWriteException(string chunkName, string message) : base(string.Format("{0} write failed, message: {1}", chunkName, message)) { }
    }
}
