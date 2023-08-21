// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;



class JogoDaVelha
{
    static void Main(string[] args)
    {
        int m = 0;
         while(m == 0)
        {
        int[] hide = {10,20,30,40,50,60,70,80,90}; 
        string[] jogo = {"1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9"};
        int i = 0;
        int c = 0;
        int h = 0;
        int e = 1;
        string marca = "O ";
        
       
            
        while (i == 0)
        {
        Console.Clear();
        Console.WriteLine(marca + " escolha onde jogar");
        Console.WriteLine(jogo[0] + jogo[1] + jogo[2] + "\n" + jogo[3] + jogo[4] + jogo[5] + "\n" + jogo[6] + jogo[7] + jogo[8] + "\n");
        
        h = Convert.ToInt32(Console.ReadLine());
        switch(h)
        {
            case 0:
                i = 1;
                break;
            case 1:
                jogo[0] = marca;
                hide[0] = e;
                break;
            case 2:
                jogo[1] = marca;
                hide[1] = e;
                break;
            case 3:
                jogo[2] = marca;
                hide[2] = e;
                break;
            case 4:
                jogo[3] = marca;
                hide[3] = e;
                break;
            case 5:
                jogo[4] = marca;
                hide[4] = e;
                break;
            case 6:
                jogo[5] = marca;
                hide[5] = e;
                break;
            case 7:
                jogo[6] = marca;
                hide[6] = e;
                break;
            case 8:
                jogo[7] = marca;
                hide[7] = e;
                break;
            case 9:
                jogo[8] = marca;
                hide[8] = e;
                break;
        }
        if(hide[0] == hide[1] && hide[1] == hide[2] 
        || hide[3] == hide[4] && hide[4] == hide[5] 
        || hide[6] == hide[7] && hide[7] == hide[8] 
        || hide[0] == hide[3] && hide[3] == hide[6]
        || hide[1] == hide[4] && hide[4] == hide[7] 
        || hide[2] == hide[5] && hide[5] == hide[8] 
        || hide[0] == hide[4] && hide[4] == hide[8] 
        || hide[2] == hide[4] && hide[4] == hide[6])
        {
            while (i == 0)
            {
            Console.Clear();
            Console.WriteLine(marca + "Venceu!");
            Console.WriteLine(jogo[0] + jogo[1] + jogo[2] + "\n" + jogo[3] + jogo[4] + jogo[5] + "\n" + jogo[6] + jogo[7] + jogo[8] + "\n");
            Console.WriteLine("aperte 1 para nova partida e 0 para sair");
            c = Convert.ToInt32(Console.ReadLine());
            
                switch(c)
                {
                    case 1:
                        i = 1;
                        break;
                    case 0:
                        m = 1;
                        i = 1; 
                        break;
                }
            }
            
        }
			if (marca == "O ")
					{
						marca = "X ";
						e = 0;
					}
			else 
					{
						marca = "O ";
						e = 1;
					}
		    
        }
        } 
    }
}
    