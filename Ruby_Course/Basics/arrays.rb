friends = Array["Bruce", "Tony Stark", "Peter Parker", "Luke Skywalker"]
puts(friends)

mixed = Array[1, "Karen", true]

puts friends[0]
puts friends[-1]
puts friends[0,2] #stops at 1!!

friends[0] = "Bruce Wayne"
puts friends[0]
friends[3] = "Clark Kent"
puts friends[3]
friends[4] = "Hulk"

foes = Array.new
foes[0] = "Thanos"
foes[1] = "Joker"
foes[5] = "Darth Vader"
puts foes

foes[2] = "King Pin"
foes[3] = "Red Skull"
foes[4] = "Jabba the Hutt"
foes[5] = "Lex Luthor"

puts ("I have " + friends.length().to_s + " allies!")
puts friends.include? "Bruce Wayne"
puts friends.include? "Master Yoda"

puts friends.reverse()
puts foes.sort()

foes[6] = "Winter Soldier"
puts foes
puts "\n"
friends.push(foes.pop())
puts "\nFriends: "
puts friends
puts " \nFoes: "
puts foes
