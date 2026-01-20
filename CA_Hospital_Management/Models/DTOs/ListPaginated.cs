namespace CA_Hospital_Management.Models.DTOs
{
    public class ListPaginated<T>
    {
        public List<T> Items { get; set; } = new();
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
