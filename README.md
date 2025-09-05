# Estudo sobre Command Pattern
Eu fiz este projeto para estudar a implentação e comportamento do padrão de design (design pattern) de command pattern na unity.

Minhas principais referências foram
- [Canal iHeartGameDev](https://www.youtube.com/watch?v=oLRINAn0cuw)
- [Manul do Refactoring Guru](https://refactoring.guru/design-patterns/command)

## Tecnologias
- Unity 2022.3.7f1
- Visual Studio 2022

## Como Fazer o Setup
O projeto tem 2 cenas, uma chamada rádio e outra tabuleiro. Certifiquei de elas já estarem configuradas corretamente para quem for usar, apenas lembra-se de mudar o display para Full HD (1920x1080). Em caso de problemas substitua o canvas na cena pelo prefab canvas com o mesmo nome

## Como funciona o Rádio
A cena do rádio foi meu primeiro estudo de command pattern, o vídeo (refência acima) fez um exemplo simples implementando o acender e apagar de uma lâmpada, então eu resolvi também fazer algo na mesma ideia, por isso fiz um rádio, assim poderia comprrender os conceitos fundamentias: interface do comando, o comando concreto, receptor, invocador e cliente.
O rádio tem 3 botões: um de play/pause e 2 setas (esquerda e direita), representando a mudança de faixa, cada vez que o usuário interege com esses botões o padrão de comando faz seu trabalho e gurada a ação. O botão mais a direita tem o botão 'Voltar', que usa o comando para desfazer as ações, por exeplo: o usuário clicou na seguinte ordem - play/pause, direita, play/pause, esquerda, direita - o command desfaz cada a ação fazendo então: esquerda, direita, play/pause, esquerda, play/pause.
<img width="1914" height="1020" alt="image" src="https://github.com/user-attachments/assets/307c298a-d96e-434b-9ce4-62d9c7eefc6a" />


## Como funciona o Tabueleiro
Após aprender como o command pattern funciona com o exemplo simples do rádio (descrito acima), eu resolvi implementar em algo em que este design pattern é fundamental: um jogo de tabuleiro, já que é comumm esses jogos apresentarem a opção de desfazer alguma jogada, como ocorre no xadrez ou em damas.
Porém nesse exemplo resolvi fazer algo um pouco mais simple que xadrez (pois envolveria fazer todas as peças e tals), há apenas uma peça no tabuleiro eo jogador pode movê-la para as 4 direções: esquerda, cima, direita ou baixo. E no canto superior direito há a opção para desfazer a jogada. Graças a funcionalidade do padrão de comando o jogador pode se mover livrimente, assim como ele sempre pode voltar uma jogada ou e até mesmo voltar para o tabuleiro para um estado incial.
<img width="1919" height="1018" alt="image" src="https://github.com/user-attachments/assets/2d0b1b6b-c95f-4d13-ad96-3466cefd1353" />



## Próximos Passos
Usar a estrutura do jogo de tabuleiro para fazer algum jogo de tabuleiro de fato, como damas ou xadrez
