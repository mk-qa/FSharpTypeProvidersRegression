F# Support plugin should be installed <br />
MSSQL Express server should be installed (for SQLTypeProvider) <br />
   `create database AdventureWorks2017;` <br />
POSTGRESQL server should be installed (for SQLTypeProviderCore) <br />
   `create user usertest with password 'test';` <br />
   `create database dbtest;` <br />
   `grant all privileges on database dbtest to testuser;` <br />


**TODO:**
1. Make sure that the "Host Type providers out-of-process" option is selected in `File | Settings | Languages & Frameworks | F#`
2. Set MSBuild SDK in `File | Settings | Build, Execution, Deployment | Toolset and Build`
3. Open solution <br />
   EXPECTED: 
     - There are no errors/redcode in the compatible projects
     - There are errors/redcode for type providers in the incompatible projects
4. Set VS MSBuild in `File | Settings | Build, Execution, Deployment | Toolset and Build` <br />
   EXPECTED:
     - There are no errors/redcode in the incompatible projects
5. Open Test1.fsx/Test2.fsx/Test3.fsx scripts from SupportSharpR project<br />
   EXPECTED:
     - There are no errors/redcode
6. Open UnitTest1.cs from TestCSharpWithFSharp project<br />
    EXPECTED:
     - There are no errors/redcode
