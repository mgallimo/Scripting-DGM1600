using UnityEngine;
using System.Collections;

public class March30 : MonoBehaviour {

	// The code used in this document is 100% original.

	// Use this for initialization
	void Start () {

		// start of task #1

		/* instructions for task #1
		 * Create a function that requires three float values as input, 
		 * then multiplies them together and prints the result.
		 */

		float num1 = 2;
		float num2 = 4;
		float num3 = 8;

		float answer = num1 * num2 * num3;

		print ("Okay so " + num1 + "times " + num2 + "times " + num3 + "equals " + answer + ".");

		// end of task #1

		//start of task #2

		/* instructions for task #2
		 * Create two arrays, one with five names and the other with five colors (or similar).
		 * Print a sentence, retrieving the data from eash array using the commonr index.
		 * For example, "[David]'s favorite color is [red]/"
		*/

		string[] names = { "Bob", "Mary", "Marjorie", "James", "David" };
		string[] colors = { "blue", "green", "yellow", "orange", "red" };

		print ("And " + names [1] + "favorite color is " + colors [3] + ".");

		// end of task #2

		// start of task #3

		/* instructions for task #3
		 * Create a funciton that generates random numbers and adds them to a list.
		 * The number of elements int he list is determined by an argument when the function is called.
		 * Return the list.
		 */

		// insert code here

		// end of task #3

		// insert code here

		// start of task #4

		/* instructionsf or task #4
		 * Create a function with a string parameter that coverts string to a float
		 * (assuming the string argument on contains numeric characters)
		 * and returns the new float value.
		 */

		// end of task #4

		// start of task #5

		/* instructionsf or task #5
		 * Create a function with two float parameters that adds the values together 
		 * pand returns the result.
		 */

		float num4 = 3;
		float num5 = 6;

		float answer2 = num4 + num5;

		print ("Okay so " + num4 + "plus " + num5 + "equals " + answer2 + ".");

		// end of task #5

		// start of task #6

		/* instructions for task #6
		 * Create a funcion with a float parameter and print its multiplication table form 0-12.
		 * For example, if the input was six, the output would be:
		 * 6 * 0 = 0
		 * 6 * 1 = 6
		 * 6 * 2 = 12
		 * ...
		 */

		// insert code here

		// end of task #6

		// start task #7

		/* instructions for task #7 
		 * Create a function that generates random float numbers based on three parameters that define
		 * (1) the minimum range,
		 * (2) the maximum range, and
		 * (3)  the number of values to generate.
		 * Add each element to a list and return it.
		 * (Hint: You can reuse this function in further exercises.)
		 */

		/* HOW TO GENERATE RANDOM INT NUMBERS IN C#
		 * the Next() method accepts two parameters, min and max.
		 * Use the above function in a location where you want to use random numbers.
		 * Suppose you want to use it in a text box.
		 * textBox1.Text = randomnumber(0,999).ToString();
		 */

		// insert code here

		// end of task #7

		// start of task #8

		/* instructions for task #8
		 * Create a function that generates 100 random values that separates out all items that are divisible
		 * by three and adds them to an array.
		 * Sort the array from lowest to hightest value
		 * (Hint: There is a method already in place for this. Fo find it!)
		 * Print the items in the array.
		 */

		// insert code here

		// end of task #8

		// start of task #9

		/* instructions for task #9
		 * Use the internet to learn how to use input fields in Unity and C#.
		 * Create a new scene with two input fields.
		 * As an example, they could request a user's name and age.
		 * Create a function that extracts the text from the input fields and prints a statement using the data
		 * (ex: "David is 25 years old.")
		 */

		// insert code here 

		// end of task #9

		// start of task #10

		/* instructions for task #10
		 * Create a function that generates 100 random values between 0-100.
		 * Use a switch statement to determine if the value is between 0-10, 10-20, 20-30, etc. 
		 * and track each group.
		 * Once all values have been processed, print a statement indicating which group has the most items.
		 * (A real-world example of this might be sampling a random group of 100 people
		 * and finding which age group is most prevalent.)
		 */

		// insert code here

		// end of task #10
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
