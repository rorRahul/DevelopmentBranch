********* Instructions to follow for the MovieBank application ***************

The MovieBank folder contains two Projects:
	1- MovieAPI
	2- MovieLibrary
	
How it works:
	1- MovieAPI : The serveice provider a Pre Condition -> The API should be running with correct host URL 
					to provide JSON Data services to MovieLibrary application
	
	2- MovieLibrary => A C# WPF Application, the consumer which has the User Interface consisting 3 Tabs for all the functionalities:
	
		Tab1=> Home Page : A DataGrid showing 4 movies with Year (decending Order) with Search Button taking inputs from ComboBox & TextBox
			
			ForExample : 
			
			a- Combox may have selected with "Year" and 
			b- The year (2013, 2014) will be entered in TextBox then
			c- Press Search Button
				
		Tab2=> Search Movie : Showing all the movies with search applied in Home Page
			
			a- User can select any movie in Datagrid and 
			b- Press Button to show all the information for selected movie.
			
		Tab3=> Movie Page : A combination of multiple controls are avilable to show the complete information for the selected movie