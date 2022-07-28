# BestRestaurants.Solution
####  

#### By: Sandra Tena & Grace Kostanich

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

## Description
####  This is a webpage that will allow a user to input restaurants and cuisines then view those inputs based on the cuisine they're searching for.


## Setup/Installation Requirements

* git clone https://github.com/SandraT22/BestRestaurants.Solution.git
* run $ dotnet restore in the directory: BestRestaurants
* run $ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
* run $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
* run $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
* run $ dotnet remove package MySqlConnector
* run $ dotnet run in the directory: BestRestaurants
* Read and answer the prompts in your console to try for yourself. 
* Download MySQL Work bench and create an account or sign in to your own account. Use this resource if you need support https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql & https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql
* Keep track of your username and password to use in your appsettings.json file.
* Create appsettings.json file in top of project directory and copy in the following, with the password: {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
} 
* To import the databases go to your MySQL Workbench account. 
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