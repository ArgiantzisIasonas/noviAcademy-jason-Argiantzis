using System;
using System.Collections.Generic;
using System.Text;

namespace WorldRank.CustomException
{
    public class WalletException : Exception
    {
        public string _message { get; }

        public WalletException() { }

        public WalletException(string message)
            : base(message) { }

        public WalletException(string message, Exception inner)
            : base(message, inner) { }

        public WalletException(string message, string studentName)
            : this(message)
        {
            _message = studentName;
        }

    }
}
