namespace basicModel.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public int custom_ID {  get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Unit {  get; set; }
        public string  brand { get; set; }
        public string product_type { get; set; }


        public int quantity { get; set; }
        public DateOnly Sign_date { get; set; }
        public DateOnly EXP_date { get; set; }


        public float price { get; set; }

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