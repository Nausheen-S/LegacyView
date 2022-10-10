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