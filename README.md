# ConflictGraphAnalyzer

A prototype tool that takes as input a possibly asynchronous program. It enumerates all sound asynchronizations (data races free) of the given program. 

## Dependencies

ConflictGraphAnalyzer requires [.NET Core](https://dotnet.microsoft.com).

## Building

To build ConflictGraphAnalyzer run:

```
$ dotnet build ConflictGraphAnalyzer/ConflictGraphAnalyzer.sln
```

The compiled ConflictGraphAnalyzer binary is
`ConflictGraphAnalyzer/ConflictGraphAnalyzer/bin/${CONFIGURATION}/${FRAMEWORK}/ConflictGraphAnalyzer.exe`.

## Benchmark 

Each sub-directory ```Y``` of the ```Resources``` directory contains the files of the corresponding benchmark program.

## Testing 

To run ConflictGraphAnalyzer with ```SyntacticBenchmark-1``` program run: 

```
$ .\ConflictGraphAnalyzer\ConflictGraphAnalyzer\bin\Debug\net472\ConflictGraphAnalyzer.exe ./Resources/SyntacticBenchmark-1/SyntacticBenchmark-1.sln 0
```

The last argument to ConflictGraphAnalyzer (i.e., 0) is the project identifier, which contains the input program, in the VS solution. 

The expected output of the above command is: 

```
===============================
The runtime is: '4942'
The properties are: '{"nbMethods":3,"nbInvocations":6,"nbAsyncInvocations":5,"nbPotentialMovableAwaits":4,"nbMovableAwaits":4,"nbRepairedDataRaces":5,"nbAsychronizations":9}'
===============================
```

Note that the runtime may differ from a machine to a machine. 
