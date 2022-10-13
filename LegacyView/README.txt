//A detailed README with step by step information to project completion

2022-10-04 1123
	- Created a new ASP.NET MVC project
	- The project is named LegacyView and will be used to store information about DVDs.
	- The project has HTTPS configured 
	- It uses individual User account authentication
	- Go to Properties folder and open the launchSettings.json. Comment out "sslPort": 44349 as no admin rights are present in the college system.
		(Ignore for personal computer with admin rights)

	

2022-10-06 1001
	- First begin by re-building code
	- Run to test everything works

	1015
	- Everything works well.
	- Let us define the problem statement:
		- To create an ASP.NET MVC project for the given product (DVD).
		  Also, note details of the object and review the architecture 
		  of a robust MVC web application to generate a product catalogue 
		  allowing for CRUD operations.

		- Update the GitHub repository, and also add a README.md to contain
		  a preview of the project.
	
	1042
	- Created the new README.md file to hold overview of project.
	
	1044
	- Defining the properties for the product DVD:
		•	DVDId – Primary key
		•	DVDName – Title of DVD
		•	DVDGenre – Genre of DVD
		•	DVDDescription – Some information on the DVD
		•	DVDPrice – Cost of DVD
		•	DVDReleaseDate – date of release of DVD
		•	DVDPoster – Image of DVD cover (static)
		•	DVDCustomerReview – Customer Review of DVD

	1047
	- Start creating the MVC. 
	- Begin with creating the model for DVD. 
	
	1152
	- Created the model class. Yet to test it. Saving changes for now.
	- Due to short time, the posters are just going to be static images and not stored in DB

2022-10-10 1044
	- Continuing with the project.
	- First rebuilt the application.
	- Ran the system, everything works well.
	- Added the nuget package for EF : Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1
	- Ran to check application again. Works fine.
	- Now creating context class.

	1100
	- Added the nuget packages and other required dependencies for EF.
	- Built the system for precaution.
	- Now going to scaffold the CRUD pages.

	1106
	- Created the CRUD Pages using scaffolding. 
	- Still cannot run the application as the DB does not exist.
	- Will first push the changes to github before beginning the next step.

	1109
	- GitHub now up to date.
	- Begin by adding the migrations.

	1559
	- Added the migration and updated the database. 
	- The application now runs displaying the table for DVDs.
	- The deps.json warning still remains (only on mac machine) although does not cause error.
	- As this is a virtual machine, update db, i.e., apply migrations from browser as well (just click on apply migration).
	- Pushed the migrations to GitHub as well.
	- Now have to test adding DVDs.

	0408
	- Tested the application. The CRUD functionalities work well.
	- Pushing changes to GitHub.

	
	0507
	- Added the seed data.
	- Updated Program.cs file to reference SeedData.
	- deleted the contents from application to test SeedData

	0509
	- Tested the app. Everything works fine.
	- Pushing changes to GitHub before continuing.

	 0533
	 - Changed the display names and added some data annotations in DVD.cs file
	 - Checked the app. Everything runs fine.
	 - Moving on to adding Search capability.

	 0611
	 - Added search functionality.
	 - Tested app for search via URL. Everything works fine.

	 0618
	 - Added form to search.
	 - Pushing changes to GitHub before continuing.
	 - Next is to add Search using genre.

	 0813
	 - Added all required classes and fields for search by genre.
	 - Will now test the application.

	 0815
	 - Tested the app. Everything works fine.
	 - As the project requires us to have 5 properties apart from customer review, I will add an additional field.
	 - But first, push all changes to GitHub.

	 0939
	 - Added new field for production company
	 - Updated CRUD to accomodate new field
	 - Updated SeedData as well.
	 - Now need to add and update migrations

	 0949
	 - new column added.
	 - will now delete data to add the seed data with additional column.

	 0958
	 - Seeded data
	 - App works fine
	 - Now push changes to GitHub

	 1001
	 - Pushed data to GitHub
	 - Add some validation now

	 1022
	 - Added some validation and appropriate datatypes
	 - tested the app, it works fine
	 - Will now push to GitHub
	 - Then need to add page for about us and update links.

	 1045
	 - updated links for DVD list
	 - updated the data in pages
	 - Added new about us page
	 - Updated controller and views for new page
	 - tested app, works fine
	 - push to GitHub now

	 1055
	 - Added content to about us page
	 - tested the app, works well
	 - to do: change the default style and add posters for DVDs
	 - now push to GitHub

	 2022-10-11 0925
	 - Will now continue by changing the default style.
	 - first update-database,  build and test code
	 - built and tested code, evrything works fine.

	 1136
	 - Added new style pages and styles
	 - app tested to work ok
	 - push changes to GitHub

	 1310
	 - Continuing with styling.
	 - Build and test app first. Looks good

	 1426
	 - Added style to DVD Pages and other Pages as well.
	 - Tested everything, works fine
	 - Push code now to GitHub
	
	1437
	- Initially though of adding posters, but as db content looks heavy, will add some static images instead
	- have to update copyright year to be updatable

	1447
	- Updated the year and tested app
	- push to github
	- to do: add images, publish to azure

	1524
	- Added images and tested app
	- looks good
	- push to GitHub and then begin deployment

	2022-10-13 1013
	- Build and test app. 
	- Trying deployment on college system for Windows OS.
	- The username and password for server are: nsalauddin (WEB452proj)
	- connection string: Data Source=coredbserverlv.database.windows.net,1433;Initial Catalog=coreDb;User ID=nsalauddin;Password=WEB452proj
	- college sys ip addr: 204.225.7.240

	1124
	- Added the data to allow publish
	- changed Startup.cs and appSettings.json to hold connection string
	- commented port for college system, will change back on personal system
	- got error on publish : HTTP Error 500.30 - ANCM In-Process Start Failure
	- will check on personal system

	1128
	- remove http port comment
	- the publish breaks the code
	- have now reverted to old version on localhost.
	- checked app, works fine

	1243
	- Tried from home machine, app now published
	- however, db does not work as unable to update db from mac.
	- will try to use Windows machine
	- everything else, i.e., static pages works well on azure
	- the localhost app works as well.
	- push changes to GitHub now.
	- Changes made to Startup.cs and appSettings.json

	1323
	- tried with windows machine, still an error in db on azure.
	- local still works
	- pushing changes to git. 
	- will check the app once from mac before submitting
