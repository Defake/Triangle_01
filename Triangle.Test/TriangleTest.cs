using System;
using Triangle_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Test {

	[TestClass]
	public class TriangleTest {
		
		/* Here must be at least and only 3 arguments! */
		private void TestAlgorithm(double[] sides, double[] angles, double expectedArea) {
			Triangle_01.Triangle tr;

			if (sides.Length == 3)
				tr = Factory.CreateTriangleThreeSides(sides[0], sides[1], sides[2]);
			else if (sides.Length == 2)
				tr = Factory.CreateTriangleTwoSidesAndAngle(sides[0], sides[1], angles[0]);
			else
				tr = Factory.CreateTriangleOneSideTwoAngles(sides[0], angles[0], angles[1]);

			Assert.AreEqual(expectedArea, tr.GetArea(), 0.0001);

		}

		[TestMethod]
		public void EgyptTriangleOneSide() {
			TestAlgorithm(new double[] { 3 }, new double[] { 90f, 53.13 }, 6);
		}

		[TestMethod]
		public void EgyptTriangleTwoSides() {
			TestAlgorithm(new double[] { 3, 4 }, new double[] { 90f }, 6);
		}

		[TestMethod]
		public void ThreeSidesTest() {
			TestAlgorithm(new double[] { 3, 4, 5 }, new double[0], 6);
		}
		
	}
}
