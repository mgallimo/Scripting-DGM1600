using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	/* The instructions for this assignment did not ask for an explanation in your own words about the topic so I am doing to do it anyways just incase you left it out of the instructions or something. Hope you don't mind!
	
	While Loops executed a part f code repeatedly when a bool expression is stated as true. It is tested BEFORE the body of loop the code will be used for. 
	
	for example:
	
	int a = 0;
	while (i < 3)
	{
	print (i++);
	}
	
	do-while loops are basically the same thing, but they test the expression listed AFTER the statement block. 
	
	for example:
	
	int i = 0;
	do
	{
	print (i++);
	}
	while (i < 3);
	
	There are more examples in the comments sections found at the bottom of this page.
	*/
	public int bottles = 0;
	public int maxBottles = 10;

	private bool gameOn = true;

	private int minVal = -10;
	private int maxVal = 10;
	private int randomNum;
	private int counter = 0;
	// Use this for initialization
	void Start () {
		while (true) {
			randomNum = Random.Range (minVal, maxVal);
			if (randomNum > 0) {
				maxVal = randomNum;
			} 
			else if (randomNum < 0) {
				minVal = randomNum;
			}

			counter++;
			print ("Attemp " + counter + ": " + minVal + " - " + maxVal);

			if (maxVal == 1 && minVal == -1) {
				break;
			}
		}
	}

		/*while (gameOn)
		{
			print (bottles + " bottles of root beer on the wall.");
			bottles++;
			if (bottles == maxBottles)
			{
				gameOn = false;
			}
		}
		*/


		/*while(bottles < maxBottles)
		{
			bottles++;
			evenOdd = bottles % 2;
			if (evenOdd == 0)
			{
				print(bottles + " bottles on the wall");
			}
			else
			{
			print("odd number.");
			}

			print(bottles + " bottles of root beer on the wall.");
			bottles = bottles + 2;
		}
		print ("All done!");
		*/

		/*
		while(bottles < maxBottles)
		{
		if (bottles % 2 == 0) {
			print (bottles + " bottles of root beer on the wall.");
		}
		bottles++;
		*/
	}