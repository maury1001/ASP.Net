namespace HolaMundoMVC.Models
{
    public abstract class ObjetoEscuelaBase
    {

        public string ID { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            ID = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{ID}";
        }
        
    }
}