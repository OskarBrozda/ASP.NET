# Photo Gallery Application - ASP.NET
### Contents

1. Getting Started

- Tech Stack
- Dependencies
  
2. Installation and configuration
   
- How to run the app
- How to seed data

3. Accounts

4. Project overview
- Authorization
- App overview with different roles


## Getting started
### Tech stack

ASP.NET Core 7.0

### Dependencies

- Visual Studio
- SQL Lite 

## Installation and configuration

### How to run the app
- Clone the repository from Github
- Open the project in Visual Studio
- To run the application, press the green button on top of the page

### How to seed data

In order to seed the data and users into the database, you have to create a migration.<br>
Move into the project directory and use below commands:


```bash
dotnet tool install --global dotnet-ef
```
```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```
```bash
dotnet ef migrations add DataMigration
```
```bash
dotnet ef database update
```
These commands will generate a migration that will be applied to the database.

## Accounts

The migration process creates two user accounts with different privileges:

**ADMIN**
- Login: oskar@wsei.edu.pl
- Password: zaq1@WSX

**USER**
- Login: zuzia@wsei.edu.pl
- Password: xsw2!QAZ

## Project overview
### Authorization
 **LOGIN**
 
 In the header of the page, there is a login button which redirect user to login page. On this page user can input their Email address and Password in order to log in.
 
 <img width="1440" alt="Login Page" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/4047232f-c24b-4595-8397-f3d5e77d1035">

  **REGISTER**
 
 In the header of the page, there is a register button which redirect user to register page. In order to register, user need to input their Email address and Password twice.
 After the user registers a new account, they can log into it on the login page.

 <img width="1440" alt="Register Page" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/07fb0a86-da32-4c39-9310-f63da042dbaf">

## App overview with different roles

### UNAUTHORIZED
When the user is unauthorized they have access to:

 - browse photo galleries
<img width="1440" alt="gallery" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/2168b27a-fb14-4291-8c90-a7d4c2e91884">

- add loves
<img width="1440" alt="adding love" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/b27cfbf4-7384-4d5f-a29c-4f1ad44d3e6f">


### USER
When normal user is logged on top of unauthorized permissions they also have access to: 

- details of the photo
<img width="1440" alt="details of photo" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/7df5e286-b646-472c-95a0-1fae9ae5e447">

- add new photo
<img width="1440" alt="new photo" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/8575b2d8-a614-4729-8cee-f15b2b5f94ba">

- downolad the photo
<img width="1440" alt="download's photo" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/0c4de38f-9c19-4ca2-af65-efd4d0f13025">

- browse the authors list
<img width="1440" alt="author's list" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/2fb5615a-6009-4623-8109-9b70f70a4b1b">

- view details about the author
<img width="1440" alt="author details" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/61534f58-a8e1-4a9a-b7ed-42e12da6da54">



### ADMIN
When admin is logged on top of unauthorized permissions they also have access to: 

- main page
<img width="1440" alt="admin main page" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/2d13ce2d-26ec-45e4-afa5-9c6996e436fa">

- edit existing photo
<img width="1440" alt="edit photo" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/65e17841-c99f-48a9-942e-db781a235105">

- delete photo
<img width="1440" alt="delete photo" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/a06b975c-dd85-4193-9300-4ed08738eba8">

- author's page
<img width="1440" alt="authors page" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/22e263f2-930d-4201-8406-ce6f5277a549">

- edit existing author
<img width="1440" alt="edit author" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/7437f7e9-e259-48e1-bde3-16badb11dd01">

- delete autor
<img width="1440" alt="delete author" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/918dbb58-f4e4-46d5-a031-124420770f62">

- adding new author
<img width="1440" alt="adding author" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/f63ec9d5-d3cf-4c88-8122-2bbdcb20b0c3">

- browsing the users list
<img width="1440" alt="users list" src="https://github.com/OskarBrozda/ASP.NET/assets/115191646/28510e5a-79e4-4429-9eef-c9cfcc92189f">



