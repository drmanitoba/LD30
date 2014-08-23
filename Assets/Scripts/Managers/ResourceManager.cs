using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ResourceManager {

	public enum Resources {
		BuildingMaterials,
		Water,
		Crops,
		Livestock,
		SlaveLabor,
		Land,
		NuclearWeapons,
		Fuel
	}

	// 600,000 lbs
	private UInt32 buildingMaterials = 600000;
	// 5B gallons
	private UInt64 water = 5000000000;
	// 1M lbs
	private UInt32 crops = 1000000;
	// 10M animals
	private UInt32 livestock = 10000000;
	// 7M people
	private UInt32 slaveLabor = 7000000;
	// 515M sq. km
	private UInt32 land = 515000000;
	// 17,300 warheads
	private UInt32 nuclearWeapons = 17300;
	// 1B barrels
	private UInt64 fuel = 1000000000;

	public ResourceManager() {
			
	}

	public Dictionary<string, string> GetResourceList() {
		Dictionary<string, string> dict = new Dictionary<string, string>();

		foreach (Resources res in Enum.GetValues(typeof(Resources))) {
			string name;
			string value;

			name = GetResourceNameString(res);
			value = GetResourceQuantityString(res);

			dict.Add (name, value);
		}

		return dict;
	}

	public string GetResourceQuantityString(Resources res) {
		string val;

		switch(res) {
		case Resources.BuildingMaterials:
			val = String.Format("{0:N} lbs", buildingMaterials);
			break;
		case Resources.Water:
			val = String.Format("{0:N} gallons", water);
			break;
		case Resources.Crops:
			val = String.Format("{0:N} lbs", crops);
			break;
		case Resources.Livestock:
			val = String.Format("{0:N} animals", livestock);
			break;
		case Resources.SlaveLabor:
			val = String.Format("{0:N} people", slaveLabor);
			break;
		case Resources.Land:
			val = String.Format("{0:N} sq. km", land);
			break;
		case Resources.NuclearWeapons:
			val = String.Format("{0:N} warheads", nuclearWeapons);
			break;
		case Resources.Fuel:
			val = String.Format("{0:N} barrels", fuel);
			break;
		default:
			val = "You didn't provide a thing, asshole.";
			break;
		}

		return val;
	}

	public string GetResourceNameString(Resources res) {
		string val;
		
		switch(res) {
		case Resources.BuildingMaterials:
			val = "Building Materials";
			break;
		case Resources.Water:
			val = "Water";
			break;
		case Resources.Crops:
			val = "Crops";
			break;
		case Resources.Livestock:
			val = "Livestock";
			break;
		case Resources.SlaveLabor:
			val = "Slave Labor";
			break;
		case Resources.Land:
			val = "Land";
			break;
		case Resources.NuclearWeapons:
			val = "Nuclear Weapons";
			break;
		case Resources.Fuel:
			val = "Fuel";
			break;
		default:
			val = "You didn't provide a thing, asshole.";
			break;
		}
		
		return val;
	}
}