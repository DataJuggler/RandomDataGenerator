# RandomDataGenerator
Random Data Generator populates sample member and address data for testing C# / SQL Server applications.

I know there are lots of other programs out there that do this; this is primarily a demo for the following projects:

1. DataTier.Net
2. DataJuggler.Win.Controls (project & NuGet package)
3. DataJuggler.Core.RandomShuffler (project & NuGet package)

Also this project is used to compare DataTier.Net verse Entity Framework speeds.

A video is coming soon for this project.

To run this project:
1. Create a SQL Server database named RandomData

2. Unzip the zip file RandomDataGenerator\SQL\RandomData Database Schema And Data.zip

3. Execute the SQL File RandomData Database Schema And Data.sql unzipped from step 2

4. Clone RandomDataGenerator from https://github.com/DataJuggler/RandomDataGenerator

5. Set project RandomData Generator as the start up project.
Note: All the code is in the Code folder of the repo: RandomDataGenerator\Code

6. Set both connection strings in the app.config file to point to the new RandomDataGeneratorDatabase

tip: If you clone DataTier.Net https://github.com/DataJuggler/DataTier.Net the tools folder contains
a Connection String Builder project in the Tools folder.

7. Run Random Data Generator

8. DataTier.Net is selected by default, but you may switch it to Entity Framework 

9. By default 10,000 Members is the default amount to create. 

In the current state, DataTier.Net is much faster due to using stored procedures, even though DataTier.Net makes a
trip to the server for ever record where Entity Framework saves 50 at a time.

DataTier.Net performs this all in one pass. Entity Framework is currently using two passes.

I am seeking an Entity Framework volunteer to help me fix the Virtual issue; if I set the Address property to Virtual 
my save stops working with EF. 

This is one of the biggest reasons I prefer DataTier.Net over EF is the ease of getting the last error.

Entity Framework will just not save (sometimes) and not throw any errors.

In contract, if DataTier.Net does not save, you can easily check for the last error like this:

// perform the save
saved = gateway.SaveMember(ref member);

// if the save failed
if (!saved)
{
    // get the last error if any (always check for null as there may not be an error)
    Exception error = gateway.GetLastException();
}

Note: Consider this app to be a 'Wizard'. If you start the app in DataTier.Net, you must finish with DataTier.Net
or vice versa. 

To run the app again it is best to start over.

This app fills in two tables Member & Address. 

The view MemberAddressView is a convenient way to view the data:

Select * From MemberAddressView

This project currently contains references to BenchMarkDotNet NuGet package, and this adds a lot of NuGet packages.
So many NuGet packages, that after you restore NuGet packages, and update you have to update again because the
updates have updates.

