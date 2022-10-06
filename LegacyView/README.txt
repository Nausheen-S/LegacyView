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
	- Move on to scaffolding the MVC for LegacyView

