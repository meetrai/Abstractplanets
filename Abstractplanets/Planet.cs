
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Manmeet Singh
* Date: July 28,2017
* Description: Abstract Planet Class
* Version: 0.2 - Added constructor and overridden method.
*/

namespace Abstractplanets
{
	
	public abstract class Planet
	{

		/* Private instance variables*/
		private double _diameter;
		private double _mass;
		private int _moonCount;
		private string _name;
		private double _orbitalPeriod;
		private int _ringCount;
		private double _rotationPeriod;


		/* public properties*/

		public double Diameter
		{
			get
			{
				return this._diameter;
			}
		}

		public double Mass
		{
			get
			{
				return this._mass;
			}
		}

		public int MoonCount
		{
			get
			{
				return this._moonCount;
			}
			set
			{
				this._moonCount = value;
			}
		}

		public string Name
		{
			get
			{
				return this._name;
			}
		}

		public double OrbitalPeriod
		{
			get
			{
				return this._orbitalPeriod;
			}
			set
			{
				this._orbitalPeriod = value;
			}
		}

		public int RingCount
		{
			get
			{
				return this._ringCount;
			}
			set
			{
				this._ringCount = value;
			}
		}

		public double RotationPeriod
		{
			get
			{
				return this._rotationPeriod;
			}

			set
			{
				this._rotationPeriod = value;
			}
		}

		

		//Construcor
		public Planet(string name, double diameter, double mass)
		{
			this._name = name;
			this._diameter = diameter;
			this._mass = mass;
		}

		//Public overridden metod

		public override string ToString()
		{
			string String = String.Empty;

			String = "Name of the planet:" + Name + "\n" + "Diameter of the planet:" + Diameter +"Km" + "\n" + "Mass of the planet:" + Mass + "M" + "\n";

			return String;

		}
	}
}

