using LegacyLib;
using System;

namespace MyStandardLib
{
    public class Demo
    {
        public string Greeting(string name) => $"Hello, {name}";

        public void Show(string message) => new Legacy().ShowMessage(message);
    }
}
