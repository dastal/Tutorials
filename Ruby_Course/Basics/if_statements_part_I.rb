ismale = true

if ismale
  puts "You are male."
end

ismale = false

if ismale
  puts "You are male."
end

if ismale
  puts "You are male."
else
  puts "You are not male."
end

ismale = true

if ismale
  puts "You are male."
else
  puts "You are not male."
end

istall = true

if ismale and istall
  puts "You are a tall male."
end

istall = false

if ismale and istall
  puts "You are a tall male."
else
  puts "You are either not male or not tall or both."
end

if ismale or istall
  puts "You are a tall male."
else
  puts "You are either not male and not tall."
end

ismale = false

if ismale or istall
  puts "You are a tall male."
else
  puts "You are either not male and not tall."
end

ismale = true
if ismale and istall
  puts "You are a tall male."
elsif ismale and !istall
  puts "You are a short male."
else
  puts "You are either not male and not tall."
end

ismale = true
istall = true
if ismale and istall
  puts "You are a tall male."
elsif ismale and !istall
  puts "You are a short male."
elsif !ismale and istall
  puts "You are a tall female."
else
  puts "You are not male and not tall."
end


ismale = false
istall = true
if ismale and istall
  puts "You are a tall male."
elsif ismale and !istall
  puts "You are a short male."
elsif !ismale and istall
  puts "You are a tall female."
else
  puts "You are not male and not tall."
end

ismale = true
istall = false
if ismale and istall
  puts "You are a tall male."
elsif ismale and !istall
  puts "You are a short male."
elsif !ismale and istall
  puts "You are a tall female."
else
  puts "You are not male and not tall."
end

ismale = false
istall = false
if ismale and istall
  puts "You are a tall male."
elsif ismale and !istall
  puts "You are a short male."
elsif !ismale and istall
  puts "You are a tall female."
else
  puts "You are not male and not tall."
end
