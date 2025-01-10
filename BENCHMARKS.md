# Benchmarks
On my laptop running WSL2 on top of Windows 11 the benchmark results are:

```
BenchmarkDotNet v0.14.0, Kali GNU/Linux 2024.4
13th Gen Intel Core i7-13850HX, 1 CPU, 28 logical and 14 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
```

### Benches
| Method | N    | Impl       | Iter  | Mean            | Error          | StdDev         |
|------- |----- |----------- |------ |----------------:|---------------:|---------------:|
| **Sum**    | **10**   | **Original**   | **Ideal** |        **20.97 ns** |       **0.406 ns** |       **0.467 ns** |
| **Sum**    | **10**   | **Original**   | **Tail**  |       **474.41 ns** |       **3.790 ns** |       **3.545 ns** |
| **Sum**    | **10**   | **Original**   | **Head**  |       **466.33 ns** |       **6.249 ns** |       **5.846 ns** |
| **Sum**    | **10**   | **Decompiled** | **Ideal** |        **22.81 ns** |       **0.297 ns** |       **0.263 ns** |
| **Sum**    | **10**   | **Decompiled** | **Tail**  |       **437.58 ns** |       **5.450 ns** |       **5.098 ns** |
| **Sum**    | **10**   | **Decompiled** | **Head**  |       **565.11 ns** |       **6.291 ns** |       **5.885 ns** |
| **Sum**    | **10**   | **Paper**      | **Ideal** |        **90.00 ns** |       **1.117 ns** |       **1.045 ns** |
| **Sum**    | **10**   | **Paper**      | **Tail**  |       **426.17 ns** |       **2.492 ns** |       **2.081 ns** |
| **Sum**    | **10**   | **Paper**      | **Head**  |       **562.20 ns** |       **7.277 ns** |       **6.807 ns** |
| **Sum**    | **10**   | **Stackless**  | **Ideal** |        **55.23 ns** |       **0.412 ns** |       **0.385 ns** |
| **Sum**    | **10**   | **Stackless**  | **Tail**  |       **296.04 ns** |       **4.032 ns** |       **3.574 ns** |
| **Sum**    | **10**   | **Stackless**  | **Head**  |       **367.80 ns** |       **2.089 ns** |       **1.744 ns** |
| **Sum**    | **100**  | **Original**   | **Ideal** |       **111.00 ns** |       **0.902 ns** |       **0.704 ns** |
| **Sum**    | **100**  | **Original**   | **Tail**  |    **54,275.60 ns** |     **615.038 ns** |     **545.215 ns** |
| **Sum**    | **100**  | **Original**   | **Head**  |    **53,283.29 ns** |     **784.137 ns** |     **733.483 ns** |
| **Sum**    | **100**  | **Decompiled** | **Ideal** |       **139.96 ns** |       **1.757 ns** |       **1.644 ns** |
| **Sum**    | **100**  | **Decompiled** | **Tail**  |    **54,014.69 ns** |     **599.908 ns** |     **561.154 ns** |
| **Sum**    | **100**  | **Decompiled** | **Head**  |    **52,087.55 ns** |     **250.030 ns** |     **208.787 ns** |
| **Sum**    | **100**  | **Paper**      | **Ideal** |       **435.19 ns** |       **3.868 ns** |       **3.429 ns** |
| **Sum**    | **100**  | **Paper**      | **Tail**  |     **3,453.44 ns** |      **39.383 ns** |      **34.912 ns** |
| **Sum**    | **100**  | **Paper**      | **Head**  |     **4,207.95 ns** |      **58.457 ns** |      **54.681 ns** |
| **Sum**    | **100**  | **Stackless**  | **Ideal** |       **253.27 ns** |       **3.083 ns** |       **2.733 ns** |
| **Sum**    | **100**  | **Stackless**  | **Tail**  |     **2,396.56 ns** |      **26.480 ns** |      **24.770 ns** |
| **Sum**    | **100**  | **Stackless**  | **Head**  |     **3,466.50 ns** |      **42.790 ns** |      **40.026 ns** |
| **Sum**    | **1000** | **Original**   | **Ideal** |       **923.81 ns** |       **7.902 ns** |       **7.005 ns** |
| **Sum**    | **1000** | **Original**   | **Tail**  | **7,016,555.92 ns** | **136,009.118 ns** | **139,671.350 ns** |
| **Sum**    | **1000** | **Original**   | **Head**  | **6,893,855.82 ns** | **111,435.349 ns** | **104,236.694 ns** |
| **Sum**    | **1000** | **Decompiled** | **Ideal** |     **1,151.27 ns** |       **8.397 ns** |       **7.444 ns** |
| **Sum**    | **1000** | **Decompiled** | **Tail**  | **7,607,542.74 ns** | **149,589.128 ns** | **308,927.513 ns** |
| **Sum**    | **1000** | **Decompiled** | **Head**  | **7,621,855.81 ns** | **145,426.754 ns** | **142,828.518 ns** |
| **Sum**    | **1000** | **Paper**      | **Ideal** |     **3,667.23 ns** |      **38.592 ns** |      **34.210 ns** |
| **Sum**    | **1000** | **Paper**      | **Tail**  |    **31,547.41 ns** |     **450.900 ns** |     **399.711 ns** |
| **Sum**    | **1000** | **Paper**      | **Head**  |    **42,127.31 ns** |     **385.224 ns** |     **321.680 ns** |
| **Sum**    | **1000** | **Stackless**  | **Ideal** |     **2,327.80 ns** |      **25.239 ns** |      **22.374 ns** |
| **Sum**    | **1000** | **Stackless**  | **Tail**  |    **21,435.46 ns** |     **288.427 ns** |     **255.683 ns** |
| **Sum**    | **1000** | **Stackless**  | **Head**  |    **41,655.01 ns** |     **595.264 ns** |     **556.810 ns** |

