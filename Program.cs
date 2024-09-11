// Loops and Validation


Console.Clear();

// < > <= >= ==
// if(true){
//     // Code to be run when true
// }else if(true){
//     // This code runs if the previous if statement fails AND and the new if statement is true
// }else{
//     // If all of the previous statements fail, then this code will run
// }



// Switch Statements
// A switch statement can be thought of as a collection of if statements that takes in a single aregument and compares it to all of the possible cases/outcome.

switch(1){
    case 1:
        Console.WriteLine("This case was selected");
        break;
    case 2:
        Console.WriteLine("You have selected case two");
        break;
    case 3:
        Console.WriteLine("third case has been chosen");
        break;

    default:
        Console.WriteLine("oh, this doesn't match any of our cases....");
        break;
}

// Our passed in value gets compared to the cases one by one, and when the value matches the value of a case, the code following the colon will execute.
// Note: This first example is using a integar literal, just a plain ol number, but we can use any data type for our argument.
// Our statement will want to keep running if we do not cap if off with a break statement, so do not forget to end with a break;!

string favCar = "Hell";
switch(favCar){
    case "Porsche":
        Console.WriteLine("Porsche");
        break;
    case "Hellcat":
        Console.WriteLine("meow");
        break;
    case "BRZ":
        Console.WriteLine("Zoom");
        break;
    default:
        Console.WriteLine("never heard of " + favCar);
        break;
}
// Note: that if you try to use more then one argument, it confuses the switch into thinking it is a differnt data type. In other words, we can only use a single argument or it will break our switch (and not in the good way)

bool? yesNo = null;
// putting a question mark (?) after a variable name is making it a Nullable Value. we are explicitly telling our variable that it is allowed to have a null value. Otherwise, the code would complain about not being able to convert between bool and null.

switch(yesNo){
    case true:
        Console.WriteLine("yes");
        break;

    case false:
        Console.WriteLine("no ....");
        break;
    default:
        Console.WriteLine("how did you get here");
        break;
}

