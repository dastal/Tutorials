def pow(base, exponent)
  result = 1
  exponent.times do
    result = result * base
  end
  return result
end

puts pow(2, 3)
puts pow(4, 3)
puts pow(5, 2)
