using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Bolt;

public class Map_Data_Loader_C : MonoBehaviour
{
	private GameObject Map_Loader;
	public int Map_NO;
	public int Map_Chapter;
	public int Map_Order;
	public int Map_Level;
	public int Map_Special;
	public int Map_UpDown;
	public int Map_Hard;
	private List<string> list = new List<string>();
	public bool Map_Data_Loader_Bool;
	public string Map_Clear_Item;

	void Awake()
	{
		Map_Loader = GameObject.Find("Map_Data_Loader");

		List<Dictionary<string, object>> data = CSVReader.Read("Map_Data");

		list.Add("Chap0_Map1");
		list.Add("Chap0_Map2");
		list.Add("Chap0_Map3");
		list.Add("Chap0_Map4");
		list.Add("Chap0_Map5");
		list.Add("Chap0_Map6");
		list.Add("Chap0_Map7");
		list.Add("Chap0_Map8");
		list.Add("Chap0_Map9");
		list.Add("Chap0_Map10");
		list.Add("Chap0_Map11");
		list.Add("Chap0_Map12");
		list.Add("Chap0_Map13");
		list.Add("Chap0_Map14");


		for (int i = 0; i < 14; i++)
		{
			Map_NO = (int)data[i]["Number"];
			Map_Chapter = (int)data[i]["Chapter"];
			Map_Order = (int)data[i]["Order"];
			Map_Level = (int)data[i]["Level"];
			Map_Special = (int)data[i]["Special"];
			Map_UpDown = (int)data[i]["Up"];
			Map_Hard = (int)data[i]["Hard"];
			Map_Clear_Item = (string)data[i]["Item"];

			Variables.Object(Map_Loader).Set(list[i], data[i]);
		}

		Map_Data_Loader_Bool = (bool)true;
		Variables.Object(Map_Loader).Set("Map_Data_Loader_Bool", Map_Data_Loader_Bool);

	}
}