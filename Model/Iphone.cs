namespace Smartphone_projeto_.NET.Model;

public class Iphone : Smartphone
{
	public Iphone(int numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}


	public override void InstalarAplicativo(string aplicativo)
	{
		Console.WriteLine("Instalando o aplicativo '" + aplicativo + "' no Iphone");
	}
}