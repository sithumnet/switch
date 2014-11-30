switch
======

Simple Java / C# class to make user prompts using switches
in 3 easy steps

step 01 - create switch object passing your option list
Switch sw = new Switch("one","two","three","four");

step 02 - display and get the user's choice
int x = sw.get();

step 03 - handle the choice
Console.Write("Your choice was "+x);
