Mettle
=======

This is a firmware debug tool that will show the inner workings of your Arduino or any other micro controller project.
There are tools to display analog values, Digital state, State machine operation with real time updates and a way to display modele specific messages.

No longer are your debug messages just dumped to a terminal with no organization or structure.

The aruino still sends debug messages in plain human readable text.
you can send any text you want at any time. But when you want to display a value, state etc you just put it in a tag.
A tag consists of a beginning character, '>' a name, a comma, data, then an ending character, '<'. An example is; >Tagname,TagData<, or better; >BodyTemp,986< not that all numbers are integeres
