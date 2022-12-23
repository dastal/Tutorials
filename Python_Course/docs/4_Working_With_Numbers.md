# Working with Numbers #

In Python, there are different types of numbers:

```
print(2)
print(2.0987)
print(-2.0987)
```

- integer numbers
- decimal numbers
- negative numbers

We can also do mathematical operations:
```
print(4 + 3)
print(4 - 3)
print(4 * 3)
print(4 / 3)
```

The order of mathematical operations is as the common mathematical rules:

```
print(4 - 3 * 5)
print((4 - 3) * 5)
```

Another common operator is the modulo operator:

```
print(10 % 3)
```

Numbers can be stored into variables:

```
my_num = 5
print(my_num)
```

Numbers can be converted into strings, such that they can be added together with strings. Without convertign them into strings we receive an error.

```
print(str(my_num))
print(str(my_num) + "is my favourite number.")
```

There are further functions for numbers

- `abs(-5)` returns the absolute value of -5
- `pow(3, 2)` whereas the first numner is the basis and the second number is the exponent, thus 3^2
- `max(4, 6)` returns the larger of the two numbers that are passed in
- `min(4, 6)` returns the smaller of the two numbers that are passed in
- `round(2.345)` returns mathematically rounded integers (2 in this case)

There are even more functions, but in order to be able to access them we need to import the module `python math`, which we add usually at the beginning of the script:

```
from math import *
```

Mehtods from `math`
- `floor(3.7)` no matter if we could round up, this method always rounds down (3 in this case)
- `ceil(3.2)` no matter if we could round down, this method always rounds up (4 in this case)
- `sqrt(36)` returns the square root of a number

There are even more functions. 