using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Manmeet Singh
* Date: July 28,2017
* Description:It is a subclass of the Planet Abstract class. The class will also 
implement both the IHasMoons and IHabitable interfaces.
* Version: 0.3 - Added Constructor
*/
namespace Abstractplanets
{
	class TerrestrialPlanet : Planet
	{
		/*Private Instance Varibales*/
		private bool _oxygen;
		/*Public Constructor*/
		public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
			   : base(name, diameter, mass)
		{
			this._oxygen = oxygen;
		}




	}
}
