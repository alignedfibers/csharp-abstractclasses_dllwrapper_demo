@echo off
csc /t:library shapes.cs
csc /t:library ConsoleHelper.cs
csc shapesDrv.cs /r:shapes.dll /r:ConsoleHelper.dll
shapesDrv