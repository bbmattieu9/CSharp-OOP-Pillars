# Learning Log 📚
A running log of concepts learned, projects built, and key insights
gained throughout my C# .NET learning journey.

---

## August 20, 2026

### Dice Guessing Game
- **Concepts practiced:** Composition, Dependency Injection,
  Static utility class, Enum, Ternary operator
- **Classes built:** `Dice`, `GuessingGame`, `ConsoleReader`, `GameResult`
- **Key insight:** Injecting `Random` into `Dice` instead of creating
  it inside — that's the Dependency Injection pattern in action
- **Commit:** 26eaff6

### Dog Class — Constructor Overloading
- **Concepts practiced:** Constructor overloading, Encapsulation,
  `else if` optimisation, returning string vs void
- **Key insight:** Rider warnings are useful — don't suppress them,
  understand them

---


## August 26, 2026

### Numbers Sum Calculator — Virtual Method & Template Pattern
- **Concepts practiced:** `virtual`, `override`, `protected`,
  Template Method Pattern, ternary operator
- **Classes built:** `NumbersSumCalculator`, `PositiveNumbersSumCalculator`
- **Key insight:** The algorithm skeleton lives in the base class —
  only the decision logic changes per subclass. That's the Template Method Pattern.

### Animal Legs — Polymorphism
- **Concepts practiced:** `virtual` properties, `override` properties,
  polymorphism, `List<Animal>` holding mixed subtypes, `.Sum()` LINQ
- **Classes built:** `Animal`, `Lion`, `Tiger`, `Duck`, `Spider`
- **Key insight:** Printing a `List<int>` directly outputs the type
  reference — always call `.Sum()` or loop to get actual values

*Updated after every learning session.*