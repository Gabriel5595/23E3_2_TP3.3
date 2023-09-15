# Teste de Performance 3
## Exercício #3
Implemente um programa no qual o usuário controle um sistema de imobiliária, onde seja necessário calcular o valor total do imóvel, inclusive com tributo (ITBI).

### Requisitos:

1. Imposto para imóvel usado: 15%
2. Imposto para imóvel novo: 5%

### Requisitos técnicos:

1. Implemente uma interface ITributavel, e defina o método CalcularValorTotal;
2. Crie uma classe para representar imóvel, e implemente a interface criada no item anterior. Implemente o método CalcularValorTotal com base nas regras de negócio;
3. Crie um construtor parametrizado na classe anterior. Certifique-se de sinalizar no construtor, se o imóvel é novo ou usado, além do seu valor de venda.
4. Instancie no programa principal um imóvel novo e um imóvel usado, informando seu valor de venda (valor fictício). Para cada tipo de imóvel, exiba em seguida o valor total (com imposto);