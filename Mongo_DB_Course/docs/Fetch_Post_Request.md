# Fetch APi: POST Request #
We insert the following method into our script on the `index.html` file:

```
form.submit((e)=>{
	e.preventDefault();
	fetch('/',{
		method : 'post',
		body : JSON.stringify({todo : todoUserInput.val()}),
		headers : {
			"Content-Type" : "application/json; charset=utf-8"
		}
	}).then((response)=>{
		return response.json();
	}).then((data)=>{
		if(!data.error){
			if(data.result.ok == 1 && data.result.n == 1){
				let ids = buildIDS(data.document);
				display.append(buildTemplate(data.document,ids));
				editTodo(data.document,ids.todoID,ids.editID);
			}
		}
		else
			displayMessage(false,data.error.message);

		resetTodosInput();

		});
});
```

We define:
- the URL, which is `/`
- the mehtod which is `post`
- the body, which indicates how the object looks like
- the headers, which indicates the content type

Then:
- we wait for the response from the server, which we return after we got the response
- if the there is no error in the data, we hand it over to the server.

Finally, we can insert things from the client side on the browser by using the `index.html` file.


