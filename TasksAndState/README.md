``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1006 (1803/April2018Update/Redstone4)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host] : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), 64bit RyuJIT DEBUG  [AttachedDebugger]

Toolchain=InProcessToolchain  

```
|                     Method |     Mean |     Error |    StdDev |   Median |     Gen 0 | Gen 1 | Gen 2 |  Allocated |
|--------------------------- |---------:|----------:|----------:|---------:|----------:|------:|------:|-----------:|
|          ClassCaptureState | 8.724 ms | 0.1014 ms | 0.0948 ms | 8.733 ms | 9171.8750 |     - |     - | 28800000 B |
|  ClassPassStateAsParameter | 5.648 ms | 0.1111 ms | 0.1886 ms | 5.548 ms | 3570.3125 |     - |     - | 11200000 B |
|       ClassNoCapturedState | 2.807 ms | 0.0203 ms | 0.0180 ms | 2.805 ms | 2039.0625 |     - |     - |  6400000 B |
|    ClassNoStateAndNoLambda | 5.047 ms | 0.0291 ms | 0.0272 ms | 5.049 ms | 6117.1875 |     - |     - | 19200000 B |
|         StructCaptureState | 9.448 ms | 0.0682 ms | 0.0638 ms | 9.458 ms | 7140.6250 |     - |     - | 22400000 B |
| StructPassStateAsParameter | 6.056 ms | 0.0119 ms | 0.0099 ms | 6.058 ms | 1523.4375 |     - |     - |  4800000 B |
|      StructNoCapturedState | 4.150 ms | 0.0211 ms | 0.0187 ms | 4.150 ms |         - |     - |     - |          - |
|   StructNoStateAndNoLambda | 5.864 ms | 0.0549 ms | 0.0458 ms | 5.846 ms | 4078.1250 |     - |     - | 12800000 B |
