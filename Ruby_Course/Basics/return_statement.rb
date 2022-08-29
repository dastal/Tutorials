def cube(num)
  num * num * num
end

puts cube(2)

def cube(num)
  num * num * num
  "last value"
end

 puts cube(2)

 def cube(num)
   return num * num * num
   "last value"
 end

 puts cube(2)

 def cube(num)
   return num * num * num, 70
   "last value"
 end

 puts cube(2)
 puts cube(2)[1]
