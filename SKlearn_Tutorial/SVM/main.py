from sklearn import datasets
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn import svm
from sklearn.metrics import accuracy_score

iris = datasets.load_iris()

# split it in features and labels
X = iris.data
y = iris.target

# To keep track of the classes
classes = ['Iris Setosa', 'Iris Versicolour', 'Iris Virginica']

print(X.shape)
print(y.shape)

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2)

# Create the model
model = svm.SVC()
model.fit(X_train, y_train)

print(model)

# Predictions
predictions = model.predict(X_test)
acc = accuracy_score(y_test, predictions)

print('predictions: ', predictions)
print('actual: ', y_test)
print('accuracy: ', acc)

# Print the predicted classes
for i in range(len(predictions)):
    print(classes[predictions[i]])