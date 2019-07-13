using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    
    public class Pokemon
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PokedexNumber { get; set; }
        public string Name { get; set; }
        public virtual PokeType FirstType { get; set; }
        public virtual PokeType SecondType { get; set; }
        public int Hp { get; set; }
        public int Attack{ get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Sp_Atk { get; set; }
        public int Sp_Def { get; set; }
        public bool Is_Legendary { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<Pokemon> Evolutions { get; set; }

        public Pokemon()
        {
            Moves = new List<Move>();
            Evolutions = new List<Pokemon>();
        }
    }
}
