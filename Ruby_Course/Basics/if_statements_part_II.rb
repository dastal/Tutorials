def max(num1, num2, num3)
  if num1 >= num2 and num1 >= num3
    return num1
  elsif num2 >= num1 and num2 >= num3
    return num2
  else
    return num3
  end
end

puts max(1, 2, 3)
puts max(1, 20, 3)
puts max(10, 2, 3)

# Other comparison operators
# ==
# !=
# >
# <

# String comparison is also possible
if "Ruby" == "Ruby"
  puts "The Values are the same."
end

if "Ruby" == "Basics"
  puts "The values are the same."
else
  puts "The values are not the same."
end
