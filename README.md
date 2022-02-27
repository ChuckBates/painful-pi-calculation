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
- Accept `precision` as a parameter to signify how close to your language π constant you need to be. (E.g. `0.001`)
    - A `precision` of `0.001` means your computed value _must_ start with `3.14...`
- Return `iterations` as the number of iterations necessary to acheive the requested prescision.
    - Optionally you could also return the computed value with the given precision for comparison with the constant value. 

### An Example: ###
Given a precision of `0.001`, your function gets an approximation of `3.140592653839794` for π at the end of `1000` iterations. Since you are within `0.001` of `Math.Pi` you return:
```
func(0.001) ==> 1000
```

Your goal is to determine just how many iterations are needed to get the same precision as the π constant of your chosen language. If your language doesn't have a constant, or if you are feeling particuarly adventurous, provided below are the first `100` digits of π
```
3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679
```

---
A few suggestions:
- Use [TDD](https://www.martinfowler.com/bliki/TestDrivenDevelopment.html)! It really does make your code better!
- Think carefully about what data types you use. 
- A `stopwatch` or `timer` functionality might be useful as you get to smaller `precision` values. 