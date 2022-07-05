using System;

class UserPlayer {
  private int points;

  public void UserPoints(int choose){
    points = choose;

  }
public int getPoints(){
  return points;
}
public void winRound(){
  points = points + 5;
}
public void loseRound(){
  points = points - 5;
}

public string userDecision(){
  Console.WriteLine("Please input your choice: Rock, Paper or Scissors: ");
  string choice = Console.ReadLine();
  Console.WriteLine($"You chose: {choice}");
  return choice;
}

}

