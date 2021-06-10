# Desafio Pagar.Me

# O Desafio
O trabalho será adicionar uma nova funcionalidade para o sistema para que eles possam vender uma nova categoria de itens.
- Permitir a venda de um novo Item (Conjured Mana Cake)

Obs.: Os itens "Conjurados" (Conjured) diminuem a qualidade (quality) duas vezes mais rápido que os outros itens.

# Explanação do desafio
Comecei tentando entender a lógica do sistema, inicialmente foi um pouco complicado em virtude de toda pressão que a resolução de um desafio carrega, mas depois tudo foi ficando mais claro e compreensível. Controlei a ansiedade e comecei a perceber que o problema era mais simples do que eu imaginava.

Iniciei implementando a funcionalidade que foi proposta. Até que foi bem simples, acrescentei algumas verificações com o condicional IF, e ele passou a funcionar e seguir as regras que foram solicitadas como por exemplo: 

- [x] - “Os itens ‘Conjurados’ (Conjured) diminuem a qualidade (quality) duas vezes mais rápido que os outros itens”;
Todo item que perde a data de venda (SellIn) também segue a mesma lógica de duplicar a perda de qualidade(quality), então quando os itens ‘Conjurados’ perdem a validade agora eles perdem 4 de quality por dia.

- [x] - Em seguida comecei a cobrir com testes todos os cenários de negócio seguindo o padrão AAA,os mesmos foram bem simples, nada muito rebuscado, mas que garantem que qualquer mudança que fuja da regra de negócio seja rapidamente descoberta, então, meus testes estão garantindo as regras do programa.

Após terminá-los refatorei o cor da aplicação que fica na classe GildedRose.cs, abstraí os códigos para funções e alterei os nomes para os melhores possíveis no momento visando um código mais legível.

# Observações

1 - Um ponto que observei é que sulfuras não precisam ter uma data de venda (SellIn) segundo os requisitos. Mas na linha 17 da classe Program é iniciado um (Sulfuras) com o valor -1 em SellIn, ou seja, é como se tivesse passado a data de venda. Pensei em colocar uma verificação caso o SellIn fosse menor que 0, ele modificaria SellIn para 0. Se essa situação fosse dentro da empresa acredito que levaria essa discussão para a equipe pensar coletivamente.

# Considerações finais

O desafio foi bem legal, algo simples mas que mexeu com a minha mente, precisei entender a lógica e todo emaranhado de if e else que tinha no código para aplicar a nova funcionalidade. Depois apliquei os testes para garantir que qualquer mudança minha não alterasse a regra de negócio e consegui refatorar, melhorando a legibilidade do código na minha opinião.
