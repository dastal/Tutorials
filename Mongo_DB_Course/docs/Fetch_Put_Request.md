# Fetch API: PUT Request #
We insert the following editing function into the script in our `index.html` file.

```
const editTodo = (todo,todoID,editID)=>{
	let editBtn = $(`#${editID}`);
	editBtn.click(()=>{
		fetch(`/${todo._id}`,{
			method : "put",
			headers : {
				"Content-Type" : "application/json; charset=utf-8" 
			},
			body : JSON.stringify({todo : todoUserInput.val()})
		}).then((response)=>{
			return response.json();
		}).then((data)=>{
			if(data.ok == 1){
				let todoIndex = $(`#${todoID}`);
				todoIndex.html(data.value.todo);
				resetTodosInput();
			}
		});
	});
}
```

We hand in the document that we want to edit, the ID of the todo and the ID of the button. 
We define the button and attach an action to it (click). Then we use the fetch API, where we first define the URL, 
`/<todoId>` like we defined it in the server. There we define the method (PUT), the headers that defines the type 
of the content (JSON), and the body that defines how we want to have our data transformed (in string to JSON and JSON to string). 
Then we wait for the response of the server, which we hand over to the client. If the anwer is ok, then we set the 
define the index of the todo (on the client side) and set the content of the todo and we reset the todos in the client.

If we now insert something into the input box and hit the edit button, the todo is edited.