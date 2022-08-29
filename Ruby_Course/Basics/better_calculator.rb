puts "Enter first number: "
num1 = gets.chomp().to_f
puts "Enter operator (mathematical SIGN!): "
op = gets.chomp()
puts "Enter second number: "
num2 = gets.chomp().to_f

def calculator(op, num1, num2)
  if op == "+"
    result = num1 + num2
  elsif op == "-"
    result = num1 - num2
  elsif op == "*"
    result = num1 * num2
  elsif op == "/"
    result = num1 / num2
  else
    puts "Unknown operator!"
    return
  end
  puts ("The result after " + op + " operation is: " + result.to_s + ".")
end

calculator(op, num1, num2)
