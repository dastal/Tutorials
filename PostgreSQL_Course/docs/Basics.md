
## How to Create a Database ##
First of all, to get help, just type the command `help` into the terminal. Then, there are the most important commands listed. With `\?` we can get even more help.  To get a list of all the databases that we created yet, type in the command `\l`. 

To create a new database, we have to enter the command `CREATE DATABASE test;`. It does not matter if we use uppercase or lower case, but in order to know which commands are SQL-specific or not, the preferred way is to use upper case letters for the SQL commands. Also, make sure that the commands are finished with a semicolon `;`, otherwise the commands will not be executed.

As soon as we entered the command `CREATE DATABASE test;`, the next line shows the answer `CREATE DATABASE`, which means that the database has been created successfully. By checking the list of all databases with `\l`, we see that the test database was created:

![Test Database in List](images/list_with_test_db.png)


## Connect to Database ##
The command to connect to the database is `\c test`, and we are conneted to the database. If we want then to connect to antother database, we have to enter `\c <name of the other database>`, and psql switches to the database.

## A very Dangerous Command ##
To delete a database, use the command `DROP DATABASE <database name>;`. But this is a very dangerous command. Let us imagine that we have a database that has several years of history. If we now delete the database, all its content is deleted forever and there is no way to get that data back. So if we want to delete the database we must be absolutely sure that we want to delete it. In any case we must make sure that we access rights to this functionality such that only people with the respective rights have access to it. Another possibility is to have a backup of the databse. 

## How to Create Tables ##
Have a look at the following command:

```
CREATE TABLE table_name {
	Column name + data type + constraints if any
}
```

First we have to hand in the `CREATE TABLE` command followed by the table name. Inside the curly bracktes we add the columns, where we have to define the table name, the data type and the constraints if there are any.

```sql
CREATE TABLE person ()
	id INT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	gender VARCHAR(7),
	date_of_birth TIMESTAMP,
)
```

`VARCHAR` means we can have a string with the maximum length of 50 characters. This ist the [list](https://www.postgresql.org/docs/current/datatype.html) with all the data types that are supported in Postgres. 

## Creating Tables without Constraints ##
Connect to the databse. To create the first table, we need to enter the command like we defined it above:

```sql
CREATE TABLE person ()
	id INT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	gender VARCHAR(7),
	date_of_birth TIMESTAMP,
)
```

During entering the command into the command line, make sure not to use tabs. Further, as soon as the parenthesis is openend, we can press enter for a new line. As soon as we write the closed parenthesis, we can add a semicolon and sql terminal will recognize this as the end of the command.

We can check which tables we have already entered by entering `\d` which will make a list of all the tables contained in the databse. There we should find the newly inserted table "person". With the command `\d person` we can find only the table "person" with all its columns and constraints.

![Table person](images/table_person.png)

## Creating Tables with Constraints ##
To influence the behaviour of a user, we can insert so called constraints, which must be satisfied, otherwise the data cannot be inserted. In the table that we inserted in the previous section, the user can insert a person without any data, all the columns could be null. To improve that we can specify the contraints.

An insertion of a table with constraints by using the example table "person" would look as follows:

```sql
CREATE TABLE person (
	id BIGSERIAL NOT NULL PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	gender VARCHAR(5) NOT NULL,
	date_of_birth DATE NOT NULL
)
```

We improved the insertion with:
- `BIGSERIAL` -> numbers that are incremented by themselves, so we do not have to implement an id incement each time a person was inserted into the table
- `NOT NULL` -> means that the attribute cannot be inserted empty
- `PRIMARY KEY` -> this attribute identifies the person uniquley (usually an ID)

So we drop the table that we inserted in the last section by using the command `DROP TABLE person;`. Then we insert the new table person with all the constaints. Now by checking the tables by entering `\d`, we notiice that there are two new tables:

![Two Tables](images/two_tables.png)

The reason why we have two tables now ist because of the `BIGSERIAL` that we defined for the attribute `id`. `BIGSERIAL` is an auto increment number, and as we can see in the column `Typ`, we see that it is not a new table, but only a sequence.

Checking the table by entering `\d person` shows us the whole new table:

![Table Person with Contraints](images/table_person_with_contraints.png)


So as we can see, the attributes were inserted with all the contraints that we defined.

## Insert Into ##
(55:57)