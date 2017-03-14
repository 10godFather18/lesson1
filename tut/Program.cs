/*
 * Created by SharpDevelop.
 * User: Александр
 * Date: 25.09.2016
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace tut
{
	class Program
	{
		public static void One()
		{
			string a = "Ответ: ";
		    double b = 5;
		    double c = 2;
		    Console.WriteLine(a + (b/c).ToString());
		}
		
		public static void Two()
		{
			double a = 0;
			double b = 0;
			double c = 0;
			double d = 0;
			
			a = Double.Parse(Console.ReadLine());
			b = Double.Parse(Console.ReadLine());
			c = Double.Parse(Console.ReadLine());
			d = Double.Parse(Console.ReadLine());
			
			if( ((a > b) && (c == d)) || ((d==a) && (d!=c)))
			{
				Console.WriteLine("Ок");
			}else if((a!=b) && (a!=c))
			{
				Console.WriteLine("Второй вариант");
			}else
			{
				Console.WriteLine("Беда беда");
			}
		}
				
		public static void Three()
		{
			for (int i = 0; i < 10; i++) {
				if(i == 5)
				{
					Console.WriteLine("5 итераций");
					break;
				}
			}
		}
		
		public static void Four()
		{
			Random r = new Random();
			List<int> mas = new List<int>();
			int a = 0;
			
			for(int i = 0; i < 10; i++)
			{
				mas.Add(0);
			}
			
			
			for (int i = 0; i < 10; i++) 
			{
			    F:
					a = r.Next(1,100);
					if(mas.Contains(a))
					{
						goto F;
					}else{
						mas[i] = a;
					}	
			}
			mas.Sort();
			mas.Add(101);
			foreach(int d in mas)
			{
				Console.WriteLine(d + " ");
			}
		}
		
		public static void Five()
		{
		    string a;
			F:
				for (int i = 0; i < 2; i++) {
					a = Console.ReadLine();
					goto F;
				}
		}
		
	    public static void Six()
		{
			string a = "qwertypasdfgpzxcvb";
			string b = "йцуфывячс";
			string c = a+b;
		}
				
		public static void Seven()
		{
			Directory.CreateDirectory("C://vs/");
			Directory.CreateDirectory("C://vs/folder/");
			File.WriteAllText("C://vs/folder/Hello.txt", "O_o");
			FileStream filestream = new FileStream("C://vs/folder/Hello.txt", FileMode.Open);
			StreamReader streamreader = new StreamReader(filestream);
			Console.WriteLine(streamreader.ReadToEnd());
			streamreader.Close();
		}
		
		public static void Main(string[] args)
		{
		}
	}
}