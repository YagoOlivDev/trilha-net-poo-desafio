namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero_, string modelo_, string imei_, int memoria_)
        {
            Numero = numero_;
            Modelo = modelo_;
            IMEI = imei_;
            Memoria = memoria_;
        }
 
        public abstract void Ligar();

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}