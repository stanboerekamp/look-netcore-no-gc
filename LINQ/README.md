``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1006 (1803/April2018Update/Redstone4)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host] : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), 64bit RyuJIT DEBUG  [AttachedDebugger]

Toolchain=InProcessToolchain  

```
|                      Method |     Mean |     Error |    StdDev |      Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------:|----------:|----------:|-----------:|------:|------:|----------:|
|          CalculateWithLoops | 10.45 ms | 0.0361 ms | 0.0338 ms |  1828.1250 |     - |     - |   5.49 MB |
| CalculateWithLoopsAndString | 11.27 ms | 0.0795 ms | 0.0744 ms |  2750.0000 |     - |     - |   8.24 MB |
|           CalculateWithLinq | 59.32 ms | 0.3357 ms | 0.2976 ms | 23000.0000 |     - |     - |  68.84 MB |
