 # Building a Todo Crud Application from Scratch #
We are going to code two app.get functions:

- Sign a static HTML file to the user
- Query the database for all the todos and return that to the user

## Sign Static HTML File to User ##
The following function signs a HTML file to the user. The file does not extist yet, we will create it later in that tutorial.

```js
app.get('/',(req,res)=>{
    res.sendFile(path.join(__dirname,'index.html'));
});
```

## Query the Database ##
The following function queries all the todos to the database and returns them  to the user.

```js
app.get('/getTodos',(req,res)=>{
    db.getDB().collection(collection).find({}).toArray((err,documents)=>{        if(err)
            console.log(err);
        else{
            console.log(documents);
            res.json(documents);
        }
    })
});
```

## Running the App ##
When we no run the app and open `localhost:3000/getTodos` in the browser, we recive an empty array, 
and that is because we have an empty database at the moment.

In the terminal, start the Mongo Shell with the command `mongosh`. After the Mongo Shell has started, 
start using the MongoDB of the app by typing `use [DBName]`, in this case `use crud_mongodb`.

After connecting the DB, to insert something into it, use the command `db.todo.insertOne({todo: "something"})`

Then, after leaving the Mongo Shell by entering `Ctrl+C` twice, you can restart the app and go to `localhost:3000/getTodos`, 
there you should see that you have inserted a new object to the db.