using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Test {

	using Triangle_01;

	[TestClass]
	public class TriangleTest {

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Should_ThrowException_When_OneEdgeIsZero() {
			var edgeNormal = 2;
			var edgeZero = 0;
			var tr = Triangle.CreateByThreeEdges(edgeNormal, edgeNormal, edgeZero);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Should_ThrowException_When_OneEdgeIsBelowZero() {
			var edgeAboveZero = 2;
			var edgeBelowZero = -100500;
			var tr = Triangle.CreateByThreeEdges(edgeAboveZero, edgeAboveZero, edgeBelowZero);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Should_ThrowException_When_AnAngleIsBelowZero() {
			var edgeUsual = 2;
			var angleNormal = 60;
			var angleBelowZero = -10;
			var tr = Triangle.CreateByTwoEdgesAndAngle(edgeUsual, angleNormal, angleBelowZero);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Should_ThrowException_When_AnAngleIsGreaterThan180() {
			var edgeUsual = 2;
			var angleNormal = 60;
			var angleTooBig = 8796549;
			var tr = Triangle.CreateByOneEdgeTwoAngles(edgeUsual, angleNormal, angleTooBig);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Should_ThrowException_When_AnAngleIsEqual180() {
			var edgeUsual = 2;
			var angleNormal = 60;
			var angle180 = 180;
			var tr = Triangle.CreateByOneEdgeTwoAngles(edgeUsual, angle180, angleNormal);
		}

		[TestMethod]
		public void Should_AreaIsEqual6_When_TriangleCreatedByEdge_3_AndAngles_90_53p13() {
			var tr = Triangle.CreateByOneEdgeTwoAngles(3, 90f, 53.13);
			Assert.AreEqual(6, tr.GetArea(), 0.0001);
		}

		[TestMethod]
		public void Should_AreaIsEqual6_When_TriangleCreatedByEdges_3_4_AndAngle_90() {
			var tr = Triangle.CreateByTwoEdgesAndAngle(3, 4, 90);
			Assert.AreEqual(6, tr.GetArea(), 0.0001);
		}

		[TestMethod]
		public void Should_AreaIsEqual6_When_TriangleCreatedByEdges_3_4_5() {
			var tr = Triangle.CreateByThreeEdges(3, 4, 5);
			Assert.AreEqual(6, tr.GetArea(), 0.0001);
		}

	}
}
