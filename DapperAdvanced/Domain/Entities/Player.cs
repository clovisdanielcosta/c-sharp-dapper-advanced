namespace Domain.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Colunas chave estrangeira
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
