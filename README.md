# MyMvcProject
NbuProgrammingInDotNet
---
Created a web application using ASP.NET MVC 5 and Entity Framework 6. 
1. Business domain and purpose. 
	- book store 
	- books have category;
	- each category has many books;
	- logged user can view/modify books;

2. Used ASP.NET Identity to implement user management. The project has the following implement:
    - user registration
    - user registration with 3-rd party provider - Facebook
    - extended user profile - on registration user can provide a url with his profile picture which can be viewed in his profile page.
    - user login
    - user logout
    - forgotten password

3. Used Database to store your data
    - Used Code First approach - seed method implemented.
    - Used all CRUD operations on a Database (Create, Read, Update, Delete) - implemented for Book entities.
    - Used LINQ to Entities for your DB operations - implemented in services layer.

4. Business domain controllers with several actions each
	- Books
	- Categories

5. Action Filter and Custom Databinding
	- implemented Automapper
	- view models
	- input models

6. Caching
	- cached was implemented for categories. they are not expected to be changed rarely. 
	- cache service implemented.

7. Security 
    - Use client and server side data validation - check input view models
    - Use ASP.NET MVC tools for preventing Cross-Site Request Forgery (CSRF) and Cross-Site Scripting (XSS) - with anti forgery token.

8. User interface 
	- used bootstrap & js (jQuery)
