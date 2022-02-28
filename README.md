# Calculating Pi #

We all love π, but have you ever thought about how to calculate such a lovable but irrational number?

There are [many](https://mathworld.wolfram.com/PiFormulas.html) formulas to calculate π, but not all are created equal. The formula we will use certainly is not the best
but does show how difficult it can be to calculate an irrational number with high precision. 

## Instructions ##

Use the [Leibniz Formula](http://en.wikipedia.org/wiki/Leibniz_formula_for_%CF%80), which is an infinite series of the form:
```
π = 4/1 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11 + 4/13 - ...
```
where the more elements of the series (or iterations of your loop) you add, the more precise your value of π will be. 

### Your Function Should: ###
- Accept `precision` as a parameter. This is to signify how close to the π constant of your chosen language you need to be. 
    - E.g. A `precision` of `0.001` means the absolute value of your computed valued subtracted from the constant value of π must be equal to or less than `precision`.
- Return `iterations` as the number of iterations necessary to acheive the requested prescision.
    - Optionally you could also return the computed value with the given precision for visual comparison with the constant value. 

### An Example: ###
Given a precision of `0.001`, your function gets an approximation of `3.14094984654984` for π at the end of `1000` iterations. Since the absolute value of the difference of the computed and constant values is `0.0006428`, you are within `0.001` of `Math.Pi` and return:
```
func(0.001) ==> 1000
```

Your goal is to determine just how many iterations are needed to get the same precision as the π constant of your chosen language. If your language doesn't have a constant below are the first `28` digits of π
```
3.1415926535897932384626433833
```

Some possible additonal tasks:
- Try determining the number of iterations for the highest possible precision data type in your language
    - E.g. the `28` digit value above is the highest precision C# can do out of the box (without 3rd party libraries) using the `decimal` class.
- Some form of parallelism to make the calculation faster
- Track how much the difference between the calculated and constant values changes as more iterations are computed
    - Graph?

---
A few suggestions:
- Use [TDD](https://www.martinfowler.com/bliki/TestDrivenDevelopment.html)! It really does make your code better!
- Think carefully about what data types you use. 
- A `stopwatch` or `timer` functionality might be useful as you get to smaller `precision` values. 