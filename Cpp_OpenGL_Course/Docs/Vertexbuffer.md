# Vertexbuffer

## Defining the Vertex
First of all we need to define the vertex which has three points. Therefore we use the following code:

```cpp
struct Vertex {
	float32 x;
	float32 y;
	float32 z;
};
```

**Important:** In this case the vertex only has position attributes (here a three dimensional point). In latter cases we can also add texture coordinates, colors, etc.

## Initialize a Trinagle
Now since the vertex was defined, we can enter the points of a tringale into an array. Therefore we use the following code:

```cpp
Vertex vertices[] = {
	Vertex{-0.5f, -0.5f, 0.0f},
	Vertex{0.0f, 0.5f, 0.0f},
	Vertex{0.5f, -0.5f, 0.0f}
};
```

We also need to save the number of vertices:

```cpp
int32 numVertices = 3;
```

## Buffer
We need a buffer on the GPU to"feed" it wsith our data.

### Create that Buffer
First we need to get the place weher the buffer is saved, then we can creat the buffer using the follwing code:

```cpp
GLuint vertexBuffer;
glGenBuffers(1, &vertexBuffer);
```

### Binding the Buffer
Next we need to bin the buffer using the following code:

```cpp
lBindBuffer(GL_ARRAY_BUFFER, vertexBuffer);
```

### Sending the Data to the Buffer
```cpp
glBufferData(GL_ARRAY_BUFFER, numVertices * sizeof(Vertex), vertices, GL_STATIC_DRAW);
```

## Activate the first Attribute in OpenGL
Now we need to activate the first Attribute of OpenGL at the position (0,0,0). Therefore we use the code:

```cpp
glEnableVertexAttribArray(0);
```

If we did not initialze this point. OpenGl would not draw anythimg.

## Tell OpenGL how the Attribute is built
Next we need to define how the attribute is built. Therefore we use the code:

```cpp
glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(Vertex), (void*)offsetof(struct Vertex,x));
```

, whereas the `3` in the second position stands for "3-dimensional",  and the `(void*)offsetof(struct Vertex,x)` tells OpenGL with which attribute in the vertex it has to start drawing.

## Drawing the Triangle
To actually draw the triangle, we need to insert the following line of code into the while-loop:

```cpp
glDrawArrays(GL_TRIANGLES, 0, numVertices);
```

Running the project should now show the following triangle:

<img src="Images/second_triangle.JPG" alt="Second Triangle" width="500"/>
