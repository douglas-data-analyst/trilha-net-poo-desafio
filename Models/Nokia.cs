namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //R:    Realizei a herança da classe Smartphone na classe Nokia e implementei o método 
    //      abstrato InstalarAplicativo.
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //R:    Realizei a sobrescrita do método InstalarAplicativo.
    
        public Nokia(string numero, string modelo, string imei, int memoria) :
        base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia...");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}