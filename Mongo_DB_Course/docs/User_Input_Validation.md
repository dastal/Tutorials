# User Input Validation #
First of all we have to install JOI by entering `npm install joi` in the terminal.

Then in the app.js file, we include Joi:
```
const Joi = require('joi');
```

Then we add a new schema (a blueprint that a user has to follow). The only Object that we have in our program is the todo, and herefore we create the schema.

```
const schema = Joi.object().keys({
    todo : Joi.string().require()
});
```

As a further step, we validate anything that is comming back from the user.

We start with `app.post` and rewrite the function as follows:

```js
app.post('/',(req,res,next)=>{
    // Document to be inserted
    const userInput = req.body;

    // Validate document
    // If document is invalid pass to error middleware
    // else insert document within todo collection
    Joi.validate(userInput,schema,(err,result)=>{
        if(err){
            const error = new Error("Invalid Input");
            error.status = 400;
            next(error);
        }
        else{
            db.getDB().collection(collection).insertOne(userInput,(err,result)=>{
                if(err){
                    const error = new Error("Failed to insert Todo Document");
                    error.status = 400;
                    next(error);
                }
                else
                    res.json({result : result, document : result.ops[0],msg : "Successfully inserted Todo!!!",error : null});
            });
        }
    })    
});
```

Joi just controls the input to be correct.

Then we input the following function:

```
// Middleware for handling Error
// Sends Error Response Back to User
app.use((err,req,res,next)=>{
    res.status(err.status).json({
        error : {
            message : err.message
        }
    });
})
```

Then from Bootstrap, we import an alert that we are going to show on the client side if the request was correct/ not correct:

```
<div class="row">
	<div class="col-lg-2"></div>
		<div class="col-lg-8">
			<div class="alert" role="alert" id="message">
		</div>
	</div>
	<div class="col-lg-2"></div>
</div>
```

In the script below we add:

```
const message = $("#message");$
message.hide();

const displayMessage = (flag,msg)=>{
	// successful
	if(flag){
		message.removeClass('alert-danger');
		message.addClass('alert-success');
		message.html(msg);
		message.show();
	}
	else{
		message.removeClass('alert-success');
		message.addClass('alert-danger');
		message.html(msg);
		message.show();
	}
}
```

For more information have a look at the video!