using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Category))]
        public Category category { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        [ForeignKey(nameof(Brand))]

        public Brand brand { get; set; }

        public int quantity { get; set; }


        public DateOnly Sign_date { get; set; }
        public DateOnly EXP_date { get; set; }


        public decimal price { get; set; }

    }
}
/*
 
            - Item Name:                   - Exp Date: dd/mm/yyyy
                    +Brand 
                    +Note
                    +Sign_date: dd/mm/yyyy 
                    
            - Category {Chemical or something}
                    +Type
    
            - Quantity // default Value = 1

            - {Check box} single Unit OR Box    // Default Value = " Single Unit "
            
            - Des

            - Price
    
 
 
 
 */