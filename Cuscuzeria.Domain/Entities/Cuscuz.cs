namespace Cuscuzeria.Domain.Entities
{
    public class Cuscuz
    {
        public int CuscuzId { get; set; }

        public string CuscuzName { get; set; }

        public string Description { get; set; }

        public int AccompanimentId { get; set; }

        public int TypeId { get; set; }
    }
}
