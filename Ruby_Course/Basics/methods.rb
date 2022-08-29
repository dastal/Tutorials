def sayHi
  puts "Hello User"
end

puts "Top"
sayHi
puts "Bottom"

def sayHi2(name)
  puts ("Hello " + name)
end

name = "Horst"

sayHi2(name)

def sayHi3(name, age)
  puts "Hello " + name + ", you are " + age.to_s + " years old."
end

age = 55

sayHi3(name, age)

def sayHi4(name="no name", age=-1)
  puts "Hello " + name + ", you are " + age.to_s + " years old."
end

sayHi4
sayHi4(name)
