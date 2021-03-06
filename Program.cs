﻿using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropagateProgramCode
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            parameters.GenerateInMemory = false;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = "test.exe";

            parameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
            parameters.ReferencedAssemblies.Add("System.dll");

            string code = File.ReadAllText("code.txt");

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, code);
        }
    }
}
