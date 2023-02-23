
## Exporting Query Results to CSV ##
In this part we are going to learn how we can generate a CSV file using postgres. Therefore we have to be aware of the following two steps:

1. Selection of the data
2. Exporting the slection to a CSV file

The follwoing command can be used:

```sql
\copy (SELECT * FROM person LEFT JOIN car ON car.id = person.car_id) TO '<Output destination in file storage> + <filename>.csv' DELIMITER ',' CSV HEADER;
```

- Make sure that you give the file a name
- The `DELIMITER` keyword is used to indicate how the data shall be stored in the CSV file
- THE `CSV HEADER` keyword indicates that the headers should be attached to the file

## Serial & Sequences ##
(3:50:42)