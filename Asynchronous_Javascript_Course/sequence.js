let stocks = {
  Fruits : ["Strawberry", "Grapes", "Banana", "Apple"],
  Liquid : ["Water", "Ice"],
  Holder : ["Cone", "Cup", "Stick"],
  Toppings : ["Chocolate", "Peanuts"],
};

let order = (fruit_name, call_production) => {
  
  setTimeout(()=>{
    console.log(`${stocks.Fruits[fruit_name]} was selected.`)
    
    call_production();
    
  }, 2000)
  
};

let production = () => {
  
  setTimeout(() => {
    console.log("Production has started.");
    
    setTimeout(() => {
      console.log("The fruit has been chopped.");
      
      setTimeout(() => {
        
        console.log(`${stocks.Liquid[0]} and ${stocks.Liquid[1]} was added. `)
        
        setTimeout(() => {
          
          console.log("The machine was started. ")
          
          setTimeout(() => {
            
            console.log(`The ice cream was placed on the ${stocks.Holder[0]} `)
            
            setTimeout(() => {
              console.log(`${stocks.Toppings[0]} was added on top of the ice cream. `)
              
              setTimeout(() => {
                
                console.log("Serve the ice cream. ")
                
              }, 2000)
              
            }, 3000)
            
          }, 2000)
          
        }, 1000)
        
      }, 1000)
      
    }, 2000);
    
  }, 0000);
  
};

order(0,production);
