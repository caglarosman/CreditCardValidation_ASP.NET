# OnlineBookStore
 
 # 1. INTRODUCTION
 
In this project, we made a desktop application where users can sign up and buy products in
different categories. Two types of users can enter the application, the first is the customer login
and the other is the admin login. If the customer has a registered account, they can log in to the
application, if they do not have an account, they can create a new account by clicking the
"create an account" text. When logging in to the application, you can see the username and
name at the top left, access the day date and time information at the bottom left, and log out
with the "logout" button if desired. At the same time, the customer can switch between 3
different categories (books, magazines, music/cd) and click on the image of the product they
want, access the detailed information about the product on the pop-up screen, and add as many
products as they want to the shopping cart. If he/she cannot find the desired product in any
category, he/she can search for the product name and access that product using the "Search
Button". It can be displayed in the shopping cart with the "My Cart" button on the left panel.
He/she can see the products he added to his/her cart in a list box and can remove the product
from his/her cart by double-clicking on the product he/she wants to remove from his/her cart.
He/she can see the total amount of his/her basket at the bottom right, and he/she can delete all
the products in his/her basket with the "delete all products" button, and his/her can buy the
products in his/her basket with the "buy" button. The invoice containing the purchased products
is sent to the user via e-mail. If an admin log in, in addition to everything the customer can do,
they can add and remove products to any category they want through the "admin panel", update
the product they want, and with the "clear" button, they can delete the text boxes containing
the information about the product they have created.

# 2. DESIGN

a. Login & Sign-Up Screens

![image](https://user-images.githubusercontent.com/93661411/140268351-db04c1a1-d1a6-485d-95f3-9207397bc06c.png)

The application starts with login screen. If the person has a user account, he/she can access the
application via this screen. If the person is an admin, he/she also can access the application via
their admin username and password. If the person is not sure about the password what he/she
wrote, by clicking the “show password” image the person can see his/her password. In sign-up
screen the person can sign up with his/her information, except admin. A user can only be given
admin authority over the database.

Main Menu
Books

![image](https://user-images.githubusercontent.com/93661411/140268412-e4df2424-72f2-4e69-9790-8408f3bba49f.png)

Magazines

![image](https://user-images.githubusercontent.com/93661411/140268423-bfa743fb-b433-4457-b1d7-fdb3b8b55773.png)

Music/CD

![image](https://user-images.githubusercontent.com/93661411/140268517-a7af58eb-a2f1-4281-9482-38bfc3e64188.png)

When using the search button

![image](https://user-images.githubusercontent.com/93661411/140268540-267b24dc-d876-4549-a1a3-a057ef390f90.png)

The Pop-up Screen

![image](https://user-images.githubusercontent.com/93661411/140268561-1941ada3-c800-40a9-ad9e-96bc50ab38f8.png)


When the user entered the application, he/she sees main menu. Main menu starts with books,
he/she can change categories by clicking on their names and click on the image of the product
they want, access the detailed information about the product on the pop-up screen, and add as
many products as they want to the shopping cart. If they did not find the product they want,
they can search the name of the product via the “Search Button”. By using “My Cart” button,
they can see their shopping cart. 

b. My Cart

![image](https://user-images.githubusercontent.com/93661411/140268603-8444e449-9256-4007-a4e2-91c9eb93d731.png)

The user can see products which he/she added to his/her shopping cart in this page. If
he/she wants to remove a product, he/she can double click the product he/she wants to
remove or to remove all product he/she can use “Remove All” button. Our bookstore
has just 2 payment type; cash and credit card. If the user chooses credit cart as payment
type, he/she must input his/her credit card information. After purchasing the products
in the shopping cart, the invoice goes to the mail.

Invoice Mail

![image](https://user-images.githubusercontent.com/93661411/140268622-5d3177de-7335-4daa-830e-6bee8c717442.png)

Admin Panel

![image](https://user-images.githubusercontent.com/93661411/140268662-511f0923-e124-47b1-91a4-a15b99a3b2e9.png)

This page is the Admin Panel, if you an admin, you can access to this page and you can
control products from database with this panel. To update a product, you must enter the
name of the product right, because the application access to product with the name and 
you can update all the information except the product name. If you want to delete the
product you can do it just with the product name.


c. UML Diagram

![OnlineBookStore_UMLDiagram](https://user-images.githubusercontent.com/93661411/140268728-99265448-4377-47b8-a250-a18d2dc68a1c.png)


d. Design Patterns That We Used

Singleton Design Pattern

![image](https://user-images.githubusercontent.com/93661411/140268766-e6515f5e-5ffc-40d4-b548-9fc489354d8b.png)

![image](https://user-images.githubusercontent.com/93661411/140268775-14d59eb4-9c6d-4eaa-8277-045103c68b32.png)

We used 2 design patterns in our project. First, Singleton Design Pattern, and the second
one is Strategy Design Pattern. To make our code more readable, firstly we used
Singleton Design Pattern for “ShoppingCart” class. As a result, each user can only have
one shopping cart. We decided to use this design pattern in the “ShoppingCart” class in
order not to overload the RAM.

Strategy Design Pattern

![image](https://user-images.githubusercontent.com/93661411/140268799-f9444283-0652-43f4-a4d4-8711f910e24b.png)

![image](https://user-images.githubusercontent.com/93661411/140268813-87bdeecf-b2d2-4195-b815-65e09a43b30f.png)

![image](https://user-images.githubusercontent.com/93661411/140268824-4003ca5f-e4b3-4483-a49a-35afc578bc4b.png)

![image](https://user-images.githubusercontent.com/93661411/140268836-5aba28c2-7bb9-409f-ba49-4d59b68b9e93.png)

The purpose of using this pattern is to make database connections in different SQL types
(MySQL, MSSQL). We created a class called “IDataBaseConnection”, this interface class has
3 function which called “Connect, Open and Close”. Classes that inherit this interface populate
these functions according to their connection types. We also have “SQLCreator” class, and the
purpose of this class ensures the continuity of the program by taking the MySQL or MSSQL
type object we created into the parameter of the interface type in the constructor function it
contains, finding its own specific SQL type with the help of polymorphism and running its
functions.

# Note: This study was done with teammates.

Thank you for reading...






