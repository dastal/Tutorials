# append mode, add information onto the end of the file
File.open("Files/employees1.txt", "a") do |file|
  file.write("Oscar, Accounting")
end

# write into a file by ovewriting all the previous content of the file
File.open("Files/employees2.txt", "w") do |file|
  file.write("Oscar, Accounting")
end

# ceate a new file: just write a filename that does not exist yet
File.open("Files/index.html", "w") do |file|
  file.write("<h1<Hello</h1>")
end

# read and write file
File.open("Files/employees3.txt", "r+") do |file|
  file.readline()
  file.write("Overridden")
  file.write("Hi")
end
