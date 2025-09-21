namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //R:    
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //R:
        public Iphone(int numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone via App Store...");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}