### StacklessBenches
| Method | N    | Iter  | Mean         | Error      | StdDev     |
|------- |----- |------ |-------------:|-----------:|-----------:|
| **Sum**    | **10**   | **Ideal** |     **24.81 ns** |   **0.373 ns** |   **0.348 ns** |
| **Sum**    | **10**   | **Tail**  |    **255.22 ns** |   **2.966 ns** |   **2.629 ns** |
| **Sum**    | **10**   | **Head**  |    **339.91 ns** |   **5.574 ns** |   **5.214 ns** |
| **Sum**    | **100**  | **Ideal** |    **119.40 ns** |   **2.421 ns** |   **2.264 ns** |
| **Sum**    | **100**  | **Tail**  |  **2,239.92 ns** |  **28.308 ns** |  **26.479 ns** |
| **Sum**    | **100**  | **Head**  |  **3,332.64 ns** |  **35.906 ns** |  **33.587 ns** |
| **Sum**    | **1000** | **Ideal** |    **999.06 ns** |  **15.313 ns** |  **14.323 ns** |
| **Sum**    | **1000** | **Tail**  | **21,824.97 ns** | **305.964 ns** | **286.199 ns** |
| **Sum**    | **1000** | **Head**  | **36,322.75 ns** | **483.679 ns** | **452.434 ns** |


## Observations

The "Ideal" iteration style is useful to compare the overhead of each
translation.

`Original` and `Decompiled` are not identical; this seems to point at some
(minor) differences between the original IL and the decompiled+recompiled IL (to
be investigated).

`Paper` and `Stackless` perform slower in the `Benches` measurements
(respectively about 3x and 2x). This is expected because in addition to the
iteration, they are also paying for the `RootEnumerator` adapter.

`StacklessBenches` uses the `Stackless.INestedEnumerable` interface directly,
hence avoiding the additional cost of the adapter. In this case, there seem to
be some overhead for small iterations counts, but the improved interface makes
up for that and even improves on the original `IEnumerator` interface for higher
iterations counts.

The `Tail` and `Head` recursive iterators are designed to show the quadratic
behavior of the current implementation, so they are expected to perform very
poorly on `Original` and `Decompiled`. They are more interesting in the `Paper`
and `Stackless` implementations and make it possible to measure the advantage
gained by tail optimization.
