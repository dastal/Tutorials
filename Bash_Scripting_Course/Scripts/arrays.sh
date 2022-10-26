#! /bin/bash

# Defining the array
car=('BMW' 'Opel' 'Honda')

# Prinitng the whole content of the array
echo "${car[@]}"

# Printing single objects within the array
echo "${car[0]}"

# Printing the occupied indexes of the array
echo "${!car[@]}"

# Print the length of the array
echo "${#car[@]}"

# Remove values
unset car[2]

echo "${car[@]}"

# Add another value

car[2]="Mercedes"

echo "${car[@]}"