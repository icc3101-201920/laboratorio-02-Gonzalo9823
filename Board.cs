using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_1_OOP_201902.Card;

namespace Laboratorio_1_OOP_201902 {
    public class Board {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards {
            get {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards {
            get {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards {
            get {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards {
            get {
                return this.specialMeleeCards;
            }
            set {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards {
            get {
                return this.specialRangeCards;
            }
            set {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards {
            get {
                return this.specialLongRangeCards;
            }
            set {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards {
            get {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards {
            get {
                return this.weatherCards;
            }
        }

        //Constructor
        public Board () {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard> ();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }

        //Metodos
        public void AddMeleeCard (int PlayerId, CombatCard combatCard) {
            throw new NotImplementedException ();
        }
        public void AddRangeCard (int PlayerId, CombatCard combatCard) {
            throw new NotImplementedException ();
        }
        public void AddLongRangeCard (int PlayerId, CombatCard combatCard) {
            throw new NotImplementedException ();
        }
        public void AddCaptainCard (int PlayerId, SpecialCard specialCard) {
            throw new NotImplementedException ();
        }
        public void AddWeatherCard (int PlayerId, SpecialCard specialCard) {
            throw new NotImplementedException ();
        }

        public void AddCombatCard (int PlayerId, CombatCard combatCard) {
            // Segun lo que entendi por enunciado. ¿Para que pasamos el player si Board se instancia desde el jugador mismo? Supongo que hay dos tableros???
            // Si no fuera asi, instanciariamos al Player dentro del tablero y no viceversa

            // Also para que creamos este metodo si tenemos metedos para que tipo de CombatCard

            switch (combatCard.Type) {
                case "Melee":
                    this.meleeCards[PlayerId].Add (combatCard);
                    break;
                case "Range":
                    this.rangeCards[PlayerId].Add (combatCard);
                    break;
                case "LongRange":
                    this.longRangeCards[PlayerId].Add (combatCard);
                    break;
                default:
                    // Card type non existent
                    return;
            }
        }

        public void AddSpecialCard (int PlayerId, SpecialCard specialCard) {
            switch (combatCard.Type) {
                case "Melee":
                    if (this.specialMeleeCards[PlayerId].Count == 0) {
                        this.specialMeleeCards[PlayerId].Add (specialCard);
                    }
                    break;
                case "Range":
                    if (this.specialRangeCards[PlayerId].Count == 0) {
                        this.specialRangeCards[PlayerId].Add (specialCard);
                    }
                    break;
                case "LongRange":
                    if (this.specialLongRangeCards[PlayerId].Count == 0) {
                        this.specialLongRangeCards[PlayerId].Add (specialCard);
                    }
                    break;
                default:
                    // Card type non existent
                    return;
            }
        }

        public void DestroyCombatCard (int PlayerId) {
            this.meleeCards[PlayerId].Clear ();
            this.rangeCards[PlayerId].Clear ();
            this.longRangeCards[PlayerId].Clear ();
        }

        public void DestroySpecialCards (int PlayerId) {
            this.specialMeleeCards[PlayerId].Clear ();
            this.specialRangeCards[PlayerId].Clear ();
            this.specialLongRangeCards[PlayerId].Clear ();
        }

        public void DestroyMeleeCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public void DestroyRangeCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public void DestroyLongRangeCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public void DestroySpecialMeleeCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public void DestroySpecialRangeCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public void DestroySpecialLongRangeCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public void DestroyWeatherCard (int PlayerId) {
            throw new NotImplementedException ();
        }
        public int[] GetMeleeAttackPoints () {
            int playerOneMeeleAttack = 0;
            int playerTwoMeeleAttack = 0;

            foreach (CombatCard card in this.meleeCards[0]) {
                playerOneMeeleAttack += card.AttackPoints;
            }

            foreach (CombatCard card in this.meleeCards[1]) {
                playerTwoMeeleAttack += card.AttackPoints;
            }

            foreach (SpecialCard card in this.specialMeleeCards[0]) {
                playerOneMeeleAttack += card.AttackPoints;
            }

            foreach (SpecialCard card in this.specialMeleeCards[1]) {
                playerTwoMeeleAttack += card.AttackPoints;
            }

            int[] totalPoints = new int[2] { playerOneMeeleAttack, playerTwoMeeleAttack };

            return totalPoints;
        }

        public int[] GetRangeAttackPoints () {
            int playerOneRangeAttack = 0;
            int playerTwoRangeAttack = 0;

            foreach (CombatCard card in this.rangeCards[0]) {
                playerOneRangeAttack += card.AttackPoints;
            }

            foreach (CombatCard card in this.rangeCards[1]) {
                playerTwoRangeAttack += card.AttackPoints;
            }

            foreach (SpecialCard card in this.specialRangeCards[0]) {
                playerOneRangeAttack += card.AttackPoints;
            }

            foreach (SpecialCard card in this.specialRangeCards[1]) {
                playerTwoRangeAttack += card.AttackPoints;
            }

            int[] totalPoints = new int[2] { playerOneRangeAttack, playerTwoRangeAttack };

            return totalPoints;
        }
        public int[] GetLongRangeAttackPoints () {
            int playerOneLongRangeAttack = 0;
            int playerTwoLongRangeAttack = 0;

            foreach (CombatCard card in this.longRangeCards[0]) {
                playerOneLongRangeAttack += card.AttackPoints;
            }

            foreach (CombatCard card in this.longRangeCards[1]) {
                playerTwoLongRangeAttack += card.AttackPoints;
            }

            foreach (SpecialCard card in this.specialLongRangeCards[0]) {
                playerOneLongRangeAttack += card.AttackPoints;
            }

            foreach (SpecialCard card in this.specialLongRangeCards[1]) {
                playerTwoLongRangeAttack += card.AttackPoints;
            }

            int[] totalPoints = new int[2] { playerOneLongRangeAttack, playerTwoLongRangeAttack };

            return totalPoints;
        }
    }
}