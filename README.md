# CommunityTrainingAPI
this is an ASP.NET backend API for a Community Training applicaiton


# Database viewing:
Use SQL Server Management Studio for checking the database changes


# Data migration commands:
after every database change invoking change in the code:

1. 	delete the "migrations" folder

2. 	open the "package manager consol":

2.1 	add-migration

2.1.1 	give a name for it

2.2 	update-database


# if you make new database (or application) creation based on this project dont forget:
in appsettings.json:
refactor the database nam "CommunityTrainingData" (2 occurance)
refactor in program.cs the reference for it (reactor "CommunityTrainingData")





