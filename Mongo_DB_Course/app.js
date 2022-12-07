const express = require('express');
const bodyParser = require('body-parser');
const app = express();
app.use(bodyParser.json());
const path = require('path');

const db = require('./db');
const collection = "todo";

app.get('/',(req,res)=>{
    res.sendFile(path.join(__dirname,'index.html'));
});

app.get('/getTodos',(req,res)=>{
    db.getDB().collection(collection).find({}).toArray((err,documents)=>{        
        if(err)
            console.log(err);
        else{
            console.log(documents);
            res.json(documents);
        }
    })
});

// update
app.put('/:id',(req,res)=>{
    // Primary Key of Todo Document we wish to update
    const todoID = req.params.id;
    // Document used to update
    const userInput = req.body;
    // Find Document By ID and Update
    db.getDB().collection(collection).findOneAndUpdate(
        {_id : db.getPrimaryKey(todoID)},
        {$set : {todo : userInput.todo}},
        {returnOriginal : false},
        (err,result)=>{
        if(err)
            console.log(err);
        else{
            res.json(result);
        }      
    });
});

//delete
app.delete('/:id',(req,res)=>{
    // Primary Key of Todo Document
    const todoID = req.params.id;
    // Find Document By ID and delete document from record
    db.getDB().collection(collection).findOneAndDelete({_id : db.getPrimaryKey(todoID)},(err,result)=>{
        if(err)
            console.log(err);
        else
            res.json(result);
    });
});

// Create
app.post('/',(req,res)=>{
    // Document to be inserted
    const userInput = req.body;
        
    db.getDB().collection(collection).insertOne(userInput,(err,result)=>{
        if(err){
            console.log(err);
        }
        else
            res.json(result);
    });   
});

// Connect
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