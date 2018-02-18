# StrRandom
C# libarary that creates a random string based on a mix of numbers and letters.

## Usage
First you'll want to call the class

```
var random = new StrRandom.StrRandom();
```

Then you can call the function to generate your string

```
var string = random.GenerateString();
```

You can also pass the length of random string you want to ther function by supplying an integer.

```
var string = random.GenerateString(32);
```
