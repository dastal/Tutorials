import numpy as np
from sklearn.neural_network import MLPClassifier
from sklearn.metrics import confusion_matrix
import mnist
from PIL import Image

# training set
x_train = mnist.train_images()
y_train = mnist.train_labels()

# testing set
x_test = mnist.test_images()
y_test = mnist.test_labels()

# reshaping
x_train = x_train.reshape((-1, 28*28))
x_test = x_test.reshape((-1, 28*28))

# rescale the datasize
x_train = (x_train/256)
x_test = (x_test/256)

# Model
clf = MLPClassifier(solver='adam', activation='relu', hidden_layer_sizes=(64, 64))
clf.fit(x_train, y_train)

# Performance
prediction = clf.predict(x_test)

# Confusion Matrix
acc = confusion_matrix(y_test, prediction)

# Results
print(acc)


# Return the accuracy
def accuracy(cm):
    diagonal = cm.trace()
    elements = cm.sum()
    return diagonal/elements


print(accuracy(acc))

# Test it with self drawn number (5 in this case)
img = Image.open('Test_Image/test_five_1.png')
data = list(img.getdata())

for i in range(len(data)):
    data[i] = 255 - data[i]

five = np.array(data)/256

p = clf.predict([five])
print(p)
