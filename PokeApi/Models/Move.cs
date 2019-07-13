using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual PokeType DamageType { get; set; }
    }
}
