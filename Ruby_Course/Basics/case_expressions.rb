def get_day_name(day)
  day_name = ""
  if day == "mon"
    day_name = "Monday"
  elsif day == "tue"
    day_name = "Tuesday"
  elsif day == "wed"
    day_name = "Wednesday"
  elsif day == "thu"
    day_name = "Thursday"
  elsif day == "fri"
    day_name = "Friday"
  elsif day == "sat"
    day_name = "Saturday"
  elsif day == "sun"
    day_name = "Sunday"
  end
end

# The code above is really messy, use the following instead:

def get_day_name_improved(day)
  day_name = ""

  case day
  when "mon"
    day_name = "Monday"
  when "tue"
    day_name = "Tuesday"
  when "wed"
    day_name = "Wednesday"
  when "thu"
    day_name = "Thursday"
  when "fri"
    day_name = "Friday"
  when "sat"
    day_name = "Saturday"
  when "sun"
    day_name = "Sunday"
  else
    day_name = "Invalid abbreviation"
  end

  return day_name
end

# appropraite when we are chencking the same value against a bunch of other values then it makes life a lot easier.

puts get_day_name_improved("mon")
puts get_day_name_improved("sat")
puts get_day_name_improved("thu")
puts get_day_name_improved("dog")
