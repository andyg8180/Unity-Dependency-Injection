Unity-Dependency-Injection
==========================


The purpose of this project is to test Unity DI when you have multiple projects and dll libraries. All of the examples on the web are boring calculators or couple all the dlls to the main application.

I am trying to show, in its simplest form, how to use Unity in your application when your application has no hard references to any outside libraries. It should also show how you can hot swap dlls or add dlls on the fly without rebuilding the main application.

## How to Set up
1. Build the Solution
2. Take the Michael, Stacey and Tom dll's from their debug folders and drop them into the Application project's debug folder
3. Run the solution

It is important to know that this is testing a scenario in which you have 3 lines of businesses who all do the same thing but have no clue that they exist...  

