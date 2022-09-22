# Update Code Changes in the Applications #

The problem is now that if we do changes the code and we want to refresh it on the page, nothing happens. This is because the image of the app was created before we added the changes to the code and no updates are contributed to the image.
We can solve that if we update the image manually by deleting the old image and rebuild the new one.

But ther is also another way to solve it: by using volumes. Therefore we pass another flag to the `docker run` command:

`docker run -v [pathToProjectFolder:pathToFolderContainer] -p 3000:3000 -d --name node-app node-app-image`

Path to folder if OS is Windows using command shell
`%cd%`

Path to folder if OS is Windows using power shell
`${pwd}`

Path to folder if OS is iOS/ Linux using command shell
`${pwd}`

So my this case the code is called

`docker run -v ${pwd}:/app -p 3000:3000 -d --name node-app node-app-image`

But this is not all, yet. We need to install Nodemon. Therefore enter `npm install nodemon --save-dev`. After installing it, we need to change the "package.json" file beneath "Debug" to:

```
"scripts": {
    "start": "node index.js",
    "dev": "nodemon -L index.js"
},
```

In the Dockerfile, change the seventh line to:

```
CMD ["npm", "run", "dev"]
```

After those changes, we need to rebuild the image.

To avoid that docker touches the important node_modules folder, pass another volume to the build command:

```
docker run -v ${pwd}:/app -v /app/node_modules -p 3000:3000 -d --name node-app node-app-image 
```

To avoid that from the docker-container app you can create new files on the local machine. Therefore we pass a read only volume to the docker-container when building it.

```
docker run -v ${pwd}:/app:ro -v /app/node_modules -p 3000:3000 -d --name node-app node-app-image
```

whereas the ":ro" means "read only".