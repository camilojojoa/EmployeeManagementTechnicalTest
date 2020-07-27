# EmployeeManagementTechnicalTest
A repository to save a Technical test 

After loading the solution in Visual Studio 2017, and Before running the solution, you have to do some configuration:
Right click on Solution -> Properties, and there, in "Startup Project" section, you have to select "Multiple startup projects", then, to the projects 
"EmployeeManagement.WebApi" and "EmployeeManagement.ClientWebApi" to select "Start".

In the web.congif of the "EmployeeManagement.WebApi" project, there is a key in the AppSettings to set the url of the test api, which is the api 
"http://masglobaltestapi.azurewebsites.net/api/Employees".


In the web.congif of the "EmployeeManagement.ClientWebApi" project, there is a key in the AppSettings to set the url of the local api, which is the api 
"http://localhost:53670/Api/Employees".
