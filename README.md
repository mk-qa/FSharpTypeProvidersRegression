F# Support plugin should be installed <br />
Xamarin plugin should be installed (for project NotificationChannelsFs) <br />
MSSQL Express server should be installed (for SQLTypeProvider) <br />
   `create database AdventureWorks2017;` <br />
POSTGRESQL server should be installed (for SQLTypeProviderCore) <br />
   `create user usertest with password 'test';` <br />
   `create database dbtest;` <br />
   `grant all privileges on database dbtest to testuser;` <br />


**TODO:**
1. Make sure that the "Host Type providers out-of-process" option is selected in `File | Settings | Languages & Frameworks | F#`
2. Set MSBuild SDK5 in `File | Settings | Build, Execution, Deployment | Toolset and Build`
3. Open solution <br />
   EXPECTED: 
     - There are no errors/redcode in the compatible projects
     - There are errors/redcode for type providers in the incompatible projects
     - TestCSharp - build failed (has reference to an incompatible project)
4. Set VS MSBuild in `File | Settings | Build, Execution, Deployment | Toolset and Build`
5. Reload projects <br />
   EXPECTED:
     - There are no errors/redcode in the incompatible projects
     - TestCSharp - build succeeded
8. Open and build NotificationChannelsFs projects (Make sure that VS MSBuild is selected)<br />
   EXPECTED:
     - There are no errors/redcode, build succeeded
9. Open Test1.fsx/Test2.fsx/Test3.fsx scripts from SupportSharpR project<br />
   EXPECTED:
     - There are no errors/redcode
10. Open UnitTest1.cs from TestCSharpWithFSharp project<br />
    EXPECTED:
     - There are no errors/redcode