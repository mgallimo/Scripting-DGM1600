using UnityEngine;
using System.Collections.Generic;
using System;

/*
 Here is where I will write my understanding on this topic.
 
 Lists are similar to arrays, but are more dynamic in size. 
 You also do not need to know how many elements a list has ahead of time when using lists.
 int.Count works the same as the length property or arrays.
 int.RemoveAt removes an element from an index 
 int.Insert takes an index and element and pushes all the other elements up a place.
 */

public class Lists : MonoBehaviour {
	public string animal;
	List<string> zooRoster = new List<string>();

	// Use this for initialization
	void Start () {
		zooRoster.Add ("monkey");
		zooRoster.Add ("elephant");
		zooRoster.Add ("alligator");

	}
	public void AddAnimal()
	{
		if (animal != " ") 
		{
			if (zooRoster.Contains (animal) != true) 
			{
				zooRoster.Add (animal);
			}
		}
	}
	public void RemoveAnimal()
	{
		if (animal != " ")
			{
				if (zooRoster.Contains (animal) == true)
				{
				zooRoster.RemoveAt (animal [0]);
				}
			}
		}
	public void RemoveAll()
	{
		if (animal == " ")
		{
				zooRoster.Clear();
		}
	}
}