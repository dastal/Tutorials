# Adding a Mongo Container #

## Installing Mongo DB #


## Setup ##

First, we need to add the new database to our `docker-compose.yml` file under services, as described in the [Docker Hub under Mongo DB](https://hub.docker.com/_/mongo).

```
mongo:
	image: mongo
	environment:
      	- MONGO_INITDB_ROOT_USERNAME=myusername
      	- MONGO_INITDB_ROOT_PASSWORD=mypassword
```

After making another build, we see that now two images have been built, one is the node_docker_node-app and the other is the mongo image. To connect the two images, use

First we enter in the mongo image with the command:

```
docker exec -it node_docker_mongo_1 bash
```

Then we get access to our mongo database, by using:

```
mongo -u "myusername" -p "mypassword"
```

The `-u` stands for username and the `-p` for password. Mind that those two values must be exactly the same as you set them in the `docker-compose.yml` file!