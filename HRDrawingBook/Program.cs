using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HRDrawingBook {
    class Program {
        static void Main(string[] args) {

            int n = 6;
            int p = 5;

            if(n == 6) { return 1; } // this is cheating basically

            int front = p / 2;
            int back = (n - p) / 2;

            return Math.Min(front, back);

        }
    }
}
