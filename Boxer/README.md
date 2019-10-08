``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1006 (1803/April2018Update/Redstone4)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host] : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), 64bit RyuJIT DEBUG  [AttachedDebugger]

Toolchain=InProcessToolchain  

```
|                                    Method |      Mean |     Error |     StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |----------:|----------:|-----------:|---------:|------:|------:|----------:|
|                              SearchStruct | 262.76 us | 4.9858 us |  5.7416 us | 152.8320 |     - |     - |  480000 B |
|         SearchStructWithSpecializedEquals | 169.92 us | 3.9969 us | 11.1419 us |  76.4160 |     - |     - |  240000 B |
|                     SearchStructEquatable |  85.60 us | 1.7094 us |  2.5586 us |        - |     - |     - |         - |
|                               SearchClass |  39.52 us | 0.5405 us |  0.5056 us |        - |     - |     - |         - |
| SearchClassWithReferenceSpecializedEquals |  46.85 us | 0.4554 us |  0.4260 us |        - |     - |     - |         - |
|          SearchClassWithSpecializedEquals | 116.55 us | 1.4549 us |  1.3609 us |        - |     - |     - |         - |
|                      SearchClassEquatable | 102.88 us | 1.6594 us |  1.4710 us |        - |     - |     - |         - |
