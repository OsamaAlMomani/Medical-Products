using System.ComponentModel;

namespace basicModel.Models
{
    public class Product_Type
    {
        public Guid Id { get; set; }

        public Category? category;
        public int number { get; set; }

        public string Name { get; set; }

    }
}



/*
 
    Category -> type -> Product
         
    
 
*/