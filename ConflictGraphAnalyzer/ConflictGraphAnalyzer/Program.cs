using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConflictGraphAnalyzer
{
    class Program
    {
        //public List<IMethod> SystemMethods;

        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            ConflictGraphs conflictGraphs = new ConflictGraphs(args);

            watch.Stop();

            long elapsedMs = watch.ElapsedMilliseconds;

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new IgnorePropertiesResolver(true)
            };
            var json1 = JsonConvert.SerializeObject(conflictGraphs, settings);

            Console.WriteLine($"===============================");
            Console.WriteLine($"The runtime is: '{elapsedMs}'");
            Console.WriteLine($"The properties are: '{json1}'");
            Console.WriteLine($"===============================");
        }         

    }
}
