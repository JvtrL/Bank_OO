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
            _bonificacao += value * 0.02;
        } 
    }

    public override int CalcularFerias()
    {
        int dias_ferias = 20 + NumeroDeClientesAtendidos * 1;
        return dias_ferias;
    }
}