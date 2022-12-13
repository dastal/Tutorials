# Fetch API: DELETE Request #
We insert the following delete function into the script of the `index.html` file.

```
const deleteTodo = (todo,listItemID,deleteID)=>{
	let deleteBtn = $(`#${deleteID}`);
	deleteBtn.click(()=>{
		fetch(`/${todo._id}`,{
			method: "delete"
		}).then((response)=>{
			return response.json();
		}).then((data)=>{
			if(data.ok == 1){
				$(`#${listItemID}`).remove();
			}
		});
	});
}
```

We hand in the parameters todo, the ID of the list element we want too delete and the delete ID is the Id we gave to our delete button. 
Then we define the delete button and hand in the deleteID. The option of the button is the delete mehtod. 
Then we send the actual delete request to the server and wait for the answer. If the answer arrived and has been successful, we remoove the element from the unordered list on the client.

In the displayTodos method, in the `forEach` part, we insert the line:

```
deleteTodo(todo,ids.listItem,ids.deleteID);
```