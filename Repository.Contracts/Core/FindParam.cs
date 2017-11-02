namespace Repository.Contracts.Core
{
    public class FindParam
    {
        public string FilterText { get; set; }
        public string FilterOn { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}