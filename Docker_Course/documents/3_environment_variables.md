# Using Environment Variables #

The port variable can be set to an environment variable. Therefore, in change the Dockerfile as follows:

```
FROM node:15
WORKDIR /app
COPY package.json .
RUN npm install
COPY . ./
ENV PORT 3000
EXPOSE $PORT
CMD ["npm", "run", "dev"]
```

So now the port number can be given to the docker-container building command as follows:

```
docker run -v ${pwd}:/app:ro -v /app/node_modules --env PORT=3000 -p 3000:3000 -d --name node-app node-app-image
```

In this build command there can be passed as many environment variables as we want, but when there is a huge amount of them it becomes tedious to type them all sperately.
The solution to this is to create a file that stores all the environment variables, called ".env".

There we first set the port number to 3000: `PORT=3000`

Then the Docker Container build command can be adjusted as follows:

```
docker run -v ${pwd}:/app:ro -v /app/node_modules --env-file ./.env -p 3000:3000 -d --name node-app node-app-image
```
