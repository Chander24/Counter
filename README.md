# Counter
A small program to open a text file, find a number, and increment, decrement, or reset a counter

This program works by opening a text file and finding a number in it. Once it finds the number, it either adds 1, subtracts 1, or resets to 0 based on the command line arguments passed in.

To run the program, you can either open the .sln and build it using Visual Studio, or you can grab the Counter.exe located in bin\Debug. Please make sure to also grab Counter.exe.config as you will need it below. Copy this to any location on your file system that you'd like.

The text file can be located anywhere on your system and can say anything you want, but it must be a .txt extension. You can configure the location of the Text File by opening up the Counter.exe.config file and updating the "FilePath" key's value.

To integrate with OBS, navigate to the Scene you want to add the counter to and add a new "Text (GDI+)" Source. Name it whatever you want (e.g. "Counter") and check "Read from file". Navigate to the location of the file and open your .txt file which the Program will update (this is the same file that you configured as the FilePath in the Counter.exe.config). From there, you can change teh font, transform the text, or do any other edits that OBS allows.

To integreate with Stream-Pi, connect your Stream-Pi client to your server. On the server, add 3 new "Run Executable" blocks to your layout (at the current time of writing, this is located under the "Essentials" drop-down). For "Executable Location", navigate to the location of Counter.exe - all 3 blocks will have the same Executable location. For adding 1 to the counter, put "add" in the Arguments field. For subtracting 1 from the counter, put "sub" in the Arguments field. For resetting the counter, put "reset" in the Arguments field.

An example .txt file can be found in the "Examples" folder, and Sample icons can be found in the "Sample" folder.

Please contact me for any questions on integration.
