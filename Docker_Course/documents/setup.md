# Setup #

- IDE: [VS Code](https://code.visualstudio.com/download)
- NodeJS: Open Terminal in the folder you want to work and enter `npm init -y`
- Express: Enter `npm install express` into termial

## Index.js file ##

- In the working directory, create a new file called `index.js`.
- Import Express
- Initiate app on port 3000

## Docker Container ##

- Install Docker [Docker for Windows](https://docs.docker.com/desktop/install/windows-install/) and follow the steps until you are signed in.

## Docker Image ##

The Docker Image creates layers of the application to run.

```
FROM node:15
WORKDIR /app
COPY package.json .
RUN npm install
COPY . ./
EXPOSE 3000
CMD ["node", "index.js"]
```

- Layer 1: Node.js Version 15
- Layer 2: Workin Directory: app
- Layer 3: Copy package.json
- Layer 4: Run the command "npm install"
- Layer 5: Copy the rest of the project (to make sure that when changes were made, they were only made in the "self-written" code and not in the dependencies)
- Layer 6: Expose 3000 means listen to Port 3000 (as declared in the application)
- Layer 7: Declare the command how to run the project ("node index.js" in this case)
