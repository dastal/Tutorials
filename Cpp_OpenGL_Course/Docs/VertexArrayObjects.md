# Vertex Array Objects

## Introduction
If we need more than one buffer, it makes sense to exclude the buffer into a class which makes everytime a new buffer. 

## `defines.h`
The class `defines.h` includes the typedefinitions which are needed and it was excluded to use them in different classes.

### `vertex_buffer.h`
`VertexBuffer(void* data, uint32 numVertices)` takes the data and the numVertices to build the shape.

### `bind()`
Binds the buffer.

### `unBind()`
Unbinds the buffer.
