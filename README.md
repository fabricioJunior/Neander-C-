# Montador e simulador Neander(OBJETIVO)
Desenvolver um montador do conjunto de instruções do Neander que recebe os mnemônicos e transforma no equivalente em binário. Nesse montador deve ser possível acessar essa saída, seja através de um arquivo ou interface.

O  simulador  deve  simular  o  comportamento  do  computador  Neander,  ler  o código  gerado  pelo  montador  e  carregar  em  sua  memória como  mnemônico(Em  uma área  reservada  para  as  instruções). Em  cada  instrução  executada  deve  apresentar  uma indicação  da  instrução  em  execução,  o  resultado  do  acumuladore  do  PC,  bem  como  a modificação dos dados na memória (Em uma área reservada para os dados).Também deve apresentar as indicações de condição N e Z da ULA do Neander.

## Instruções 
end == ENDEREÇO


Código|Instrução|Operação.
------|---------|-----------:
0	  |NOP 	    | Nenhuma operação.
16 	|STA end | Armazena acumulador no endereço “end” da memória.
32 	|LDA end | Carrega o acumulador com o conteúdo do endereço “end” da memória.
48 	|ADD end | Soma o conteúdo do endereço “end” da memória ao acumulador.
64 	|OR  end | Efetua operação lógica “OU” do conteúdo do endereço “end” da memória ao acumulador.
80 	|AND end | Efetua operação lógica “E” do conteúdo do endereço “end” da memória ao acumulador.
96 	|NOT 	   | Inverte todos os bits do acumulador.
128 |JMP end | Desvio incondicional para o endereço “end” da memória.
144 |JN  end | Desvio condicional, se “N=1”, para o endereço “end” da memória.
160 |JZ  end | Desvio condicional, se “Z=1”, para o endereço “end” da memória.
240	|HLT     | Para o ciclo de busca-decodificação-execução.

## Montador 
```sh
INSTRUÇÕES.mns
SINTAXE:

(POSIÇÃO),MNEMÔNICO 
ENDEREÇO(SE HOUVER)

```
```sh
DADOS.dados
SINTAXE:

POSIÇÃO,DADO
```
