puts "Enter a number: "
num1 = gets.chomp()
puts "Enter another number: "
num2 = gets.chomp()

result = num1 + num2

puts("After the addition, the result is: " + result)

# gets reads input as a string, so during the addition it concatenates the strings instead of add them mathematically. We must convert the number into integers:
puts "Enter a number: "
num1 = gets.chomp()
puts "Enter another number: "
num2 = gets.chomp()

result = num1.to_i() + num2.to_i()

puts("After the addition, the result is: " + result.to_s)

# but now when we enter a decimal number, we recieve a integer in every case. To avoid that use to_f instead of to_i
puts "Enter a number: "
num1 = gets.chomp()
puts "Enter another number: "
num2 = gets.chomp()

result = num1.to_f() + num2.to_f()

puts("After the addition, the result is: " + result.to_s)

# Instead of turing the strings into floats during the addition, they can also be read during the actual input
puts "Enter a number: "
num1 = gets.chomp().to_f
puts "Enter another number: "
num2 = gets.chomp().to_f

result = num1 + num2

puts("After the addition, the result is: " + result.to_s)
