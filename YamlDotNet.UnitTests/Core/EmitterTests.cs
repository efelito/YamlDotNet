using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace YamlDotNet.UnitTests
{
	[TestFixture]
	public class EmitterTests : YamlTest
	{
		private void ParseAndEmit(string name) {
			string testText = YamlFile(name).ReadToEnd();

			Parser parser = new Parser(new StringReader(testText));
			using(StringWriter output = new StringWriter()) {
				Emitter emitter = new Emitter(output, 2, int.MaxValue, false);
				while(parser.MoveNext()) {
					//Console.WriteLine(parser.Current.GetType().Name);
					
					emitter.Emit(parser.Current);
				}
				
				string result = output.ToString();
				
				Console.WriteLine();
				Console.WriteLine("------------------------------");
				Console.WriteLine();
				Console.WriteLine(testText);
				Console.WriteLine();
				Console.WriteLine("------------------------------");
				Console.WriteLine();
				Console.WriteLine(result);
				Console.WriteLine();
				Console.WriteLine("------------------------------");
				Console.WriteLine();

				/*
				Parser resultParser = new Parser(new StringReader(result));
				while(resultParser.MoveNext()) {
					Console.WriteLine(resultParser.Current.GetType().Name);
				}
				*/
				/*
				
				if(testText != result) {
					Console.WriteLine();
					Console.WriteLine("------------------------------");
					Console.WriteLine();
					Console.WriteLine("Expected:");
					Console.WriteLine();
					Console.WriteLine(testText);
					Console.WriteLine();
					Console.WriteLine("------------------------------");
					Console.WriteLine();
					Console.WriteLine("Result:");
					Console.WriteLine();
					Console.WriteLine(result);
					Console.WriteLine();
					Console.WriteLine("------------------------------");
					Console.WriteLine();
				}
				
				Assert.AreEqual(testText, result, "The emitter did not generate the correct text.");
				*/
			}
		}
		
		[Test]
		public void EmitExample1()
		{
			ParseAndEmit("test1.yaml");
		}
		
		[Test]
		public void EmitExample2()
		{
			ParseAndEmit("test2.yaml");
		}
		
		[Test]
		public void EmitExample3()
		{
			ParseAndEmit("test3.yaml");
		}
		
		[Test]
		public void EmitExample4()
		{
			ParseAndEmit("test4.yaml");
		}
		
		[Test]
		public void EmitExample5()
		{
			ParseAndEmit("test5.yaml");
		}
		
		[Test]
		public void EmitExample6()
		{
			ParseAndEmit("test6.yaml");
		}
		
		[Test]
		public void EmitExample7()
		{
			ParseAndEmit("test7.yaml");
		}
		
		[Test]
		public void EmitExample8()
		{
			ParseAndEmit("test8.yaml");
		}
		
		[Test]
		public void EmitExample9()
		{
			ParseAndEmit("test9.yaml");
		}
		
		[Test]
		public void EmitExample10()
		{
			ParseAndEmit("test10.yaml");
		}
		
		[Test]
		public void EmitExample11()
		{
			ParseAndEmit("test11.yaml");
		}
		
		[Test]
		public void EmitExample12()
		{
			ParseAndEmit("test12.yaml");
		}
		
		[Test]
		public void EmitExample13()
		{
			ParseAndEmit("test13.yaml");
		}
		
		[Test]
		public void EmitExample14()
		{
			ParseAndEmit("test14.yaml");
		}
	}
}