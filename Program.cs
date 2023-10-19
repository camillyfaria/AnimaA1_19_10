using System;

class Program
{
    static void Main()
    {
        int f;
        int ff;
        int fd;
        int t;
        int tf;
        int td;
        float c;

        f = 96;
        Console.WriteLine("Informe a quantidade de fases fáceis existentes");
        ff = Convert.ToInt32(Console.ReadLine());

        fd = f - ff;
        tf = ff;
        td = fd * 2;
        t = tf + td;
        c = t * 5;

        Console.WriteLine("O jogo conta com: {0} fases faceis", ff);
        Console.WriteLine("{0} fases difíceis", fd);
        Console.WriteLine("Voce passou {0} horas jogando as fases faceis", tf);
        Console.WriteLine("{0} jogando as fases dificeis", td);
        Console.WriteLine("Tempo total = {0} horas", t);
        Console.WriteLine("O valor total a ser pago para os seus pais relativo ao custo da energia foi = R$ {0}", c.ToString("0.00"));
        Console.WriteLine("Pressione qualquer tecla para finalizar.");

        Console.ReadKey();
    }
}