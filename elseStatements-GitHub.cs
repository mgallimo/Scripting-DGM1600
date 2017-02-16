using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class elseStatements : MonoBehaviour {
	private int time = 19;
	private float grade;
	
	/* And this is where I will write my understanding on the topic of Else Statements.
	
	Else statements is a clause that can execute a designated block of code when the condition of an if statement returns false.
	
	Here is the template for the code (Example 1):
	
		if (condition)
		{
			statements
		}
		else
		{
			statements
		}
	
	Now let us see it in action! (Example 2):
	
		int mark = 85;
		
		if (mark < 50)
		{
			Console.WriteLine("You failed.");
		}
		else
		{
			Console.WriteLine("You passed.");
		}
		
	You can also put if statements withing another if statement. These are called Nested if Statements.
	
	for example (Example 3):
	
		int mark = 100;
		
		if (mark >= 50) {
			Console.WriteLine("You passed.");
			if (mark == 100) {
				Console>WriteLine("Perfect!");
			}
		}
		else {
			Consolde.WriteLine("You failed.");
		}
		

	
	
	
	
	There is also the If-Else If Statement, which can be used when there are three or more actions to decide on.
	
	for example (Example 5):
		init x = 33;
		
		if (x == 8) {
			Console.WriteLine("Value of x is 8");
		}
		else if (x == 18) {
			Console.WriteLine("Value of x is 18");
		}
		else if (x == 33) {
			Console.WriteLine("Value of x is 33");
		}
		else {
			Console.WriteLine("No match");
		}
	
	
	This is the end of my explanation.
	*/

	// Use this for initialization
	void Start () {
		if (time < 12)
		{
			print)"Good morning!");
		}
		else if (Time == 12)
		{
			print("Lunch time!");
		}
		else if (Time < 18)
		{
			print("Good afternoon!");
		}
		else
		{
			print("Good evening!");
		}

		if (grade > 90)
		{
			print("A");
		}
		else if (grade > 80)
		{
			print("B");
		}
	}
}
	
	// Update is called once per frame
	void Update () {
	
	}
}
