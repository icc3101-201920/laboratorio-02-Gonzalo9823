using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902 {
    public class Game {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game () {
            Random random = new Random ();
            players = new Player[2] { new Player (), new Player () };
            ActivePlayer = players[random.Next (0, 2)];
            boardGame = new Board ();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players {
            get {
                return this.players;
            }
        }
        public Player ActivePlayer {
            get {
                return this.activePlayer;
            }
            set {
                activePlayer = value;
            }
        }
        public Board BoardGame {
            get {
                return this.boardGame;
            }
        }
        public bool EndGame {
            get {
                return this.endGame;
            }
            set {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame () {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0) {
                return true;
            } else {
                return false;
            }
        }
        public bool GetWinner () {
            if (players[0].LifePoints == 0) {
                return players[1].Id
            } else if (players[1].LifePoints == 0) {
                return players[0].Id
            }
        }
        public void Play () {
            throw new NotImplementedException ();
        }
    }
}