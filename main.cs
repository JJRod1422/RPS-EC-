using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("--------Rock Paper Scissors--------");
    //String for User.cs
    UserPlayer p1 = new UserPlayer();
    p1.UserPoints(5);

    //String for Computer.cs

    ComputerPlayer c1 = new ComputerPlayer();
    
    string startMatch = "y" ;
    while(startMatch == "y"){
      startMatch = "n";
      Console.WriteLine("Your Score: " + p1.getPoints());

      //Gameplay for Computer

      string uCheck = p1.userDecision();

      string cCheck = c1.computerDecision();
        
        
        
        
        //If the user chooses Rock
      if(uCheck == "Rock"){
        if (cCheck == "Scissors"){
          Console.WriteLine("You Win!");
          p1.winRound();
        }
      else if (cCheck == "Paper"){
          Console.WriteLine("You lose");
          p1.loseRound();
      }
      else if (cCheck == "Rock"){
          Console.WriteLine("Tie ");
          p1.loseRound();
      }
      
      
      
      
      //If the user selects Paper
    } else if (uCheck == "Paper"){
      if (cCheck =="Scissors"){
        Console.WriteLine("You lose");
        p1.loseRound();
      }
    }
      else if (cCheck == "Paper"){
        Console.WriteLine("It's a tie");
      }

      else if (cCheck == "Rock"){
        Console.WriteLine("You Win!");
        p1.winRound();
      }
      
      
      //if the user selects Scissors
      else if (uCheck == "Scissors"){
      if (cCheck == "Scissors"){
        Console.WriteLine("Its a Tie");
      }
      }

      else if (cCheck == "Paper"){
          Console.WriteLine("You Win");
          p1.winRound();
      }
      else if (cCheck == "Rock"){
          Console.WriteLine("You lose ");
          p1.loseRound();
      }
      else {
        Console.WriteLine("Choose Rock, Paper, or Scissors");
      }
      
      
      //Computer will ask user to continue or not
      if(p1.getPoints() > 0){
        Console.WriteLine("Play Again? Please input y or n to continue.");
        startMatch = Console.ReadLine();
      }
      else{
        Console.WriteLine("Game Over.");
      }
      
  



    
    

  


  }
}

}