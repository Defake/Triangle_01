using System;

namespace Triangle_01 {

	public class Triangle {

		private double[] sides;
		//double[] angles; // Angle_0 is in front of Side_0 and others are the same

		public Triangle(double[] sides) {
			this.sides = new double[3] { sides[0], sides[1], sides[2] };
			//angles = new Angle[3];
		}

		public Triangle(double[] sides, double angle) {
			//angles = new Angle[3] { new Angle(0), new Angle(0), angle };
            this.sides = new double[3] { sides[0], sides[1], Math.Sqrt(sides[0] * sides[0] + sides[1] * sides[1]
															- 2 * sides[0] * sides[1] * Math.Cos(ToRad(angle)))
								};
		}

		public Triangle(double[] sides, double angle0, double angle1) {
			//angles = new Angle[3] { angle0, angle1, new Angle(0) };
			var angle2 = 180 - angle0 - angle1;
			this.sides = new double[3] {    Math.Sin(ToRad(angle0)) * sides[0] / Math.Sin(ToRad(angle2)),
										Math.Sin(ToRad(angle1)) * sides[0] / Math.Sin(ToRad(angle2)),
										sides[0]
								};
		}

		public double GetArea() {
			double p = (sides[0] + sides[1] + sides[2]) / 2;
			return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
		}

		private double ToRad(double angle) { 
			return Math.PI * angle / 180f;
        }

	}

}