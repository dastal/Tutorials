# Linear Regression
Ordinary least squares Linear Regression.

## Example
For this example I took the [Boston Housing Dataset](https://www.cs.toronto.edu/~delve/data/boston/bostonDetail.html). It has 14 variables in total, and I turned first 13 variables (CRIM, ZM, INDUS, CHAS, NOX, RM, AGE, DIS, RAD, TAX, PTRATIO, B, and LSTAT) into features and the last one (MEDV) into a label. The dataset has 506 cases (instances) in total.

### 1. Editing Data
Like the examples before, I edited the labels and the features. In `X` the columns are all the features and the rows are all the instances. `y` shows all the labels.

### 2. Creating the model
To use the linear regression function of sklearn, simply add:

```python
l_reg = linear_model.LinearRegression()
```

To hand the data over to the model, I splitted the data as usual:


```python
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2)
```

Then I handed the data over to the model and made the predictions by using:

```python
model = l_reg.fit(X_train, y_train)
predictions = model.predict(X_test)
```

### Results

#### Predictions
Returns the predictions of the test data.

```python
predictions = model.predict(X_test)
```

#### R^2 Value
Returns the coefficient of determination R^2 of the prediction.

```python
l_reg.score(X, y)
```

In this case the R^2 value was `0.7391548779625634`

#### Estimated coefficients
Estimated coefficients for the linear regression problem. If multiple targets are passed during the fit (y 2D), this is a 2D array of shape (n_targets, n_features), while if only one target is passed, this is a 1D array of length n_features.


```python
l_reg.coef_
```

In this case the coefficients were:

```
[-1.31293195e-01  4.28271501e-02 -2.86576221e-03  2.64593261e+00
-2.01809754e+01  3.86684431e+00  5.64696611e-04 -1.55826550e+00
3.13681993e-01 -1.03873348e-02 -9.82587532e-01  8.57187375e-03
-5.50117150e-01]
```

#### Intercept
Independent term in the linear model.

```python
l_reg.intercept_
```

In this case the value was: `38.39389293733325`
