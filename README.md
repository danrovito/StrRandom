# StrRandom
C# libarary that creates a random string based on a mix of numbers and letters.

## Usage
First you'll want to call the class

```c#
var random = new StrRandom.StrRandom();
```

Then you can call the function to generate your string

```c#
var string = random.GenerateString();
```

You can also pass the length of random string you want to ther function by supplying an integer.

```c#
var string = random.GenerateString(32);
```
