# Setting up the Project #
We create two .js files in our project: "app.js" and "db.js", whereas app means the actual application file (=index.js or main file) and bd means the setup of the database.

## `db.js` ##
First, we import all the needed components:

```
const MongoClient = require('mongodb').MongoClient;
const ObjectId = require('mongodb').ObjectId;
const dbname = "crud_mongodb";
const url = "mongodb://localhost:27017"
const mongoOptions = {useNewURLParser : true};
```

Then we set the initial state of the db equal to null, such that we know that we have to initiate the db:

```js
const state = {
    db : null
}
```

Next we write the connection method that connects the project with the database:

```js
const connect = (cb) =>{
    if(state.db)
        cb();
    else{
        MongoClient.connect(url,mongoOptions,(err,client)=>{
            if(err)
                cb(err);
            else{
                state.db = client.db(dbname);
                cb();
            }
        })
    }      
}
```

Further we need a function that gets the primary key of the database:

```js
const getPrimaryKey = (_id)=>{
    return ObjectID(_id);
}
```

A last method is to get the sate of the database (that we initiated at the beginning).

```js
const getDB = ()=>{
    return state.db;
}
```

Finally we need the exports of the module:

```js
module.exports = {getDB,connect,getPrimaryKey};
```

## `app.js` ##
Like in the `db.js` file, we need all our components to be initiated:

```js
const express = require('express');
const bodyParser = require('body-parser');
const app = express();
app.use(bodyParser.json());
const path = require('path');

const db = require('./db');
const collection = "todo";
```

Next we need to connect to the datbase:

```js
db.connect((err)=>{
    if(err){
        console.log('unable to connect to database');
        process.exit(1);
    }
    else{
        app.listen(3000,()=>{
            console.log('connected to database, app listening on port 3000');
        });
    }
})
```

## Running the Project ##
To run the project, simply type `node app` into the terminal, the console should show now "connected to database, app listening on port 3000".