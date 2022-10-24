# Numbers and Arithmetics #

## Integers Numbers ##
There are two main ways to handle integers. Let us assume we have two numbers, like:

```
n1=28
n2=4
```

Now we want to apply arithmetic operations to them and print them out. There are two ,ain ways for that. The first one is:

```
echo $(( n1 + n2 ))
```

whereas the `+` also can be replaced by `-`, `*`, `/`, and `%` (modulo).

The second way works as follows:

```
echo $(expr $n1 + $n2 )
```

whereas the `+` also can be replaced by `-`, `\*`, `/`, and `%` (modulo). Pay attention to the multiplication, you must write `\*`, otherwise you will get an error!

## Hexadecimal Numbers ##
We take the following input:

```
echo "Enter the hexadecimal number of your choice: "
read hex
```

Here we can input hexadecimal numbers, like `FFFF`. To turn the hexadecimal number into decimal number and output it, use the following code snippet:

```
echo "obase=10; ibase=16; $hex" | bc
```

- `obase=10` defines the output base of the number, in this case decimal (10)
- `ibase=16` defines the input base of the number, in this case hexadecimal (16)
- `$hex` is the input value, in hexadecimal form.
- `| bc` is the calculator form that we use here.