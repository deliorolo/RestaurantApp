namespace CodeLibrary.Models
{
    public interface IProduct
    {
        int Ammount { get; set; }
        ICategory Category { get; set; }
        int CategoryId { get; set; }
        string Detail { get; set; }
        string DisplayText { get; }
        string DisplayText2 { get; }
        string DisplayText3 { get; }
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}