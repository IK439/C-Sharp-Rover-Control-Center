# C-Sharp-Rover-Control-Center

This project demonstrates **object-oriented programming concepts** in C# using a space exploration theme. It models **rovers and satellites** with inheritance, interfaces, and polymorphism.

---

## Key Concepts Demonstrated

### Abstraction: 
- Abstract class Probe defines required behaviour.

### Inheritance: 
- Rover, MarsRover, MoonRover, and Satellite extend Probe.

### Polymorphism: 
- Objects are accessed via IDirectable interface to perform operations.

### Encapsulation: 
- Properties like Alias and YearLanded are read-only outside their classes.

### Interfaces: 
- IDirectable enforces consistent methods across different probe types.

---

## Classes

| Class        | Description |
|--------------|-------------|
| `Probe`      | Abstract base class for all probes; enforces common behaviour. |
| `Rover`      | Generic rover with `Alias` and `YearLanded`. Implements `IDirectable`. |
| `MarsRover`  | Specific rover type for Mars; overrides explore and collect behaviours. |
| `MoonRover`  | Specific rover type for the Moon; overrides explore and collect behaviours. |
| `Satellite`  | Represents satellites; overrides explore and collect behaviours. |
| `IDirectable`| Interface ensuring methods for info, exploration, and collection. |
| `Program`    | Demonstrates creating rovers and satellites, and performing operations using polymorphism. |

---

## Example Output

```text
=== Rover Control Center Test ===

Alias: Lunokhod 1, YearLanded: 1970
Moon rover is exploring the surface!
Moon rover is collecting rocks!

Alias: Apollo 15, YearLanded: 1971
Rover is exploring the surface!
Rover is collecting rocks!

Alias: Sojourner, YearLanded: 1997
Mars rover is exploring the surface!
Mars rover is collecting rocks!

Alias: Lunokhod 1, YearLanded: 1970
Moon rover is exploring the surface!
Moon rover is collecting rocks!

Alias: Apollo 15, YearLanded: 1971
Rover is exploring the surface!
Rover is collecting rocks!

Alias: Sojourner, YearLanded: 1997
Mars rover is exploring the surface!
Mars rover is collecting rocks!

Alias: Sputnik, YearLaunched: 1957
Satellite is exploring the far reaches of space!
Satellite is collecting photographic evidence!
