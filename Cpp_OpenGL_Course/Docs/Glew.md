# Glew

Glew checks the type of the graphics driver which is used by the individual system and imports the corresponding function addresses.

## Initializing Glew
The initialization of Glew needs to be done before the while loop, but we need a OpenGL context before we call Glew. Therefore we use the command `glewInit()` which initializes all the function pointers. This command is an error and has the type `GLenum`. We can use that to check errors.

Code:
```cpp
GLenum err = glewInit();
if (err != GLEW_OK) {
	std::cout << "Error: " << glewGetErrorString(err) << std::endl;
	std::cin.get();
	return -1;
}
```
After this sequence we can additionally query the version of OpenGL which our graphics card is using to know which possibilities we have.

```cpp
std::cout << "OpenGL version: " << glGetString(GL_VERSION) << std::endl;
```

## After finishing the project
After the project is finished and not all the functions of Glew are used, we can initiallze only the used Glew functions to make the project faster. Otherwise it needs to load about 23000 lines which is quite costly.
