puts "Hello"

puts "Enter your name: "
name = gets
puts ("Hello " + name)

puts ("Hello " + name + ", you are amazing!")

# Pritns everything after name into a new line. In oder to avoid this, use .chomp()
puts "Enter your name: "
name = gets.chomp()
puts ("Hello " + name + ", you are amazing!")
puts "Enter your age: "
age = gets.chomp()
puts ("Hello " + name + ", you are " + age + "!")
