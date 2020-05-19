# Person of the Year Finder V1.0
An DeltaV Code 401 application designed to filter Time Magazine's person of the year as an intro to Model-View-Controller

# License
This application is licensed under an [MIT license](https://github.com/mcbarnhart/Lab11-intro-to-mvc/blob/master/LICENSE).

# Challenge
## Application Specifications
Your application should include the following:

[x] Start with an empty Web App template, with all controllers and views manually created, do not scaffold. If you are having trouble remembering the process to create a basic MVC app, refer to the Additional Resources section below for assistance.

[x] Add the MVC Middleware and include template routing (the route must be explicitly defined)

[x] Only 1 controller. The home controller, with 3 actions (2 Index, and 1 Results)

[ ] Remember the difference between HTTPGET and HTTPPOST

[ ] Upon posting back to the server, call the Results action to redirect to the results view.

[x] Views to generate the home page and search results

[x] Use a form tag to accept user input

[ ] Use Tag Helpers to help redirect you from results page to the Home page. (HINT: the _ViewImports.cshtml file may be required)

[x] Include HTML/CSS in your final product. This is required.

[ ] It doesn’t have to be fancy, just make it look nice.

[x] Enable use of static files in your website and create a style sheet and incorporate some creativity into your application.

[ ] A model class named TimePerson that contains the following properties(these are the headers of the csv file):

[x] Create a static method within this model named GetPersons that brings in the range of years, and returns List<TimePerson>.
  
[ ] Create the internal logic to read in the file, filter the data from the given inputted range using LINQ queries and Lambda expressions, and return the final filtered list of persons.

[x] Deploy your finished application to Azure

[x] Provide the deployed link in your repository README.

# Usage
Enter a date range, click submit, and you'll see returned a list of Time Magazine's Person of the Year from the selected range of years.

![Home page](https://github.com/mcbarnhart/Lab11-intro-to-mvc/blob/master/assets/poty-finder.png)

# Installation
Web-based, my friends! Simply visit the Person of the Year Finder [here](https://lab11introtomvc20200518161630.azurewebsites.net/Home/)!
