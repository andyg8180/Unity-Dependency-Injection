Unity-Dependency-Injection
==========================


The purpose of this project is to test Unity DI when you have multiple projects and dll libraries. Most examples on the web are boring calculators or all classes are coupled to the main application.

I am trying to show, in its simplest form, how to use Unity in your application with no hard references to external libraries. It should also show how you can hot swap dlls or add dlls on the fly without rebuilding the main application.

## How to Set up
1. Build the Solution
2. Take the Michael, Stacey and Tom dll's from their debug folders and drop them into the Application project's debug folder
3. Run the solution

It is important to know that this is testing a scenario in which you have 3 lines of businesses who all do the same thing but have no clue that they exist...  

###Configuration (app.config)
There are three unity containers in the app config: unitySingleLine, unitySingleNamed, unityMultiNamed. Each one can run independently. Your application does not need to use a specific container name, you can just use "unity" instead of "unitySingleLine," for example.

