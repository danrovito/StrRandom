# StrRandom

![Nuget](https://img.shields.io/nuget/dt/StrRandom)

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


## Disclaimer

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
