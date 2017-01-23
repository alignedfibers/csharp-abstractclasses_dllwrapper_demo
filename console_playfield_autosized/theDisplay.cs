using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Chap6.exmpls.mathclasses{
	class playingFieldWriter
	{
		
		private class fieldWriter{
		
			private int maxLength;
			private ArrayList lineIndexer 
			public static fieldWriter(int sRow, int sCol, int lBound, int rBound){
			}
			public void writeLine()//throws outOfboundsErr
			{
				
			}
			private void verifyStringLength()//throws exceedsMaxLengthErr
			{
			}
			private void clearLineNum(int indx)//throws outOfBoundsErr
			{
			}
		}
		public void playingFieldWriter(int sRow, int sCol, int height, bool splitScrn){
		
			
		}
		
		private static void CreatePlayingField(){
			        
			Console.CursorTop = startRow;
			ColorSwitch cswtch = new ColorSwitch();
			/*
			Console.WriteLine(Console.WindowWidth);
			Console.WriteLine(Console.BufferWidth);
            Console.WriteLine(Console.WindowHeight);
			Console.WriteLine(Console.BufferHeight);
			*/
			
			/*Console.WindowWidth = 83;
			Console.BufferWidth = 83;
            Console.WindowHeight = 44;
			Console.BufferHeight = 300;*/
			
			
			
			
					while(Console.CursorLeft < (int)Console.WindowWidth-2)
					{    				
						Console.ForegroundColor = cswtch.getNextColor();
                        Console.CursorLeft = Console.CursorLeft+1;
                        Console.Write("#");
                    }
					
					
					for(int i =0; i< 10; i++){
						Console.ForegroundColor = cswtch.getNextColor();
                        Console.SetCursorPosition((int)Console.WindowWidth-2, Console.CursorTop+2) ;
						
                        Console.Write("#");
					}
					
					int hldVal = (int)Console.WindowWidth-3;
					while(Console.CursorLeft > startCol)
					{    				
						Console.ForegroundColor = cswtch.getNextColor();
						if(startRow+20 < (int)Console.BufferHeight)
						{
							int my_val = startRow + 20;
							Console.CursorTop = my_val;
							Console.CursorLeft = hldVal-1;
							hldVal = hldVal-2;
                       
                            Console.Write("#");
							if(startRow+startRow+20 >= (int)Console.BufferHeight-1){
							//Console.WriteLine("Exceeded One");
							Console.BufferHeight = Console.BufferHeight+300;
							}
						}
						else{
						Console.Write("exceeded buffer size");
						}
                    }
					for(int i =9; i > 0; i--){
						Console.ForegroundColor = cswtch.getNextColor();
                        Console.SetCursorPosition(startCol-1, Console.CursorTop-2) ;
						
                        Console.Write("#");
					}
					


			
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


