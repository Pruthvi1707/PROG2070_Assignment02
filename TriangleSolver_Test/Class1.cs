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



	}
}
