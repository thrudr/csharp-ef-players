using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    [Table("Player")]
    public class Player
    {

        //ATTRIBUTI

        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public int punteggio { get; set; }
        public int numeroPartiteGiocate { get; set; }
        public double numeroPartiteVinte { get; set; }

        //COSTRUTTORE

        public Player(string? nome, string? cognome, int punteggio, int numeroPartiteGiocate, double numeroPartiteVinte)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.punteggio = punteggio;
            this.numeroPartiteGiocate = numeroPartiteGiocate;
            this.numeroPartiteVinte = numeroPartiteVinte;
        }

        //METODI


    }
}
