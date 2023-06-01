// Questão 3
/*

a) Suponha que precisamos inserir um novo valor, exemplo 5, onde ele deve ser inserido?
obs: considere que depois precisamos depois aplicar busca binária, portanto sua
inserção não pode ser em qualquer posição.
R: O novo valor 5 seria inserido na posição 0, pois é o menor valor e deve ser colocado no início do vetor

b) Na operação anterior o que você percebeu com os outros elementos? Isso é ruim ou não? Justifique. Responda esse 
item, utilizando a análise de algoritmo e representação da complexidade para reforçar sua resposta.
R: Na operação anterior, em que inserimos o valor 5 no início do vetor {10, 20, 30, 40, 50, 60, 70, 80, 90}, todos os 
elementos subsequentes precisaram ser deslocados uma posição para a direita. Essa abordagem de deslocar os elementos
à direita para inserir um novo valor no início do vetor pode ser ineficiente quando o vetor é grande.

A complexidade de tempo para essa operação de inserção é O(n), onde n é o número de elementos no vetor. Isso ocorre 
porque, em média, metade dos elementos precisam ser deslocados para a direita para abrir espaço para o novo valor. 
Quando o vetor é grande, isso pode resultar em um alto custo computacional.
*/
