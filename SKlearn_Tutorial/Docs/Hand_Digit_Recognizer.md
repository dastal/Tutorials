# Hand Digit Recognizer #
To have a pratical example of how we can use CNN, we will create a model that is able to recognize handwritten digits.

## Training & Testing Set ##
For the train and test set we use [MNIST](https://de.wikipedia.org/wiki/MNIST-Datenbank), which is a database that contains picutres of handwritten digits.
Its training dataset (for x_train) contains 60000 images, the testing dataset (for x_test) contains 10000 images. Both have a dimesion of 3. for both sets there are also labels
(for y_train and y_test).

To simplify x_train and x_test, we reshape it first to dimension 2, then we scale down the values such that they are between 0 and 1.

## Model ##
Learn more [here](https://scikit-learn.org/stable/modules/generated/sklearn.neural_network.MLPClassifier.html)

- `solver='adam'` the deep learning rate optimization
- `activation='relu'` the layer activation function for the hidden layers
- `hidden_layer_sizes=(64, 64)` the size of the hidden layers

## Performance ##
The performance of the model finally is 97.69% which is very good!

## GIMP ##
Download GIMP [here](https://www.gimp.org/downloads/).

As a next step I created a new picture with 28x28 pixels, then I drew the number 5 on it with the pen. I saved the picture in grayscales and as a png in my project (the folder Test_Image).
I opened it in my main file, turned it into a list and inverted the digits, since we have it as black lettering on white background, but the sample has the digits on black backgrount with white lettering.
I did this by subtracting every pixel from 255. Then I tunred the data into an np array to finally predict it with the model. The model predicted the number as a 5, which is correct.