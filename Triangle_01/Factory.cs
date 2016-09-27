using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_01 {

	static public class Factory {

		public static Triangle CreateTriangleThreeSides(double side0, double side1, double side2) {
			return new Triangle(side0, side1, side2);
		}

		public static Triangle CreateTriangleTwoSidesAndAngle(double side0, double side1, double angle) {
			return new Triangle(side0, side1, Math.Sqrt(side0 * side0 + side1 * side1 - 2 * side0 * side1 * Math.Cos(ToRad(angle))));
        }

		public static Triangle CreateTriangleOneSideTwoAngles(double side0, double angle1, double angle2) {
			var angle0 = 180 - angle2 - angle1;
			return new Triangle(side0,
								Math.Sin(ToRad(angle1)) * side0 / Math.Sin(ToRad(angle0)),
								Math.Sin(ToRad(angle2)) * side0 / Math.Sin(ToRad(angle0)));
		}

		private static double ToRad(double angle) {
			return Math.PI * angle / 180f;
		}

	}

}
