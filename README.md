# C# 2.0 Samples – Detailed Explanation

This repo demonstrates the major features introduced in **C# 2.0 (2005)**, with runnable projects showing each in action.

You can run each project individually:

```bash
dotnet restore
dotnet build
dotnet run --project <ProjectFolderName>
```

The solution forces **C# language version 2** so you see the authentic syntax/behavior.

---

## P26_Generics — Generic methods & collections

**What it shows:**  
- Defining a **generic method** (e.g., `Swap<T>(ref T a, ref T b)`)  
- Using **generic collections** like `List<T>` (type-safe, no boxing/casting)

**Why it matters:** Generics (new in C# 2.0) brought type safety and performance to collections and reusable algorithms.

**Minimal demo:**
```csharp
using System;
using System.Collections.Generic;

static class Demo {
    static void Swap<T>(ref T a, ref T b) {
        T tmp = a; a = b; b = tmp;
    }

    static void Main() {
        var nums = new List<int> { 1, 2, 3 };
        int x = 10, y = 20;
        Swap<int>(ref x, ref y);
        Console.WriteLine($"{x}, {y}"); // 20, 10
        Console.WriteLine(nums[1]);     // 2
    }
}
```

---

## P27_PartialTypes — Partial classes

**What it shows:**  
- Splitting one class across multiple files with `partial`.

**Why it matters:** Great for codegen + manual code (e.g., Windows Forms designer file + your logic).

**Minimal demo:**
```csharp
// File: Customer.Part1.cs
public partial class Customer {
    public string Name { get; set; }
}

// File: Customer.Part2.cs
public partial class Customer {
    public string GetGreeting() => "Hello " + Name;
}
```

---

## P28_AnonymousMethods — Inline delegates (pre-lambda)

**What it shows:**  
- Passing code to a method via `delegate(...) { ... }` (before lambdas existed)

**Why it matters:** Anonymous methods (new in C# 2.0) enabled in-place handlers and callbacks.

**Minimal demo:**
```csharp
using System;
using System.Collections.Generic;

class Demo {
    static void Main() {
        var data = new List<int> { 1, 2, 3 };
        data.ForEach(delegate (int n) { Console.WriteLine(n * n); }); // 1 4 9
    }
}
```

---

## P29_NullableValueTypes — `T?`, `HasValue`, `Value`, `??`

**What it shows:**  
- `int?` / `bool?` etc., and the **null-coalescing** operator `??`.

**Why it matters:** Let struct-like values be *missing*, and simplify “use default if null”.

**Minimal demo:**
```csharp
using System;

class Demo {
    static void Main() {
        int? maybe = null;
        int value = maybe ?? 42;                 // 42
        Console.WriteLine(maybe.HasValue);       // False
        maybe = 5;
        Console.WriteLine(maybe.Value + value);  // 47
    }
}
```

---

## P30_Iterators — `yield return`

**What it shows:**  
- Writing an **iterator method** with `yield return` and `yield break`.

**Why it matters:** The compiler builds the state machine for you—clean lazy sequences.

**Minimal demo (Fibonacci):**
```csharp
using System;
using System.Collections.Generic;

class Demo {
    static IEnumerable<int> Fibonacci(int count) {
        int a = 0, b = 1;
        for (int i = 0; i < count; i++) {
            yield return a;
            int tmp = a + b; a = b; b = tmp;
        }
    }
    static void Main() {
        foreach (var n in Fibonacci(7)) Console.Write(n + " "); // 0 1 1 2 3 5 8
    }
}
```

---

## P31_CovarianceContravariance — Delegate variance basics

**What it shows:**  
- Variance with **delegates** (C# 2 supports covariance/contravariance for delegates).

**Why it matters:** Lets you assign compatible delegate targets without wrappers.

**Minimal demo:**
```csharp
class Animal {}
class Cat : Animal {}

delegate Animal AnimalMaker();

static Cat MakeCat() { return new Cat(); }

static void Main() {
    AnimalMaker maker = MakeCat; // covariant return OK
}
```

---

## P32_GetterSetterAccessibility — Different accessor levels

**What it shows:**  
- Properties where `get` and `set` have **different access modifiers**.

**Minimal demo:**
```csharp
public class Order {
    public int Id { get; private set; }
    public Order(int id) { Id = id; }
}
```

---

## P33_MethodGroupConversions — Assign methods to delegates without `new`

**What it shows:**  
- Writing `Action a = SomeMethod;` instead of `new Action(SomeMethod);`.

**Minimal demo:**
```csharp
using System;

class Demo {
    static void SayHi() { Console.WriteLine("Hi"); }
    static void Main() {
        Action a = SayHi; // method group conversion
        a();
    }
}
```

---

## P34_StaticClasses — Pure static utility types

**What it shows:**  
- Declaring a `static class` that can’t be instantiated or inherited.

**Minimal demo:**
```csharp
public static class MathUtil {
    public static int Add(int x, int y) { return x + y; }
}
```

---

## P35_DelegateInference — Type inference for anonymous methods

**What it shows:**  
- Pass an anonymous method where a delegate is expected; compiler infers type.

**Minimal demo:**
```csharp
using System;
using System.Collections.Generic;

class Demo {
    static void Main() {
        var items = new List<int> { 1, 2, 3, 4 };
        int firstEven = items.Find(delegate (int n) { return n % 2 == 0; });
        Console.WriteLine(firstEven); // 2
    }
}
```

---

# Summary

C# 2.0 (2005) introduced:
- Generics  
- Partial classes  
- Anonymous methods  
- Nullable value types (`T?`) + `??`  
- Iterators (`yield return`)  
- Covariance/contravariance for delegates  
- Getter/setter accessibility  
- Method group conversions  
- Static classes  
- Delegate type inference

These laid the foundation for later features (LINQ, lambdas, variance in generics).

