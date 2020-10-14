using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {

        // Add key as Identity column and create value automatically
        [Key]
        public int Id { get; set; }

        //Name cannot be null
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }

    
}
