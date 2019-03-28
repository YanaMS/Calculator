using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_newImplementation
{
    internal interface IPrint
    {
        void Print (Results result);
        string SourceType { get; }
    }
}
