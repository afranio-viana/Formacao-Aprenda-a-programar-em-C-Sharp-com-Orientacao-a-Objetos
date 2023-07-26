namespace ScreenSound.Modelos;

/*O que está dentro das chaves não é executável,
é apenas uma assinatura*/
internal interface IAvaliavel
{

    void AdicionarNota(Avaliacao not);
    double Media{get;}

}