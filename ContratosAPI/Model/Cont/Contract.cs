namespace ContratosAPI.Model.Cont
{
    public class Contract : Audit
    {
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
