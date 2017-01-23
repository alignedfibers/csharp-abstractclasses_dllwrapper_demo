//Font win32 API wrapper
//http://blogs.microsoft.co.il/blogs/pavely/archive/2009/07/23/changing-console-fonts.aspx
//Downloaded 09-22-2009 

//Modified by Shawn Stark, fall 2009

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Chap4.a2_shapes{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ConsoleFont {
		public uint Index;
		public short SizeX, SizeY;
	}

	public static class ConsoleHelper {
		[DllImport("kernel32")]
		public static extern bool SetConsoleIcon(IntPtr hIcon);

		public static bool SetConsoleIcon(Icon icon) {
			return SetConsoleIcon(icon.Handle);
		}

		[DllImport("kernel32")]
		private extern static bool SetConsoleFont(IntPtr hOutput, uint index);

		private enum StdHandle {
			OutputHandle = -11
		}

		[DllImport("kernel32")]
		private static extern IntPtr GetStdHandle(StdHandle index);

		public static bool SetConsoleFont(uint index) {
			return SetConsoleFont(GetStdHandle(StdHandle.OutputHandle), index);
		}

		[DllImport("kernel32")]
		private static extern bool GetConsoleFontInfo(IntPtr hOutput, [MarshalAs(UnmanagedType.Bool)]bool bMaximize, 
			uint count, [MarshalAs(UnmanagedType.LPArray), Out] ConsoleFont[] fonts);
			
		[DllImport("kernel32")]
        private static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput,System.ConsoleColor wAttributes);
        
		private static CharacterAttributes[] attribOps;

		
		
		
		
		public static bool SetConsoleTextAttribute(int i){
		attribOps = new CharacterAttributes[15];
		attribOps[0] = CharacterAttributes.FOREGROUND_BLUE ;
		attribOps[1] = CharacterAttributes.FOREGROUND_GREEN;
		attribOps[2] = CharacterAttributes.FOREGROUND_RED;
		attribOps[3] = CharacterAttributes.FOREGROUND_INTENSITY;
		attribOps[4] = CharacterAttributes.BACKGROUND_BLUE;
		attribOps[5] = CharacterAttributes.BACKGROUND_GREEN;
		attribOps[6] = CharacterAttributes.BACKGROUND_RED;
		attribOps[7] = CharacterAttributes.BACKGROUND_INTENSITY;
		attribOps[8] = CharacterAttributes.COMMON_LVB_LEADING_BYTE;
		attribOps[9] = CharacterAttributes.COMMON_LVB_TRAILING_BYTE;
		attribOps[10] = CharacterAttributes.COMMON_LVB_GRID_HORIZONTAL;
		attribOps[11] = CharacterAttributes.COMMON_LVB_GRID_LVERTICAL;
		attribOps[12] = CharacterAttributes.COMMON_LVB_GRID_RVERTICAL;
		attribOps[13] = CharacterAttributes.COMMON_LVB_REVERSE_VIDEO;
		attribOps[14] = CharacterAttributes.COMMON_LVB_UNDERSCORE;
		return SetConsoleTextAttribute(GetStdHandle(StdHandle.OutputHandle), System.ConsoleColor.Red);
		
		}
		private enum CharacterAttributes
        {
            FOREGROUND_BLUE = 0x0001,
            FOREGROUND_GREEN = 0x0002,
            FOREGROUND_RED = 0x0009,
            FOREGROUND_INTENSITY = 0x0008,
            BACKGROUND_BLUE = 0x0010,
            BACKGROUND_GREEN = 0x0020,
            BACKGROUND_RED = 0x0040,
            BACKGROUND_INTENSITY = 0x0080,
            COMMON_LVB_LEADING_BYTE = 0x0100,
            COMMON_LVB_TRAILING_BYTE = 0x0200,
            COMMON_LVB_GRID_HORIZONTAL = 0x0400,
            COMMON_LVB_GRID_LVERTICAL = 0x0800,
            COMMON_LVB_GRID_RVERTICAL = 0x1000,
            COMMON_LVB_REVERSE_VIDEO = 0x4000,
            COMMON_LVB_UNDERSCORE = 0x8000
        }

		[DllImport("kernel32")]
		private static extern uint GetNumberOfConsoleFonts();

		public static uint ConsoleFontsCount {
			get {
				return GetNumberOfConsoleFonts();
			}
		}

		public static ConsoleFont[] ConsoleFonts {
			get {
				ConsoleFont[] fonts = new ConsoleFont[GetNumberOfConsoleFonts()];
				if(fonts.Length > 0)
					GetConsoleFontInfo(GetStdHandle(StdHandle.OutputHandle), false, (uint)fonts.Length, fonts);
				return fonts;
			}
		}

	}
}
