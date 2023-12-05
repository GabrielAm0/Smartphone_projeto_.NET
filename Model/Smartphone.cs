namespace Smartphone_projeto_.NET.Model;

public abstract class Smartphone
{
	public int Numero { get; set; }
	private string Modelo { get; set; }
	private string IMEI { get; set; }
	private int Memoria { get; set; }

	public Smartphone(int numero, string modelo, string imei, int memoria)
	{
		Numero = numero;
		Modelo = modelo;
		IMEI = imei;
		Memoria = memoria;
	}
	
	public void Ligar()
	{
		Console.WriteLine("Ligando...");
	}
	
	public void ReceberLigacao()
	{
		Console.WriteLine("Recebendo ligação...");
	}

	public abstract void InstalarAplicativo(string aplicativo);
}