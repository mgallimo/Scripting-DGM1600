using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {
	
	/*
	I saw the comments you made on my Else Clause and If Statements assignments earlier today. I hardly ever log on to canvas so I apologize for not seeing them sooner. I did hand type my code, but I also had a reference to look from. I will be sure to not use a reference and only submit original code from this point onward. I will also not try to test for a better score than a zero on those two assignments as punishment. I am terribly sorry for the inconvenience.
	*/

	string[] Action = { "throwing your cat into a swimming pool", "flipping your expensive coffee table", "decorating your house with wet toilet paper", "mailing you a glitter bomb", "getting your grandmother stuck in a tree" };
	string[] Adjective1 = { "offensive", "annoying", "selfish", "hurtful" };
	string[] Consequence = { "harm them", "break your heart", "make you upset", "send them to the hospital" };
	string[] Intention = { "get even with you", "cheer you up", "make you laugh", "start the next hottest trend", "quote-on-quote 'do it for the vine'" };
	string[] Motive = { "after you", "break your furniture", "going to hurt you", "being a cactus", "get you in trouble" };
	string[] Adjective2 = { "forced", "half-arsed", "sincere", "dead-panned", "over-zealous" };
	string[] Solution = { "lock your doors", "call it a draw", "close your blinds", "get a better job", "hide your wife and kids" };
	string[] Request = { "stop winning all the d**n time", "have better communication with me", "pull the correct lever", "stay out of my house", "get off my lawn, ye whippersnapper" };
	string[] Relationship = { "most formidable enemy", "bestest friend", "little niece", "newest coworker", "future self", "lover in a past life" };
	string[] Name = { "We A. Boo", "Bob", "Munchkin", "Mr. Simple", "Ida No", "Nunya Business", "R.K.9." };

	bool apologyNote = true;

	// Use this for initialization
	void Start () {

		// The "Official Notice Formal Apology" form belongs to BureauOfCommunication.com. I left out the content listed at the veryt top and on the right side of said form for the sake of simplicity.
		
		// I promise this code is original and not from another source.

	
		int i = 0;

		while (i < Action.Length)
			;
		print ("The Official Notice Formal Apology");
		
		print ("It has come to my attention that my action of "  + Action[Random.Range(0, Action.Length)] + " could be seen as " + Adjective1[Random.Range(0, Adjective1.Length)] + ". I never intended to " + Consequence[Random.Range(0, Consequence)] + ". I want you to understand that I was merely trying to " + Intention[Random.Range(0, Intention.Length)] + ", though I can see now that it may appear that I was " + Motive[Randon.Range(0, percievedMotive.Length)] + ". Please accept my " + Adjective2[Random.Range(0, Adjective2.Length)] + " apology. Moving forward, I will attempt to " + Solution[Random.Range(0, Solution.Length)] + ". That said, I would very much appreciate it if you " + Request[Random.Range(0, Request.Length)] + ". Sincerely, your " + Relationship[Random.Range(0, Relationship.Length)] + " " + Name[Random.Range(0, Name.Length)] + ".");
	}



		/*
		OFFICIAL APOLOGY NOTE: 
		"It has come to my attention that my action of " + actionRequiringApology + 
		" could be seen as " + bad + 
		". I never attended to " + consequenceOfYourAction + 
		". I want you to understand that I was merely trying to " + yourIntention + 
		", though I can see now that it may appear that I was " + percievedMotive + 
		". Please accept my " + adjective + 
		" apology. Moving forward, I will attempt to " + proposedSolution + 
		". That said, I would very much appreciate it if you " +requestFromOtherParty+ 
		". Sincerely, your " +relationshipToPerson + 
		" " + Your name + ".")
		*/
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
