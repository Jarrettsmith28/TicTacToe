using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
  internal class Game
  {

    public static char[] GameState { get; set; } = new char[9] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

    public String GameDisplay { get; set; } = $"{GameState[0]}|{GameState[1]}|{GameState[2]}\n{GameState[3]}|{GameState[4]}|{GameState[5]}\n{GameState[6]}|{GameState[7]}|{GameState[8]}";


    public string Mark(int player, int mark)
    {
      if (GameState[mark] == 'x' || GameState[mark] == 'o')
      {
        return "there is already a mark there";
      }
      if (player == 1)
      {
        GameState[mark] = 'x';
      }
      if (player == 2)
      {
        GameState[mark] = 'o';
      }
      

      var game = new Game();
      return game.GameDisplay;
    }

    public string? GameOver(string player1, string player2)
    {
      if (Game.GameState[0] == 'x' && Game.GameState[1] == 'x' && Game.GameState[2] == 'x') return $"{player1} wins";
      if (Game.GameState[0] == 'x' && Game.GameState[3] == 'x' && Game.GameState[6] == 'x') return $"{player1} wins";
      if (Game.GameState[0] == 'x' && Game.GameState[4] == 'x' && Game.GameState[8] == 'x') return $"{player1} wins";
      if (Game.GameState[1] == 'x' && Game.GameState[4] == 'x' && Game.GameState[7] == 'x') return $"{player1} wins";
      if (Game.GameState[2] == 'x' && Game.GameState[4] == 'x' && Game.GameState[6] == 'x') return $"{player1} wins";
      if (Game.GameState[2] == 'x' && Game.GameState[5] == 'x' && Game.GameState[8] == 'x') return $"{player1} wins";
      if (Game.GameState[3] == 'x' && Game.GameState[4] == 'x' && Game.GameState[5] == 'x') return $"{player1} wins";
      if (Game.GameState[6] == 'x' && Game.GameState[7] == 'x' && Game.GameState[8] == 'x') return $"{player1} wins";
      if (Game.GameState[0] == 'o' && Game.GameState[1] == 'o' && Game.GameState[2] == 'o') return $"{player2} wins";
      if (Game.GameState[0] == 'o' && Game.GameState[3] == 'o' && Game.GameState[6] == 'o') return $"{player2} wins";
      if (Game.GameState[0] == 'o' && Game.GameState[4] == 'o' && Game.GameState[8] == 'o') return $"{player2} wins";
      if (Game.GameState[1] == 'o' && Game.GameState[4] == 'o' && Game.GameState[7] == 'o') return $"{player2} wins";
      if (Game.GameState[2] == 'o' && Game.GameState[4] == 'o' && Game.GameState[6] == 'o') return $"{player2} wins";
      if (Game.GameState[2] == 'o' && Game.GameState[5] == 'o' && Game.GameState[8] == 'o') return $"{player2} wins";
      if (Game.GameState[3] == 'o' && Game.GameState[4] == 'o' && Game.GameState[5] == 'o') return $"{player2} wins";
      if (Game.GameState[6] == 'o' && Game.GameState[7] == 'o' && Game.GameState[8] == 'o') return $"{player2} wins";
      else return null;
    }
  }
}
