# Stroing the opened file in file
File.open("Files/employees.txt", "r") do |file|
  puts file.read()
end

puts "\n"

  # reading one line of the file
File.open("Files/employees.txt", "r") do |file|
  puts file.readline() #reads and moves to the next line
  puts file.readline()
end

puts "\n"

# reading a single character of the file
File.open("Files/employees.txt", "r") do |file|
  puts file.readchar() #reads and moves to the next character
  puts file.readchar()
  puts file.readchar()
end

puts "\n"

# returns an array of all of the line
File.open("Files/employees.txt", "r") do |file|
  for line in file.readlines()
    puts line
  end
end

puts "\n"

# other way to open a file
file = File.open("Files/employees.txt", "r")

puts file.read

file.close()
