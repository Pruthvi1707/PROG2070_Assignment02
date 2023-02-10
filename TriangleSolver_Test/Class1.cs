using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolver_Test
{
    [TestFixture]
    public class Class1
    {


		//Only one (1) test for a valid equilateral triangle
		//(01)
		[Test]	
		public void Equilateral_AllSide60_Valid_Test()
		{
			Triangle c1 = new Triangle();
			
			int f_side = 60;
			int s_side = 60;
			int t_side = 60;

			string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//Three (3) tests for a valid isosceles triangle

		//(01)
		[Test]
		public void Isosceles_Side5And5And6_Valid_Test01()
		{
			Triangle c1 = new Triangle();

			int f_side = 5;
			int s_side = 5;
			int t_side = 6;

			string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(02)
		[Test]
		public void Isosceles_Side7And6And6_Valid_Test02()
		{
			Triangle c1 = new Triangle();

			int f_side = 7;
			int s_side = 6;
			int t_side = 6;

			string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(03)
		[Test]
		public void Isosceles_Side7And8And7_Valid_Test03()
		{
			Triangle c1 = new Triangle();

			int f_side = 7;
			int s_side = 8;
			int t_side = 7;

			string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}


		// Five (5) tests for a valid scalene triangle
		//(01)
		[Test]
		public void Scalene_Side7And8And9_Valid_Test01()
		{
			Triangle c1 = new Triangle();

			int f_side = 7;
			int s_side = 8;
			int t_side = 9;

			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(02)
		[Test]
		public void Scalene_Side9And10And11_Valid_Test02()
		{
			Triangle c1 = new Triangle();

			int f_side = 9;
			int s_side = 10;
			int t_side = 11;

			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(03)
		[Test]
		public void Scalene_Side13And12And11_Valid_Test03()
		{
			Triangle c1 = new Triangle();

			int f_side = 13;
			int s_side = 12;
			int t_side = 11;

			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(04)
		[Test]
		public void Scalene_Side13And14And12_Valid_Test04()
		{
			Triangle c1 = new Triangle();

			int f_side = 13;
			int s_side = 14;
			int t_side = 12;

			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(05)
		[Test]
		public void Scalene_Side14And15And16_Valid_Test05()
		{
			Triangle c1 = new Triangle();

			int f_side = 14;
			int s_side = 15;
			int t_side = 16;

			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}


		//Three (3) tests for verifying a zero length for one or more sides
		//(01)
		[Test]
		public void Verifying_Zero_Length_AllSideOrMore01()
		{
			Triangle c1 = new Triangle();

			int f_side = 0;
			int s_side = 1;
			int t_side = 2;

			string expected = "At least one side of your triangle has a zero length and is thus invalid";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(02)
		[Test]
		public void Verifying_Zero_Length_AllSideOrMore02()
		{
			Triangle c1 = new Triangle();

			int f_side = 10;
			int s_side = 0;
			int t_side = 0;

			string expected = "At least one side of your triangle has a zero length and is thus invalid";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(03)
		[Test]
		public void Verifying_Zero_Length_AllSideOrMore03()
		{
			Triangle c1 = new Triangle();

			int f_side = 11;
			int s_side = 12;
			int t_side = 0;

			string expected = "At least one side of your triangle has a zero length and is thus invalid";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		// Three (3) tests for verifying an invalid response (other than a zero length)
		//(01)
		[Test]
		public void Verifying_Invalid_Input_Other_Than_Zero01()
		{
			Triangle c1 = new Triangle();

			int f_side = -11;
			int s_side = 12;
			int t_side = 11;

			string expected = "Based on the values entered, the triangle is INVALID";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(02)
		[Test]
		public void Verifying_Invalid_Input_Other_Than_Zero02()
		{
			Triangle c1 = new Triangle();

			int f_side = 11;
			int s_side = -12;
			int t_side = 12;

			string expected = "Based on the values entered, the triangle is INVALID";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}

		//(03)
		[Test]
		public void Verifying_Invalid_Input_Other_Than_Zero03()
		{
			Triangle c1 = new Triangle();

			int f_side = 11;
			int s_side = 12;
			int t_side = -11;

			string expected = "Based on the values entered, the triangle is INVALID";
			string actual = c1.AnalyzeTriangle(f_side, s_side, t_side);
			Assert.AreEqual(expected, actual);
		}



	}
}
