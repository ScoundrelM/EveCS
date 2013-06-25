using System;
using System.Collections.Generic;
using System.Linq;

namespace EveCharacterStatus
{
	
	public interface IConsoleWriter
	{
		/** 
		 * This method writes to the console, inserting a new line at the end
		 * of the text
		 */
    	void WriteLine(string format, params object[] args);
	}	
	
	public class SpyConsoleWriter : IConsoleWriter 
	{
		
		public List<string> format;
		public List<object[]> args;
		public List<string> written;
		
		public SpyConsoleWriter() {	
			format = new List<string>();
			args = new List<object[]>();
			written = new List<string>();
		}
		
    	public void WriteLine(string format, params object[] args)
		{
			this.format.Add(format);
			this.args.Add(args);
			this.written.Add(String.Format(format, args));
		}
		
		public string lastFormat() {
			return format.Last();
		}
		
		public object[] lastArgs() {
			return args.Last();
		}
		
		public string lastWritten() {
			return written.Last();
		}	
	}
		
	
	public class ConsoleWriter : IConsoleWriter
	{
		public ConsoleWriter() {
		}
		
		public void WriteLine(string format, params object[] args) {
			Console.WriteLine(format, args[0], args[1], args[2], args[3]);
		}
	}
}

