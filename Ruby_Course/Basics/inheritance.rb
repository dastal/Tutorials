# Superclass
class Chef
  def make_chicken
    puts "The chef makes Chicken"
  end
  def make_salad
    puts "The chef makes Salad"
  end
  def make_special_dish
    puts "The chef makes BBQ Ribs"
  end
end

# Subclass
class ItalianChef < Chef
  # overriding the method
  def make_special_dish
    puts "The chef makes Eggplant Parm"
  end
  def make_pasta
    puts "The Chef makes Pasta"
  end
end

chef = Chef.new()
chef.make_chicken
chef.make_special_dish

puts "\n"

italian_chef = ItalianChef.new()
italian_chef.make_salad
italian_chef.make_special_dish
italian_chef.make_pasta

# This does not work: chef.make_pasta
