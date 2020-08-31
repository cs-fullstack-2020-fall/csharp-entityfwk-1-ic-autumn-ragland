# csharp-entityfwk-1-ic
Introduction to the Entity Framework

### Exercise 1
Create an MVC application called `EFIntroductionMVC` using the `-o` option

Create a new controller called `HousePartyController`

Create a model called `HousePartyInvitee` with the following properties:

HousePartyInvitee:
- vipName
- isAttending
- numberOfHousePartiesAttended
- age

* Create a `DbContext` called `InviteeContext` in new subdirectory called `Dao`
* Create a `DbSet` called `Invitees`
  * Create a Sqlite configuration string in `appsettings.json` using
  ```
    "ConnectionStrings" : {
    "DefaultDBConnection" : "DataSource=blog.db"
  }
  ```
* Run the entity framework commands to:
  * Create Migrations
  * Apply migrations to the database
  * Use the Sqlite Plug-in to ensure the database was created
  
1. In your controller implement the following endpoints:

`ListInvites` that will return a simple list (using Content()) of all invites in the database

`AddInvite` that will accept a `POST` message with the properties in the body and create a new invite in database

`ModifyInvite` that will accept a `PUT` message with the properties in the body and update an existing invite in database that matches the passed in `vipName`

`DeleteInvite` that will accept a `DELETE` message and an `vipName` and delete the matching invite from the database by `vipName`

2. *Create PostMan Tests for all cases and export to your repo*

### Exercise 2
Create a console application called `EFIntroduction` using the `-o` option

Create a wrapper class called `EFIntroductionWrapper`

Create a model called `Product` with the following properties:

Product:
- productID - int
- productName - string
- price - string
- quantity - string

* Create a `DbContext` called `ProductContext`
  * Use Sqlite configuration with a `Data Source` equal to `products.db`
* Create a `DbSet` called `Products`
* Run the entity framework commands to:
  * Create Migrations
  * Apply migrations to the database
  * Use the Sqlite Plug-in to ensure the database was created
* Instantiate your `EFIntroductionWrapper` wrapper class
  * Add a method to your wrapper class that:
  1. Creates 3 products in the database then lists all the products from the database
  2. Queries the database and just returns one Product given a specific product name to filter on and prints it out
  3. Update the `quantity` of the product retrieved in #2 and prints out the updated product
  4. Delete the product retrieved in #2 and print all the remaining products
