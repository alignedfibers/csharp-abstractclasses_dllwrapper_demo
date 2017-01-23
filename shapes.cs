using System;

//Written by Shawn Stark fall 2009

namespace Chap4.a2_shapes{
	public abstract class shapes{
		private static int shapeCount;
		protected string shapeTxt;
		
		public shapes(){
		shapeCount = 0;
		}
		
		/**************************************************
		Writes a shape to the console.
		Common method to all classes that derive from this one.
		***************************************************/
		public void writeShape(int col, int row){
		Console.CursorTop = row;
		Console.CursorLeft = col;
		
		Console.Write(this.getShapeText());
		//Console.WriteLine("\n               Shape Count Now Equals "+getCount());
		Console.Beep(650, 60);
		Console.Title = "Testing Shawn's Shape Class";

		}
		
		/*************************************************
		A couple of abstract methods that must be overridden
		in all subclasses
		**************************************************/
		protected abstract string getShapeText();
		protected abstract void setShapeText();
		
		/*************************************************
		A static method to increment count. 
		Can not be referenced as an instance method.
		
		It is a static class member and must be used
		within the class heirarchy because it is protected.
		**************************************************/
		protected static void incrementCount(){
		shapeCount++;
		}
		
		
		public int getCount(){
		return shapeCount;
		}
		
		
	}
	
	public class triangle : shapes{
		
		
		public triangle(){
			this.setShapeText();
			incrementCount();
			
		}
		protected override string getShapeText(){
			return this.shapeTxt;
		}
		protected override void setShapeText(){
		this.shapeTxt = "\n"+
		                "               Triangle......\n"+        
		                "                                 *     \n"+
		                "                                ***    \n"+
						"                               *****   \n"+
						"                              *******  \n";
		//this.shapeTxt = @" ^ "+"\n"+@"/ \"+"\n"+@" _ ";
	
		}
		
	}
	
		public class rectangle : shapes{
		
		
		public rectangle(){
			this.setShapeText();
			incrementCount();
			
		}
		protected override string getShapeText(){
			return this.shapeTxt;
		}
		protected override void setShapeText(){
		this.shapeTxt = "\n"+
		                "               rectangle......\n"+        
		                "                        ***********    \n"+
		                "                        ***********    \n"+
						"                        ***********   \n"+
						"                        ***********  \n";
		//this.shapeTxt = @" ^ "+"\n"+@"/ \"+"\n"+@" _ ";
	
		}
		
	}
	
		public class diamond : shapes{
		
		
		public diamond(){
			this.setShapeText();
			incrementCount();
			
		}
		protected override string getShapeText(){
			return this.shapeTxt;
		}
		protected override void setShapeText(){
		this.shapeTxt = "\n"+
		                "               Diamond......\n"+        
		                "                                 *     \n"+
		                "                               *****   \n"+
						"                             ********* \n"+
						"                               *****   \n"+
						"                                 *     \n";
						
						
						
		//this.shapeTxt = @" ^ "+"\n"+@"/ \"+"\n"+@" _ ";
	
		}
		
	}
}