#include <iostream>
#define GLEW_STATIC
#include <glew.h>
#define SDL_MAIN_HANDLED
#include "defines.h"
#include "vertex_buffer.h"

#ifdef _WIN32
#include <SDL.h>
#pragma comment(lib, "SDL2.lib")
#pragma comment(lib, "glew32s.lib")
#pragma comment(lib, "opengl32.lib")
#else
#include <SDL2/SDL.h>
#endif

int main(int arg, char** argv) {
	// Creating SDL Window
	SDL_Window* window;
	SDL_Init(SDL_INIT_EVERYTHING);

	// specification of the very color channel and alpha of the buffer, standard value 8bit such that every graphic card should be able to process the value
	SDL_GL_SetAttribute(SDL_GL_RED_SIZE, 8);
	SDL_GL_SetAttribute(SDL_GL_GREEN_SIZE, 8);
	SDL_GL_SetAttribute(SDL_GL_BLUE_SIZE, 8);
	SDL_GL_SetAttribute(SDL_GL_ALPHA_SIZE, 8);
	// means that every pixel has 32bit
	SDL_GL_SetAttribute(SDL_GL_BUFFER_SIZE, 32);
	SDL_GL_SetAttribute(SDL_GL_DOUBLEBUFFER, 1);

	window = SDL_CreateWindow("C++ OpenGL Tutorial", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 800, 600, SDL_WINDOW_OPENGL);
	SDL_GLContext glContext = SDL_GL_CreateContext(window);

	// Initializing Glew
	GLenum err = glewInit();
	if (err != GLEW_OK) {
		std::cout << "Error: " << glewGetErrorString(err) << std::endl;
		std::cin.get();
		return -1;
	}
	// Query the OpenGL version of the graphics card
	std::cout << "OpenGL version: " << glGetString(GL_VERSION) << std::endl;

	// Initialize the triangle
	Vertex vertices[] = {
		Vertex{-0.5f, -0.5f, 0.0f},
		Vertex{0.0f, 0.5f, 0.0f},
		Vertex{0.5f, -0.5f, 0.0f}
	};
	// Save the number of vertices
	uint32 numVertices = 3;

	VertexBuffer vertexBuffer(vertices, numVertices);

	/* No need for the next part since we created a separate buffer
	// Create the variable for the buffer
	GLuint vertexBuffer;
	// Create a buffer on the GPU to fill it with our data
	glGenBuffers(1, &vertexBuffer);
	//std::cout << vertexBuffer << std::endl;		// Print the "pointer"
	// Binding the buffer
	glBindBuffer(GL_ARRAY_BUFFER, vertexBuffer);
	// Sending data to the buffer
	glBufferData(GL_ARRAY_BUFFER, numVertices * sizeof(Vertex), vertices, GL_STATIC_DRAW);*/

	// Handle Messages
	bool close = false;
	while (!close) {
		// clearing the buffer to avoid displaying leftovers of old buffers
		glClearColor(0.0f, 0.0f, 0.0f, 1.0f);		// Tells which color shall be used to clear -> saves the color, so everytime glClear is called it uses this color. Can also be used outside the while loop.
		//glClearColor(1.0f, 0.0f, 0.0f, 1.0f);		// red window
		// (r,g,b,alpha)
		glClear(GL_COLOR_BUFFER_BIT);				// Clears the window

		/*// Using the old pipeline
		glBegin(GL_TRIANGLES);		// Starts drawing
		// Here inbetween we can draw our triangle
		glVertex2f(-0.5f, -0.5f);	// 2D
		glVertex2f(0.0f, 0.5f);
		glVertex2f(0.5f, -0.5f);
		glEnd();					// Ends drawing
		*/

		// Vertex binding
		vertexBuffer.bind();

		// Drawing the Trianlge
		glDrawArrays(GL_TRIANGLES, 0, numVertices);

		// Vertex unbinding
		vertexBuffer.unBind();

		// Frame Buffer (show something in the window, otherwise it's empty)
		SDL_GL_SwapWindow(window);

		SDL_Event event;
		while (SDL_PollEvent(&event)) {
			if (event.type == SDL_QUIT) {
				close = true;
			}
		}
	}

	return 0;
}
