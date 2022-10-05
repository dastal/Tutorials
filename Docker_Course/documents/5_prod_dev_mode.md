# Production vs Development Mode #
The easiest solution is to have multiple Dockerfiles, one for production and one for development. The main change in those two Dockerfiles is in the last line (`CMD[..]`).
Therefore we first create a new "docker-compose.yml" file and rename the old one to "docker-compose-backup.yml". We also create two more files, one called "docker-compose.dev.yml" for the deveopment mode and the other one called "docker-compose.prod.yml" for the production mode.
But we have only one Dockerfile!

## Shared Configurations (docker-compose.yml) ##
First we start by the shared configurations. Note that the port can differ from development mode to production mode! In this case the `ports:` variable is not situated on the shared file but on the separate files.
In our case here we have for both modes the same port, so the the "docker-compose.yml" file looks as follows:

```
version: "3"
services:
  node-app:
    build: .
    ports:
      - "3000:3000"
    environment:
      - PORT=3000
```

## Development Mode (docker-compose.dev.yml) ##
Here we override all the protperties that are different to the shared configurations file. We set all the properties for the devopment mode, which should look as follows:

```
version: "3"
services:
  node-app:
    volumes:
      - ./:/app
      - /app/node_modules
    environment:
      - NODE_ENV=development
    command: npm run dev
```

In the Dockerfile on the last line, we do the following change:

```
CMD ["node", "index.js"]
```

## Production Mode (docker-compose.prod.yml) ##
Same as in the development mode file, but adjusted to the production mode:

```
version: "3"
services:
  node-app:
    environment:
      - NODE_ENV=production
    command: node index.js
```

Nothe that in the production mode, we cannot make changes directly, but we always have to rebuild the image!


## Getting into the modes ##
For getting into the development mode, on the terminal use the following command:

```
docker-compose -f docker-compose.yml -f docker-compose.dev.yml up -d
```

For getting out of the development mode, on the terminal use the following command:

```
docker-compose -f docker-compose.yml -f docker-compose.dev.yml down -v
```

Everytime we made changes and we want to see the image in the production mode we need to force a new build, using the following command:

```
docker-compose -f docker-compose.yml -f docker-compose.prod.yml up -d --build
```

For getting into the production mode, on the terminal use the following command:

```
docker-compose -f docker-compose.yml -f docker-compose.prod.yml up -d
```

For getting out of the production mode, on the terminal use the following command:

```
docker-compose -f docker-compose.yml -f docker-compose.prod.yml down -v
```

## .dockerigore ##
To make sure that we do not hand in any of the docker files, in the .dockerignore file we need to add the following to the last line:

```
docker-compose*
```

This makes sure that none of the docker-compose files are handed in.

## Exclude Dev-Files from Production Mode ##
To make sure that no dev-files in the node-modules folder (here especially nodemon.js) are executed while being in the production mode, we additionally need to add an embedded bash script.
In the Dockerfile, do the following changes:

```
FROM node:15
WORKDIR /app
COPY package.json .
ARG NODE_ENV
RUN if ["$NODE_ENV" = "development" ]; \
        then npm install: \
        else npm install --only=production; \
        fi
COPY . ./
ENV PORT 3000
EXPOSE $PORT
CMD ["node", "index.js"]
```

In the .dev file, we need to add the `context` and the `args` under the `node-app:`, where under `args` the `NODE_ENV: development` must be set.

```
version: "3"
services:
  node-app:
    build:
      context: .
      args:
        NODE_ENV: development
    volumes:
      - ./:/app
      - /app/node_modules
    environment:
      - NODE_ENV=development
    command: npm run dev
```

Same as in the .dev file, but with `NODE_ENV: production` in the .prod file:

```
version: "3"
services:
  node-app:
    build:
        context: .
        args:
          NODE_ENV: production
    environment:
      - NODE_ENV=production
    command: node index.js
```