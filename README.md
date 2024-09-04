# Teste Tecnico
nesse teste tecnico eu juntei todas as questões, inclusive as que não usam codigo, em um um pequeno programa, dessa forma todas as minhas respostas estao compiladas dentro do mesmo.

é uma aplicação bem simples usando c#, onde as telas são bem auto explicaticas, tentei fazer o codigo de forma facil de ser compreendida



1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência. 

2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre. 

3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA); 

Ao final do processamento, qual será o valor da variável SOMA? 

Resposta 77

4) Descubra a lógica e complete o próximo elemento: 
a) 1, 3, 5, 7, ___ 
b) 2, 4, 8, 16, 32, 64, ____ 
c) 0, 1, 4, 9, 16, 25, 36, ____ 
d) 4, 16, 36, 64, ____ 
e) 1, 1, 2, 3, 5, 8, ____ 
f) 2,10, 12, 16, 17, 18, 19, ____

5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?   

Resposta lampada: primeiro eu ligo 1 lampada, e vou em uma sala, caso acesa eu sei o interruptor dessa sala, então eu volto e ligo outro, vou em outra sala, se tbm estiver acesa eu sei o interruptor dessa sala e consequentemente eu deduzo o ultimo interruptor por eliminação, caso esteja desligada eu deduzo o ultimo interruptor por eliminação tambem. Porem, se a primeira sala que eu entrei não estiver com a lampada acesa, desligo o interruptor que eu havia ligado, ligo outro interruptor e entro em uma sala diferente se a sala estiver ligada eu descubro o interruptor dela pois é o unico ligado, e o que eu desliguei é da sala que eu não entrei, e o que eu nao mexi é o da primeira sala que eu entrei, caso a sala esteja desliga o interruptor correspondente é o que eu desliguei, o aceso é a sala que eu não entrei, e o que eu não mexi é da primeira sala que eu entrei.
