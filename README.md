<!DOCTYPE html>

<html>
<body>
  
 <h1>These are some small projects i made using C# and .Net Framework.<h/1>
  
  
   <h2>Car Insurance Quote</h2>
     &nbsp;&nbsp;&nbsp;&nbsp;This app is an ASP.NET MVC web App that calculates a car insurance quote based on information provided by the user. ADO.NET Entity Data Model was used to create the Insuree data model used in the application and Bootstrap is used for basic styling. This app contains a Home Controller, Admin Controller, and an Insuree Controller along with corresponding views to render information to the user. The Admin view passe in a view model to limit the information sent to the Admin while the Admin Controller contains methods view to display all quotes that have been issued and stored in the database. The Insuree Controller contains a GetQuote method that calculates a monthly quote based on user-provided information passed in through a form on the webpage. Once the quote has been calculated, the quote is displayed to the user via the Insuree details view.
   <h2>Newsletter Sign-Up</h2>
   &nbsp;&nbsp;&nbsp;&nbsp;This is simple ASP.NET MVC web app used to get and keep track of newsletter signups. ADO.NET is used to send/retrieve information to/from the Newsletter SQL database. There is an Admin and Home controller along with corresponding views to render the information to the user using Bootstrap styling. The Home view uses a simple form to collect signup information from the user, and the Home Controller SignUp method stores this informatin in a database. The Admin view passes in a viewmodel as a list to limit information sent directly to the Admin page. The Admin Controller contains a function to retrieve user information from the database and an unsubscribe function to update the database that a user has unsubscribed from the newsletter.
   <h2>Branch Shipping Quote</h2>
   &nbsp;&nbsp;&nbsp;&nbsp;This project is a simple console app that gets input from the user and either generates a shipping quote or notifies the user that their package cannot be shipped if it is too heavy or too large to be shipped.
</body>
   


![c-uses-966x569](https://user-images.githubusercontent.com/118482231/211778061-5ce9562a-6d85-4f62-93b9-f2ad4c48064b.png)


   
   
   </html>
