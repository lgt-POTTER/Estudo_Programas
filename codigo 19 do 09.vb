escreva uma funçao que leia um numero e diga seu dobro


inicio

    função dobro( a : real ): real
        retorna a * 2
    fimfuncao

    escreva ("Digite um número para saber o dobro dele: ")
    leia (num)

    

    escreva ("O dobro de ", num ," é: ", dobro(num))

fim




escreva uma funcao que retorne a area do circulo (raio como parametro)


inicio 

    funcao area(r : real): real
        pi = 3.14
        retorna (pi * r ^2)
    fimfuncao

fim



crie um procedimento que verifica se um numero e par


inicio

    procedimento par(num : inteiro): inteiro
        se num % 2 = o faça
            escreva ("é par")
        senao
            escreva ("não é par")
    fimse

fim




recursividade exemplo

inicio

    funçao fatorial (n : inteiro): inteiro
        se n = 0 entao
            retorne 1
        senao
            retorne n * fatorial (n-1)
    fimfuncao

fim

na pratica oq o algarismo faz:

fatorial (4)
    4 * fatorial(3)
        3 * fatorial(2)
            2 * fatorial(1)
                1 * fatorial(0)
                    quando chegar o zero o código termina e retorna 1 assim achando a resposta da ultima fatorial, 
                    possibilitanto a resolver de tras para frente as outras


basicamente ele vai puxando o n - 1 
ate achar o resultado de alguma fatorial para poder começar os calculos