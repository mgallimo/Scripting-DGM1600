using UnityEngine;
using System.Collections;

public class variablesAndOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 3.536235f;
	private float length = 2;
	private float width = 4;
	private float trianglebase = 2;
	private float height = 3;

	// Use this for initialization
	void Start () {

		/*And this is where I will type up my understanding on this topic.
		
		There are math operators that can do various things with variable numbers. They are as follows.
		
		Addition (+) - self explanitory.
		Subtraction (-) - self explanitory.
		Multiply (*)
		Division (/)
		Modulus (%) - basically how remainders are possible in coding. However, it does round to the nearest remainder for its output. for example: 4%2 -> 0 (even number) and 5%2 -> 1 (odd number)
		Increiment (++) - takes the variable and adds it by the number one. For example: 
		Num1 = 3;
		Num1++ = 4;
		This code also works when you place the double plus signs on the other side of the variable.
		Decrement (--) - takes the chosen variables and subtracts it by the number one. For example: 
		Num1 = 3;
		Num1-- 3 = 2;
		This code also works when you place the double subtraction signs on the other side of the variable.
		Assignment (=) - Assigns a variable. For example: Num3 = 6;
		
		As for which order each math operation goes we look to the Order of Operations, which can be narrowed down by this phrase; Please Excuse My Dear Aunt Sally, or PEMDAS. This basically means anything inside Parenthesis goes first, Exponents are second, Multiplication third, Division is fourth, Addition fifth, and then finally Subtraction. The code is also read from left to right so other than pemdas that is the order of how things will go.
		*/
		
		//Find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of the circle with radius " + radius + " is " + diameter);

		//Find the circumference of a circle
		float circumference = 2 * pi * radius;
		print ("The circumference of the circle with radius " + radius + " is " + diameter);

		//Find the area of a circle
		float area = pi * radius
		print ("The area of the circle with radius " + radius + " is " + diameter);

		//Find the perimeter of a rectangle
		float perimeter = 2 * (length + width);
		print ("The perimeter of the rectangle with length " + length + " and width " + width " is " perimeter);

		//Find the area of a rectangle
		float area = length * width
		print ("The area of the rectangle with length " + length + " and width " + width " is " area);

		//Find the area of a triangle
		float area = (height * trianglebase) / 2
		print ("The area of the triangle with base " + trianglebase + " and height " + height + " is " + area);
	}
}
