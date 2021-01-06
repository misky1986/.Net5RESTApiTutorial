# Markdown File

For getting started using the application with mongo the following commanded is needed in order to setup mongo via Docker:

```docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo```

**The above docker command explained with meaning of the flags**
The following plain docker command: ```docker run mongo``` would simply try to run a container based on the image called mongo.
If the command has never been run before, the image would be downloaded from dockerhub a be a bit slow in order to fetch the image.
Next time the command is executed, the image would already be downloaded and the container would start immediately.

The following flags is used in order to make the mon
* ```-d``` runs the container in detached mode, meaning that it is hidden in the console, and therefore not blocking the current console window
* ```--rm``` Automatically remove the container when it exits
* ```--name``` Assign a name to the container
* ```-p``` Publish a container's port(s) to the host
* ```-v``` Bind mount a volume