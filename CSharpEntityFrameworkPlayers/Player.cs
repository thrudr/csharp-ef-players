using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    public class Player
    {
        //ATTRIBUTI

        [Table("Player")]
        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public int punteggio { get; set; }
        public int numeroPartiteGiocate { get; set; }
        public int numeroPartiteVinte { get; set; }


    }
}
