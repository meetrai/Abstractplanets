using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Manmeet Singh
* Date: July 28,2017
* Description: Abstract Planet Class
* Version: 0.1 - Planet Class Created.
*/
namespace Abstractplanets
{
	public abstract class Planet
	{
		//Private instance variables
		private double _diameter;
		private double _mass;
		private int _moonCount;
		private string _name;
		private double _orbitalPeriod;
		private int _ringCount;
		private double _rotationPeriod;
	}
	// PUBLIC PROPERTIES

	public double Diameter
	{
		get
		{
			return this.diameter;
		}
	}

	public double Mass
	{
		get
		{
			return this.mass;
		}
	}

	public int MoonCount
	{
		get
		{
			return this.moonCount;
		}
		set
		{
			this.moonCount = value;
		}
	}

	public string Name
	{
		get
		{
			return this.name;
		}
	}

	public double OrbitalPeriod
	{
		get
		{
			return this.orbitalPeriod;
		}
		set
		{
			this.orbitalPeriod = value;
		}
	}

	public int RingCount
	{
		get
		{
			return this.ringCount;
		}
		set
		{
			this.ringCount = value;
		}
	}

	public double RotationPeriod
	{
		get
		{
			return this.rotationPeriod;
		}

		set
		{
			this.rotationPeriod = value;
		}
	}
}
