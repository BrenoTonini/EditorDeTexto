# Editor de Texto com Verificação de Ortografia

Este projeto foi desenvolvido como parte da disciplina **Algoritmos e Estruturas de Dados II**, com o objetivo de aplicar estruturas de dados, como árvores binárias e tabelas hash, na implementação de um editor de texto com verificação ortográfica em tempo real. Todas as estruturas de dados foram implementadas manualmente, sem o uso de bibliotecas ou estruturas nativas da linguagem.

## Objetivo do Projeto

O editor verifica as palavras digitadas pelo usuário, comparando-as com um dicionário de palavras. As palavras não reconhecidas são destacadas em vermelho, sinalizando possíveis erros ortográficos. Além disso, o editor permite a importação de novos dicionários, que são carregados e organizados em estruturas de dados personalizadas para garantir uma busca eficiente.

## Funcionalidades

- **Verificação Ortográfica em Tempo Real:** Com o uso de árvore binária e tabela hash, o editor realiza buscas rápidas para identificar se uma palavra está no dicionário. Palavras não reconhecidas são destacadas em vermelho.
- **Carregar Arquivos de Texto:** Permite abrir arquivos `.txt` para visualização e edição, com a verificação ortográfica ativa.
- **Salvar Arquivos Editados:** Salva o conteúdo do editor em um arquivo `.txt`, mantendo as alterações realizadas.
- **Importação de Dicionários Personalizados:** Suporta a adição de novos dicionários de palavras, permitindo que o usuário personalize o verificador com novas entradas.

## Estruturas de Dados Utilizadas

Este projeto destaca o uso das seguintes estruturas de dados, todas implementadas manualmente:

- **Árvore Binária (Binary Tree):** Estrutura construída manualmente para armazenar e organizar as palavras do dicionário, facilitando a navegação e inserção de novos termos.
- **Tabela Hash (Hash Table):** Implementada manualmente para otimizar a busca de palavras no dicionário, possibilitando verificações rápidas mesmo em grandes listas de palavras.

Essas estruturas foram criadas do zero, com o objetivo de aprofundar o entendimento de algoritmos e estruturas de dados, sem recorrer a implementações prontas da linguagem C#.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** Windows Forms
- **IDE:** Visual Studio

## Como Usar

1. **Carregar um Arquivo de Texto:** Clique em "Carregar Arquivo" e selecione um arquivo `.txt` para abrir o conteúdo no editor.
2. **Digitar e Verificar Ortografia:** Digite no editor. As palavras não reconhecidas pelo dicionário serão destacadas em vermelho.
3. **Salvar Arquivo:** Clique em "Salvar Arquivo" para gravar o conteúdo editado.
4. **Importar Dicionário:** Use a opção "Importar Dicionário" para adicionar novas palavras ao verificador ortográfico.

## Observações

- Este projeto é um exercício acadêmico para prática de algoritmos e estruturas de dados, focado na criação manual dessas estruturas, sem otimização para uso em produção.
- A verificação ortográfica é feita com comparações diretas utilizando a árvore binária e a tabela hash implementadas neste projeto.

## Contribuição

Projeto acadêmico não aberto para contribuições externas. No entanto, sinta-se à vontade para clonar o repositório e realizar modificações para aprendizado pessoal.

---

Desenvolvido como parte da disciplina **Algoritmos e Estruturas de Dados II - Faculdade UCL**.
