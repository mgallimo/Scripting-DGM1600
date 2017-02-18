using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class switchStatement : MonoBehaviour {
	
	/*And here is where I will put my understanding of the topic of Switch Statements and list three examples. Please go to the code beyond this commented section for the other two examples used for this assignment.
	
	Switch Statments are an alternative to if statements that provides a cleaner way to test variables against a list of values, and each value is called a case.
	
	here is what the template would look like (example 1):
	
		int num = 3:
		switch (num)
		{
			case 1:
				Print("one");
				break;
			case 2:
				print ("two");
				break;
			case 3:
				print ("Three");
						break;
		}
	
	Break Statements terminate a switch statement. if you forget to include a break statement, a fallthrough will occur. This is when when the code cannot be compiled. They can also be used to break out of a loop, but that is for another assignment. Here is an example of some code that will make such an error happen (example 2):
	
		int fruit = apple;
		switch (fruit) 
		{
  			case apple:
				print("Apple!");
    			break;
  			case pear:
    			print("Pear!");
				// absence of break statement
		}
		
	You must say where the code execution is to go to next at the end of each clause or else you are in for some serious trouble. You do this by using a jump statement with break being the most common.
	
	Default Statements are executed when none of the cases listed previoiusly match up. here is an example of a default statement in action (example 3):
	
		int age = 88;
		switch (age) 
		{
  		case 16:
			print("Too young");
			break;
		case 42:
    		print("Adult");
    		break;
  		case 70:
			print("Senior");
    		break;
		default:
    		print("The default case");
    		break;
		}
	
	More often than not, using switch statements will result in cleaner code than using multiple if statements. 
	
	This is the end of my explanation.*/
	
	
	private int time = 10;
	private bool exists =  true;

	// Use this for initialization
	//Create a switch statement for time of day
		switch (time) 
		{
			case 9:
				print ("Good morning!");
				print ("It's plesantly brisk outsite.");
				break;
			case 12:
				print ("Lunch time!");
				break;
			case 18:
				print ("Time to go home!");
				break;
		}
	
		//Create a switch statement for animals in a zoo
	private string animal = "alligator";
	private string phrase;
	
		switch (animal)
		{
			case "giraffe":
				phrase = "wheezy neighbaaaahh";
				break;
			case "penguin":
				phrase = "Morgan Freeman";
				break;
			case "lion":
				phrase = "roar";
				break;
			case "fox":
				phrase = "asihaetha;lsidhg;asierj";
				break;
			case "alligator":
				phrase = "would you like some tea with that, sir?";
				break;
			default:
				exists = false;
				break;
		}
		if (exists == true)
		{
			print("A " + animal + " says \"" + phrase + "\".");
		}
		else
		{
			print(animal + " doea not exist.");
		}
	}
}
