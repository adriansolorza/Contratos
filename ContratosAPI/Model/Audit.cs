namespace ContratosAPI.Model
{
    public class Audit
    {
        int Id { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;} = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}
