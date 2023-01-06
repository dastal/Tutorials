// callback

function one(call_two) {
  call_two();
  console.log(" step 1 ");
}

function two() {
  console.log(" step 2 ");
}

one(two);
