Mettle
=======

Mettle is a firmware debug tool that will show the inner workings of your Arduino or any other micro controller project. There are tools to display analog values, Digital state, State machine operation with real time updates and a way to display model specific messages.

No longer are your debug messages just dumped to a terminal with no organization or structure.
The firmware still sends debug messages in plain human readable text. It can send any text you want at any time. But when you want to display a value, state etc you put it in a tag. 

A tag consists of a beginning character, '>' A module name, a comma, a tag name, another comma, data, then an ending character, '<'. 

An example is; <br>
 \>Modulename,Tagname,TagData<

or better; <br>
 \>Main System, BodyTemp,986< 

Note that all numbers are integers

This is the test/demo app for the Mettle Lib where all the custom control code is

To use Mettle;
0. Create a C# windows FormView Application in Visual Studio 2013

1. Copy Mettlelib.dll into your project.
	MyProject\bin\Debug
	
2. Add a reference to it.
	Right click 'References' in Solution explorer and browse for the MettleLib.dll
	
3. Add a "using MettleLib;" statement to your form

4. Add a Mettle object;
	MettleHead myMettle = new MettleHead();
	
5. In form load add a call to find controls and references to optional handlers
	private void Form1_Load(object sender, EventArgs e)
	{
		myMettle.FindControlls(this);

		//these handlers are all Optional
		myMettle.TagLine += new MettleHead.TagLIneHandeler(NewLIneRecieved);
		myMettle.TagEvents += new MettleHead.TagHandeler(MyUpdate);
		myMettle.TagErrorEvent +=new MettleHead.ErrorHandeler(myErrorHandeler);
	}
	
6. call myMettle.Open() with the com port and baud rate desired
	Mettle willl now handle all serial traffic, parse the tags and update all Mettle controls.
	You don not need to create a thread for Mettle, it's all done in the DLL
	
7. See the demo application for excruiating detail
