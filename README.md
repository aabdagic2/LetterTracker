Here are the steps to run this C# console application from the command line:
1. Open project in Visual Studio or some other IDE where you can run C# console applications.
2. Locate the compiled executable file (.exe), which is in the bin directory under Debug configuration, and the .NET framework version (C:\Path\To\Your\Project\bin\Debug\net6.0\LetterTracker.exe).
3. Open Command prompt.
4. Navigate to the Directory Containing the Executable File (cd C:\Path\To\Your\Project\bin\Debug\net6.0).
5. You can run the program with this command line: LetterTracker.exe C:\Path\To\TestCases.txt (there are two test cases I used in this repository).
6. To see the exit code returned, immediately after the program runs type echo %errorlevel% in cmd to display it.
