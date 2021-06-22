# RentAhotelRoom-ASP.NET

First commit.
I used the scaffolding from Visual Studio as a base for the project.

Second commit.
I created a page called Hotels that acts like a list for all hotels and the amount of rooms 
they contain. The page has been added to the navigation bar as well.
/TODO: Make it editable for Admin only.

Third commit.
I created a Search page, where you can check if a specific hotel is a part of the website.

Fourth commit.
I removed HotelTotalRooms from the Hotels table, so that it doesn't duplicate with the Details function.
Added simple authentication that forces the user to log into an account if they want to add/edit/delete something.

Fifth commit.
I Added HotelRooms Page, Controller, Model, View and gave it simple Authorization.
HotelRooms is the page where you check for free rooms and occupy one by giving your name and date of occupation.
/TODO: Make it editable for Admin only or make it so you can't occupy an already taken troom.