using System;

namespace Triangle_01 {

	public class Triangle {

		private double[] sides;
		//double[] angles; // Angle_0 is in front of Side_0 and others are the same

		public Triangle(double side0, double side1, double side2) {
			sides = new double[3] { side0, side1, side2 };
		}

		public double GetArea() {
			double p = (sides[0] + sides[1] + sides[2]) / 2;
			return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
		}

		

	}

}