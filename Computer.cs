using System;

class ComputerPlayer {
  public string computerDecision(){
    Random rnd = new Random();
    int rnd_case = rnd.Next(0,3);

    if (rnd_case == 0){
      Console.WriteLine($"Computer chose: Rock");
      return "Rock"; 
    }
    else if (rnd_case == 1 ) {
      Console.WriteLine($"Computer chose: Paper");
      return "Paper"; 
    } else {
      Console.WriteLine($"Computer chose: Scissors");
      return "Scissors"; 
    }
    



    }

  }