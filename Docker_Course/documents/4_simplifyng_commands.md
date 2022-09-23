# Simplifying Commands #

## Deleting unnecessary Volumes ##

To delete all the unnecessary volumes that we build, use the command:

`docker volume prune`

But from now on we always hand in the "-fv" flag when removing the container:

```
docker rm node-app -fv
```

## Shortening the Docker Container Build Command ##

To make the building process easier such that we do not always have to type in the long build command, we create a new file called "docker-compose.yml".

First we need to define the docker version. For sepcific version, visit this [link](https://docs.docker.com/compose/compose-file/compose-versioning/). In this case we just set version 3 as default version. 

Next we need to define the services, i.e. all the containers we want to call with this file. Important: always use one tab!

```
version: "3"
services:
  node-app:
    build: .
    ports:
      - "3000:3000"
    volumes:
      - ./:/app
      - /app/node_modules
    environment:
      - PORT=3000
    #env_file:
    #  - ./.env
```

- `build: .`: the current directory
- `ports:` hand in all the ports you want the project to work on (here just 3000:3000)
- `volumes:` pass in all the volumes
- `environment:` pass in all the environment variables
- `env_file:` if there is one, hand in the file with the environment variables (here commented out since we have only one environment vairable)

Now, to build the image, we use the command:

```
docker-compose up -d --build
```

To interrupt it, just use:

```
docker-compose down -v
```
