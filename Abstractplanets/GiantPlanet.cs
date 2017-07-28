using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Manmeet Singh
* Date: July 28,2017
* Description: This class  is a subclass of the Planet Abstract class. The class will also 
implement both the IHasMoons and IHasRings interfaces
* Version: 0.2 Added Constructor and Public methods to the class
*/
namespace Abstractplanets
{
	class GiantPlanet : Planet
	{
		/*Private instance variables*/
		private string _type;
		/*Constructor*/
		public GiantPlanet(string name, double diameter, double mass, string type)
				: base(name, diameter, mass)
		{
			this._type = type;
		}

		//Public Methods
		public bool HasMoons()
		{
			if (MoonCount > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool HasRings()
		{
			if (RingCount > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
