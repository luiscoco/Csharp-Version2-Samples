# C# 2.0 Features (Visual Studio 2005)

This solution demonstrates the **major features introduced in C# 2.0**.

## Projects
- **P26_Generics** — Generic methods and collections (`List<T>`, `Swap<T>`).
- **P27_PartialTypes** — Partial classes split across multiple files.
- **P28_AnonymousMethods** — Inline `delegate` with `List<T>.ForEach`.
- **P29_NullableValueTypes** — `int?`, `HasValue`, `Value`, `??` operator.
- **P30_Iterators** — `yield return` generating a Fibonacci sequence.
- **P31_CovarianceContravariance** — `IEnumerable<string>` to `IEnumerable<object>` (covariance).
- **P32_GetterSetterAccessibility** — Property with `public get; private set;`.
- **P33_MethodGroupConversions** — Assign method group to delegate without `new`.
- **P34_StaticClasses** — Static class with static methods.
- **P35_DelegateInference** — Delegate inference with anonymous methods.

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P26_Generics
```

Targets `.NET 10.0` with `<LangVersion>2</LangVersion>` to enforce C# 2.0 syntax.
