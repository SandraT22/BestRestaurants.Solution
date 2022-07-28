# BestRestaurants.Solution
#### Keep track of vendors that contract with you and their orders.  

#### By: Sandra Tena & Grace Kostanich

## Technologies Used

* C#
* .NET
* Visual Studio Code
* MySQL
* MySQL Workbench

## Description
#### Console app that asks the user to fill out a form with the information for vendors and a form to fill out information to orders. Orders are organized by vendor and can be selected to view. 

## Setup/Installation Requirements

* git clone 
* run $ dotnet restore in the directory: BestRestaurants
* run $ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
* run $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
* run $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
* run $ dotnet remove package MySqlConnector
* run $ dotnet run in the directory: PierresBakery
* Read and answer the prompts in your console to try for yourself. 
* To import the databases...
* In the Navigator > Administration window, select Data Import/Restore.
* In Import Options select Import from Self-Contained File.
* Navigate to the file we just created.
* Under Default Schema to be Imported To, select the New button.

Enter the name of your database with _test appended to the end.
In this case to_do_list_test.
Click Ok.
* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
* After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. Our new test database will appear.



## Known Bugs

* 

## License
MIT
Copyright (c) 2022 Sandra Tena
## Contact Information
_If you have any questions or concerns, please feel free to reach out to me [via email at: sandratena06@gmail.com](mailto:sandratena06@gmail.com) or request to make a contribution. Thank you!_ 