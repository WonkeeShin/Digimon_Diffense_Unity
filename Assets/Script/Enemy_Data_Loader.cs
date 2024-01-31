using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Bolt;

public class Enemy_Data_Loader : MonoBehaviour
{
	private GameObject Digimon;
	public int Digi_NO;
	public string Digi_Name;
	public int Digi_HP;
	public int Digi_ATK;
	public int Digi_DF;
	public int Digi_Colli_NO;
	public float Digi_ATK_Speed;
	public float Digi_Speed;
	public int Digi_Position;
	public int Digi_Skill;
	private List<string> list = new List<string>();

	void Awake()
	{
		Digimon = GameObject.FindWithTag("Enemy_Data_Loader");

		List<Dictionary<string, object>> data = CSVReader.Read("Enemy_Data2");

		list.Add("Botamon");
		list.Add("Punimon");
		list.Add("Nyokimon");
		list.Add("Bubbmon");
		list.Add("Yuramon");
		list.Add("Pichimon");
		list.Add("Poyomon");
		list.Add("Yukibotamon");
		list.Add("Choromon");
		list.Add("Kuramon");
		list.Add("Koromon");
		list.Add("Mochimon");
		list.Add("Tunomon");
		list.Add("Tanemon");
		list.Add("Nyaromon");
		list.Add("Pyocomon");
		list.Add("Tokomon");
		list.Add("Agumon");
		list.Add("Gabumon");
		list.Add("Patamon");
		list.Add("Palmon");

		for (int i = 0; i < 21; i++)
		{
			Digi_NO = (int)data[i]["Number"];
			Digi_Name = (string)data[i]["Name"];
			Digi_HP = (int)data[i]["HP"];
			Digi_ATK = (int)data[i]["ATK"];
			Digi_DF = (int)data[i]["DF"];
			Digi_Colli_NO = (int)data[i]["Colli_No"];
			Digi_Position = (int)data[i]["Position"];
			Digi_Skill = (int)data[i]["Skill"];

			Variables.Object(Digimon).Set(list[i], data[i]);
		}


	}
}