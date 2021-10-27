public class Vendedor : Funcionario
{
    public int NumeroDeClientesAtendidos { get; set; }
    public override double Bonificacao 
    {   
        get
        {
            return _bonificacao;
        } 
        set
        {
            _bonificacao += value * 0.03;
        } 
    }

}