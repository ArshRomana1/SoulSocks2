﻿Program Name= SoulSocks
Author Name = Arshdeep Singh
Program Purpose = Create an MVC ASP.NET application
using .NET core 3.1

On 4th feb we all were given a seperate topic for our assignmnet
we were supposded to create a website approprite for that product and create our company.
My product was ""Socks and I Have created a company called "SoulSocks" and my whole assignmnet will be made on that and that will be brand called.
Under my class named "Sock" I will be having 6 properties {ProductID, Brand, Material , Lenght , Colour, Price} and one additional Rating property
fot customer Review.

starting my assignment 1  (1500  15/2/2023)
-CREATED a new project called  "SoulSocks" ,under Individual Accounts.
-Once that worked then created my github Repository and connected my project to Github.(which worked fine, without any issues)
-Then Created a README.txt  File.

As soon as I tried to run the Project , I faced my first Isssue in terms of my licencing issue, for the I had to run the program through the Console and It was working fine then.  (1550)

(1705)
Added A controller ,called "SocksController.cs"
Added two methods in the Controller and changed the content according to the tutorial.  ///Ask Andrew if we need to add a another.
both methods can be accessed by 
GET: /Socks/ & GET: /Socks/Welcome/  Respectively

tried to fetch and everything is working fine so far.

For the next step I have upadted the index() method in "SocksController.cs" to
call the controller's View method.

(1745)
For the next step, I added Socks folder in the view and then added a new Item called
"index.cshtml".
In "index.cshtml" we  ran the statement return View(); from the Index method.
to view content and the template in the "index.cshtml", /Socks.
The Template showing msg after running.

(16 02 2023) 1800
As per the instruction Added a new page in the View/home called "About.cshtml", which will consist the 
information about the comapny and its staff. Also added a Link to the page in the shared navigation.
For that I added a controller method in About and called it in the <li></li>
Succesfully able to display the Link in navigation bar

1830
Changed the the header name from Index to "Product List" in the Views/Socks/index.cshtml
--Adding View is completed and finished successfully.
had troubles with uploading my assignmnet to Github, hasnt been reponding to the commits that I am trying to make.

1849
Now Added a new class called "Sock" in the Models in the file called Sock.cs
after that I have input the 6 properties that I have mentioned above and gave them appropriate data types.

""Install-Package : Package restore failed. Rolling back package changes for 'SoulSocks'."
this error messaged showes up when i ran the command for nugget package.
"Install-Package Microsoft.EntityFrameworkCore.SqlServer"- the command that I have run

(1915)
the error was fixed and my application is running perfectly so far.

Added a SoulSocksContext.cs file in the data folder.
which will create  DbSet<Sock> property for the entity set.

(1935)
Updated the Startup.cs,the connection string is passed in to the 
context by calling a method on a DbContextOptions object.
updated the appsettings.json for connection.

(1945)
Jumping into tjhe Scaffolding, No errors Yet.
In Solution Explorer, right-click the Controllers folder > Add > New Scaffolded Item.
After adding scaffolding instruction, AN ERROR OCCURED "value cannot be null(parameter connectionString)".

for this error to be resolved, I added the default connection instead of SoulSocks Connection
Changed SoulSocks Connection to  default connection in startup.cs and appseetings.json

now trying to scaffolding again(1955)
Had an  another error Regarding my Primary key ,
So I had to Change that to "ID" From "productID", I guess It will not accept the primary anything but ID

got an another error "A network-related or instance-specific error occurred while establishing a connection to SQL Server. 
The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to
allow remote connections. (provider: SQL Network Interfaces, error: 50 - Local Database Runtime error occurred. Specified LocalDB instance name is invalid.)

I had to restrat the whole project , started from stratch.
there was an issue with the Database, I spent over 90 minutes on that, at last I had to start over.

(2200)
Scaffolding done, Migrations are done
and database is populating

(1500) 02/17/2023
Resuming assignmnet 2 Hours left

(1530)
Seeded the Database with 10 enteries and changed program.cs file
also created a new class file Seeddata.cs

(1540)
ran the program , No issues yet its running Perfectely

(1549)
Added A search box, on the Basis of Brand.
which is one of the property of my Class.
Updates index.cshtml and updated an Index method in the SocksController.cs file