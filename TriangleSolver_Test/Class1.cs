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



	}
}
