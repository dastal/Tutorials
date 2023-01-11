let stocks = {
  Fruits : ["Strawberry", "Grapes", "Banana", "Apple"],
  Liquid : ["Water", "Ice"],
  Holder : ["Cone", "Cup", "Stick"],
  Toppings : ["Chocolate", "Peanuts"],
};

let is_shop_open = true;

let order = (time, work) => {
  
  return new Promise( (resolve, reject) => {
    
    if(is_shop_open){
      
      setTimeout( () => {
        resolve( work() ); 
      }, time)      
    }
    
    else{
      reject(console.log("Our shop is closed."))
    }
  })
};

order(2000, ()=>console.log(`${stocks.Fruits[0]} was selected.`))

.then(() => {
  
  return order(0000, ()=>console.log("Production has started."));
})

.then(() => {
  
  return order(2000, ()=>console.log("The fruit was chopped."));
})

.then(() => {
  
  return order(1000, ()=>console.log(`${stocks.Liquid[0]} and ${stocks.Liquid[1]} was selected.`));
})

.then(() => {
  
  return order(1000, ()=>console.log("Start the machine."));
})

.then(() => {
  
  return order(2000, ()=>console.log(`The ice cream was placed on the ${stocks.Holder[0]}`));
})

.then(() => {
  
  return order(3000, ()=>console.log(`${stocks.Toppings[0]} was selected.`));
})

.then(() => {
  
  return order(1000, ()=>console.log("Ice cream was served."));
})

.catch(() => {
  console.log("The customer left.");
})

.finally(() => {
  console.log("Day ended, shop is closed.")
});