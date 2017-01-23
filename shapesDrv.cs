using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

/* Written by Shawn Stark, fall 2009 
 
				    _    _ ___ __    __  __ __  __    ____ __  
				   ( \/\/ )  _)  )  / _)/  \  \/  )  (_  _)  \ 
				    \    / ) _))(__( (_( () )    (     )(( () )
				     \/\/ (___)____)\__)\__/_/\/\_)   (__)\__/ 

				   ____ _  _ ___     __  __ _  _ ___  __ __   ___ 
				  (_  _) )( )  _)   / _)/  \ \( ) __)/  \  ) (  _)
				    )(  )__( ) _)  ( (_( () )  (\__ \ () )(__ ) _)
				   (__)(_)(_)___)   \__)\__/_)\_)___/\__/____)___)

		      ___ _  _  __  ___ ___    ___ ___  __   __ ___   __  __  __ 
		     / __) )( )(  )(  ,\  _)  (  ,\  ,)/  \ / _)  ,) (  )(  \/  )
			 \__ \)__( /__\ ) _/) _)   ) _/)  \ () ) (/\)  \ /__\ )    ( 
			 (___/_)(_)_)(_)_) (___)  (_) (_)\_)__/ \__/_)\_)_)(_)_/\/\_)



*/

namespace Chap4.a2_shapes
	{

		class shapesDrv 
		{
			private static int startRow;
			private static int startCol;
			
			private static bool exit;
			
			
			static void Main(string[] args){
				ConsoleHelper.SetConsoleFont(8);
				DisplayWelcome();
				startRow = Console.CursorTop+1;
				startCol = Console.CursorLeft;
				CreatePlayingField();
				DisplayDecor1();
				//clearShapeField();
				DisplayMenu();
				exit = false;
				MainLoop();
				//timerTest();
				
				



				
				
				/*
				triangle tester = new triangle();
				tester.writeShape();
				*/
				

			}
			
			private static void MainLoop(){
			
				while(exit == false){
				Console.CursorTop = startRow+10;
				Console.CursorLeft = startCol+2;
				Console.Write("                  ");
				Console.CursorTop = startRow+10;
				Console.CursorLeft = startCol+2;
				int selection = 2;	
				    Console.Write("Enter Here:: ");
				try{
						selection = Convert.ToInt32(Console.ReadLine());
                    }catch(Exception e){
                        Console.WriteLine(e);
                    }

					if(selection != 999){
					DisplayShape(selection);
					}else{
			        exit = true;
					}
				}
				return;
			}
			
			private static void DisplayShape(int shapNum){
			switch(shapNum){
				case 1:
					triangle tester1 = new triangle();
					ClearShapeField();
					tester1.writeShape((startCol+39), startRow+10);

					break;
				case 2:
					rectangle tester2 = new rectangle();
					ClearShapeField();
					tester2.writeShape((startCol+39), startRow+10);
				break;
				case 3:
					diamond tester3 = new diamond();
					ClearShapeField();
					tester3.writeShape((startCol+39), startRow+10);
				break;
			}
					
					
			}
			
			private static void ClearShapeField(){
							Console.CursorTop = startRow+10;
				            Console.CursorLeft = startCol+39;
							Console.WriteLine("                                          ");
							Console.WriteLine("                                          ");
							Console.WriteLine("                                          ");
							Console.WriteLine("                                          ");
							Console.WriteLine("                                          ");
							Console.WriteLine("                                          ");
							Console.WriteLine("                                          ");

							Console.CursorTop = startRow+1;
				            Console.CursorLeft = startCol+39;

			}
			
			
			private static void DisplayMenu(){
			Console.WriteLine("");
			Console.WriteLine("Enter a SHAPE number ");
			Console.WriteLine("");
			Console.WriteLine("1 : Triangle");
			Console.WriteLine("2 : Rectangle");
			Console.WriteLine("3 : Diamond");
			Console.WriteLine("999: Exit");
			}
			
			private static void DisplayDecor1(){
				Console.CursorTop = startRow+1;
				Console.CursorLeft = startCol+39;
				string mnu1 = "shapes shapes shapes";
				itterColoredOut(mnu1);
			}
			
			private static void timerTest(){
			
			    for(int i = 0; i < 1000; i++)
				{
				int pauseTime = 200;
				System.Threading.Thread.Sleep(pauseTime);
				  if(i > 0)
					Console.Write(new string('\b', (i-1).ToString().Length));

				  Console.Write(i.ToString());
				}

			}
			
			private static void CreatePlayingField(){
			        
			Console.CursorTop = startRow;
			ColorSwitch cswtch = new ColorSwitch();
			Console.WindowWidth = 83;
			Console.BufferWidth = 83;
            Console.WindowHeight = 44;
			Console.BufferHeight = 300;
			
			
			
					while(Console.CursorLeft < 82)
					{    				
						Console.ForegroundColor = cswtch.getNextColor();
                        Console.CursorLeft = Console.CursorLeft+1;
                        Console.Write("#");
                    }
					
					
					for(int i =0; i< 20; i++){
						Console.ForegroundColor = cswtch.getNextColor();
                        Console.SetCursorPosition(81, Console.CursorTop+1) ;
						
                        Console.Write("#");
					}
					
					int hldVal = 82;
					while(Console.CursorLeft > 2)
					{    				
						Console.ForegroundColor = cswtch.getNextColor();
						
						int my_val = startRow + 20;
						Console.CursorTop = my_val;
						Console.CursorLeft = hldVal-1;
						hldVal = hldVal-2;
                       
                        Console.Write("#");
                    }
					


			
			}
			private static void itterColoredOut(string rawStr)
			{
				
				ColorSwitch cswtch = new ColorSwitch();
				for(int i=0; i<rawStr.Length; i++){
				Console.ForegroundColor = cswtch.getNextColor();
				Console.Write(rawStr[i]);
				}
				Console.Write("\n");

		
			}
			private static void DisplayWelcome()
			{
			Console.WriteLine(@"     _    _ ___ __    __  __ __  __    ____ __     ____ _  _ ___  ");  
		    Console.WriteLine(@"    ( \/\/ )  _)  )  / _)/  \  \/  )  (_  _)  \   (_  _) )( )  _) "); 
		    Console.WriteLine(@"     \    / ) _))(__( (_( () )    (     )(( () )    )(  )__( ) _) ");
		    Console.WriteLine(@"      \/\/ (___)____)\__)\__/_/\/\_)   (__)\__/    (__)(_)(_)___) ");
			Console.WriteLine("");
		    Console.WriteLine(@"      ___ _  _  __  ___ ___    ___ ___  __   __ ___   __  __  __ ");
		    Console.WriteLine(@"     / __) )( )(  )(  ,\  _)  (  ,\  ,)/  \ / _)  ,) (  )(  \/  )");
		    Console.WriteLine(@"     \__ \)__( /__\ ) _/) _)   ) _/)  \ () ) (/\)  \ /__\ )    ( ");
		    Console.WriteLine(@"     (___/_)(_)_)(_)_) (___)  (_) (_)\_)__/ \__/_)\_)_)(_)_/\/\_)");
			}
		}
		
		public class ColorSwitch
		{
			int curIndx;
		    System.ConsoleColor[] colorList;
			
			public ColorSwitch()
			{
				curIndx = 0;
				colorList = new System.ConsoleColor[7];
				colorList[0] = System.ConsoleColor.Blue;
				colorList[1] = System.ConsoleColor.Green;
				colorList[2] = System.ConsoleColor.Red;
				colorList[3] = System.ConsoleColor.Yellow;
				colorList[4] = System.ConsoleColor.White;
				colorList[5] = System.ConsoleColor.Cyan;
				colorList[6] = System.ConsoleColor.Magenta;
	
				
			}
			
			public ConsoleColor getNextColor()
			{
				if(curIndx == 6){
				curIndx = 0;	
				}else{
				curIndx+= 1;
				}
				return colorList[curIndx];
			}			
			
		}
	}
