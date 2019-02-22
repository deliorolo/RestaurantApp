namespace CodeLibrary.Models
{
    public interface ITable
    {
        IAreaOfTables Area { get; set; }
        int AreaId { get; set; }
        string DisplayText { get; }
        int Id { get; set; }
        int NumberOfTable { get; set; }
        string ShowOccupied { get; set; }
        string ShowText { get; }
    }
}