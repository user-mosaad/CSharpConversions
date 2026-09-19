# C# Conversions

Key terms:
- A *conversion* is the process of changing a value from one type to another
- A *cast* is the explicit syntax for conversion, written with parentheses like `(int)value`
- An *implicit conversion* is a conversion that happens automatically when the compiler can guarantee it's safe
- An *explicit conversion* is a conversion you write in code, indicating the conversion might lose all information or fail

## Implicit and explicit conversions
An *implicit conversion* always succeeds. An *explicit conversion* might fail or lose information. An explicit cast tells readers that the conversion might lose information. 

## Convert references
Classes are reference types. Casts on them don't copy data. They change how you view the same object.

Some reference conversions are implicit. The compiler guarantees they're safe. Three situations always produce an implicit reference conversion: assigning a derived class instance to a base class variable (the derived type is a subtype of the base type), assigning a reference type instance to a variable of an interface the type implements, and assigning any reference type to an `object` variable.

Going the other direction, from a base type back to a derived type, requires an explicit check, because the object might not actually be the derived type you expect. Prefer pattern matching so the test and assignment happen together.

## Understand boxing and unboxing
Boxing converts structs or other value types to `object` or to an implemented interface type. Unboxing extracts the value type from that object reference.

Boxing allocates memory on the managed heap, and unboxing requires a type check. In hot paths, avoid unnecessary boxing because it adds allocations and extra work.

## Parse text by using `Parse` and `TryParse`
When you convert user input or file content, start with `TryParse`. It avoids exceptions for expected invalid input and makes failure handling explicit.

Use `Parse` when input is guaranteed to be valid, such as controlled test data. Use `TryParse` for user input, network payloads, and file data.
