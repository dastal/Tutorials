# Container to store groups of methods
module Tools

  def sayhi(name)
    puts "Hello #{name}!"
  end

  def saybye(name)
    puts "Bye #{name}!"
  end

end

include Tools
#Tools.sayhi("Dave")
#Tools.saybye("Dave")
