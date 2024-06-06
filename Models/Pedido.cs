namespace Models
{
    public class Pedido
    {
        public readonly static string OBTER = "select p.Id, p.Descricao, p.Mesa, i.Id, i.Descricao from TB_PEDIDO p\r\ninner join TB_Item i on p.IdItem = i.Id;";
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Mesa { get; set; }
        public Item Item { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} - Descricao: {Descricao} - Mesa: {Mesa} - Item: {Item.Descricao}";
        }
    }
}
