let stocks = {
  Fruits : ["Strawberry", "Grapes", "Banana", "Apple"],
  Liquid : ["Water", "Ice"],
  Holder : ["Cone", "Cup", "Stick"],
  Toppings : ["Chocolate", "Peanuts"],
};

let is_shop_open = false;

function time(ms){
  return new Promise((resolve, reject) => {
    if(is_shop_open){
      setTimeout(resolve, ms)
    }
    else{
      reject(console.log("Shop is closed."))
    }
  })
}

async function kitchen(){
  try{
    await time(2000)
    console.log(`${stocks.Fruits[0]} was selected.`)
    
    await time(0000)
    console.log("Start the production.")
    
    await time(2000)
    console.log("Cut the Fruits.")
    
    await time(1000)
    console.log(`${stocks.Liquid[0]} and ${stocks.Liquid[1]} was added.`)
    
    await time(1000)
    console.log("Start the machine.")
    
    await time(2000)
    console.log(`Ice cream placed on ${stocks.Holder[0]}.`)    
    
    await time(3000)
    console.log(`${stocks.Toppings[0]} was selected.`)
    
    await time(2000)
    console.log("Serve the ice cream.")
  }
  catch(error){
    console.log("Customer left.", error)
  }
  finally{
    console.log("Day ended, shop is closed.")
  }
}

kitchen();
