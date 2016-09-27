using System;

namespace Triangle_01 {

	public class Triangle {

		private double[] edges;
		//double[] angles; // Angle_0 is in front of Edge_0 and others are the same

		public Triangle(double edge0, double edge1, double edge2) {
			edges = new double[3] { edge0, edge1, edge2 };
		}

		public static Triangle CreateByThreeEdges(double edge0, double edge1, double edge2) {
			CheckAreEdgesValid(edge0, edge1, edge2);
            return new Triangle(edge0, edge1, edge2);
		}

		public static Triangle CreateByTwoEdgesAndAngle(double edge0, double edge1, double angle) {
			CheckAreEdgesValid(edge0, edge1);
			CheckAreAnglesValid(angle);
			return new Triangle(edge0, edge1, Math.Sqrt(edge0 * edge0 + edge1 * edge1 - 2 * edge0 * edge1 * Math.Cos(ToRad(angle))));
		}

		public static Triangle CreateByOneEdgeTwoAngles(double edge0, double angle1, double angle2) {
			CheckAreEdgesValid(edge0);
			CheckAreAnglesValid(angle1, angle2);
			var angle0 = 180 - angle2 - angle1;
			return new Triangle(edge0,
								Math.Sin(ToRad(angle1)) * edge0 / Math.Sin(ToRad(angle0)),
								Math.Sin(ToRad(angle2)) * edge0 / Math.Sin(ToRad(angle0)));
		}

		public double GetArea() {
			double p = (edges[0] + edges[1] + edges[2]) / 2;
			return Math.Sqrt(p * (p - edges[0]) * (p - edges[1]) * (p - edges[2]));
		}

		private static double ToRad(double angle) {
			return Math.PI * angle / 180f;
		}

		/* Data checks */

		private static void CheckAreEdgesValid(params double[] edges) {
			foreach (var edge in edges) {
				if (edge <= 0)
					throw new ArgumentException("An edge should always be greater than zero!");
			}
		}

		private static void CheckAreAnglesValid(params double[] angles) {
			foreach (var angle in angles) {
				if (angle <= 0)
					throw new ArgumentException("An angle should always be greater than zero!");
				else if (angle >= 180)
					throw new ArgumentException("An angle should always be less than 180!");
			}
		}

	}

}