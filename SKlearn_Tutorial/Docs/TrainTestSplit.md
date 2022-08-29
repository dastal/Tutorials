# Train Test Split
First we need to initialize a new project and a `main.py` file.

## Main File

### Dataset
For testing issues we import the sklearn iris dataset, a sklearn built in dataset.

### Method (Example, nothing to do with the iris dataset)
We have a dataset which represents the hours a student has studied vs. good/bad grades. Our sample includes the data of ten students, from which we will use the data of 8 students to train the model and with the remaining two students we will predict with the model. This will give us the accuracy of the model. 

### Train Test Split
Sklearn offers us the function `train_test_split` which makes it possible to actually separate our data into a train and a test sample.

```python
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2)
```

Now we have a sample for training (`X_train`, `y_train`) and another sample for testing (`X_test`, `y_test`).  The variable `test_size` is used to determine the ratio between the training set and the testing set, in our case the size of the testing set is 20% of the total size of the sample.


In general the training sample should be bigger than the testing sample, but the testing sample should also be in a significant size, otherwise our model will not be accurate enough.
