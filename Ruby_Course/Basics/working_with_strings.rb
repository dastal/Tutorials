puts "Ruby Basics"
puts "Ruby\" Basics"
puts "Ruby\n Basics"

phrase = "Ruby Basics"
puts phrase

puts phrase.upcase()
puts phrase.downcase()
puts "something".upcase()

phrase = "        Ruby Basics           "
puts phrase
puts phrase.strip()

phrase = "Ruby Basics"
puts phrase.length

puts phrase.include? "Basics"
puts phrase.include? "basics"

puts phrase[0]
puts phrase[0,3]

puts phrase.index("B")
puts phrase.index("ics")

puts "Number: %d" %123

puts "1234" <=> "2345"

# more: https://ruby-doc.org/core-2.6/String.html
