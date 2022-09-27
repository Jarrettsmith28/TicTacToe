using System.Transactions;
using Tic_Tac_Toe;
Console.WriteLine("Welcome to my Tic Tac Toe game please enter the name for player 1");
var player1 = Console.ReadLine();
Console.WriteLine("What is player 2's name?");
var player2 = Console.ReadLine();
var game = new Game();
Console.WriteLine(game.GameDisplay);
int count = 0;
for (int i = 1; game.GameOver(player1, player2) == null; count++)
{
  Console.WriteLine($"player {i} your turn please choose a number to indicate where you would like to place your mark");
  var mark = Convert.ToInt32(Console.ReadLine());
  var response = game.Mark(i, mark);
  Console.WriteLine(response);
  if (response.Contains("already"))
  {
    Console.WriteLine($"player {i} your turn please choose a number to indicate where you would like to place your mark");
    mark = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(game.Mark(i, mark));
  }
  if (count >= 8) break;
  else if (i == 1) i++;
  else if (i == 2) i--;
}
Console.WriteLine(game.GameOver(player1, player2));
if (count >= 8 && game.GameOver(player1, player2) == null) Console.WriteLine("cats game. nobody wins");
