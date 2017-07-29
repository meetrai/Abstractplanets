using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Manmeet Singh
* Date: July 28,2017
* Description: The driver program class.
* Version: 0.2 - Added GiantPlanet and Terrestrial Objects meant to be printed and Readkey.
*/
namespace Abstractplanets
{
	class Program
	{
		static void Main(string[] args)
		{
				//GiantPlanet object
				GiantPlanet giantPlanet = new GiantPlanet("MARS", 190000, Convert.ToDouble(1.777 * Math.Pow(7, 18)), "Gas");
				// Printing GiantPlanet object
				Console.WriteLine(giantPlanet.ToString());
				//TerrestrialPlanet object
				TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("EARTH", 11000, Convert.ToDouble(7.992 * Math.Pow(8, 19)), true);
				//Printing terrestrialPlanet object 
				Console.WriteLine(terrestrialPlanet.ToString());
				//Read key function
				Console.ReadKey();
		}
	}
}
