#pragma once
#include <glew.h>
#include "defines.h"

// Struct default class public, same as when making normal class public
struct VertexBuffer {
	VertexBuffer(void* data, uint32 numVertices) {
		// vao saves the buffer and the layout
		glGenVertexArrays(1, &vao);
		glBindVertexArray(vao);

		glGenBuffers(1, &bufferId);
		glBindBuffer(GL_ARRAY_BUFFER, bufferId);
		glBufferData(GL_ARRAY_BUFFER, numVertices * sizeof(Vertex), data, GL_STATIC_DRAW);

		// Activate the first attribute in OpenGL at position (0,0,0)
		glEnableVertexAttribArray(0);
		// Tell OpenGL how the attribute is built
		glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(Vertex), (void*)offsetof(struct Vertex, x));		// The 3 stands for 3D

		glBindVertexArray(0);
	}

	virtual ~VertexBuffer() {
		glDeleteBuffers(1, &bufferId);
	}

	void bind() {
		/* Becomes useless because of vao
		glBindBuffer(GL_ARRAY_BUFFER, bufferId);
		glEnableVertexAttribArray(0);
		glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(Vertex), (void*)offsetof(struct Vertex, x));
		*/
		glBindVertexArray(vao);
	}

	void unBind() {
		/* Becomes useless because of vao
		glBindBuffer(GL_ARRAY_BUFFER, 0); // The 0 means that we dont bind a buffer anymore
		*/
		glBindVertexArray(0);
	}

private:
	GLuint bufferId;
	GLuint vao;
};
