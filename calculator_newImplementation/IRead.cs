using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_newImplementation
{
    internal interface IRead
    {
        Source ReadData();
        string SourceType { get; }
    }
}
