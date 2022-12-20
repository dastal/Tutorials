# MongoDB Course #
Course to get familiar with MongoDB. I used this [Tutorial](https://www.youtube.com/watch?v=CyTWPr_WwdI) to complete the course.

## Setup ##
- IDE: [VS Code](https://code.visualstudio.com/download)
- Download [MongoDB](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-windows/) and install it
- Go through the whole [installation procedure](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-windows/) of MongoDB
- Open a new folder
- Open a new terminal
- Type `npm init -y`
- Type `npm install body-parser`
- Type `npm install express`
- Type `npm install mongodb`
- Type `npm install path`

In the "package.json" file, change under `main: index.js` to `main: app.js` (this is just a personal preference of the lecturer, but to not have confusions, I did the same thing)

## Course Content ##
Following a table with the course content:

| Lecture | Content |
| :------ | :------ |
| [Setting up Project](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Setup_Project.md) | Detailed setup of the project, especially connecting the database with the application |
| [Get Todos](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Todo_Crud_App.md) | Inserting first objects into the database manually and access them via the application (on the server side) |
| [Server Side Update Portion](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Server_Side_Update_Portion.md) | Updating the already inserted objects in the DB on the server side |
| [Server Side Create Portion](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Server_Side_Create_Portion.md) | Creating the already inserted objects in the DB on the server side |
| [Server Side Delete Portion](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Server_Side_Delete_Portion.md) | Deleting the already inserted objects in the DB on the server side |
| [Index File](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Creating_Index_File.md) | Creating an index file that is used to show the content of the DB |
| [Fetch GET Request](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Fetch_Get_Request.md) | Fetching the GET request on the client side |
| [Fetch POST Request](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Fetch_Post_Request.md) | Fetching the POST request on the client side |
| [Fetch DELETE Request](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Fetch_Delete_Request.md) | Fetching the DELETE request on the client side |
| [Fetch PUT Request](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Fetch_Put_Request.md) | Fetching the PUT request on the client side |
| [User Input Validation](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/User_Input_Validation.md) | Esuring that the data that is exchanged has the correct shape |

## Running the App ##
Open a new terminal and type:
```
node app
```

## Final Product ##
The final product looks as follows:

![Final Product](https://github.com/dastal/Tutorials/blob/main/Mongo_DB_Course/docs/Images/final_product.png)
