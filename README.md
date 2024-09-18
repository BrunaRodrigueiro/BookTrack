
---

# Controle de Estoque

Este projeto é um **sistema de controle de estoque** desenvolvido em **C#**, que permite ao usuário gerenciar produtos de forma simples e eficiente. O sistema oferece funcionalidades para cadastrar produtos, listar os produtos cadastrados, remover produtos, registrar entradas e saídas de estoque e finalizar o programa.

## Funcionalidades

- **Cadastrar Produto:** O usuário pode adicionar novos produtos ao sistema, incluindo informações como nome do produto, preço e quantidade em estoque.
- **Listar Produtos:** Exibe todos os produtos cadastrados no sistema com suas respectivas quantidades e preços.
- **Remover Produto:** Permite ao usuário remover um produto específico do estoque.
- **Entrada de Estoque:** Adiciona quantidades ao estoque de um produto existente.
- **Saída de Estoque:** Deduz quantidades do estoque de um produto.
- **Sair do Sistema:** Finaliza a execução do programa.

## Como utilizar

1. Clone o repositório:
   ```bash
   git clone https://github.com/SeuUsuario/controle-de-estoque.git
   ```

2. Abra o projeto em um ambiente de desenvolvimento compatível com C#, como o **Visual Studio** ou **VS Code**.

3. Execute o projeto. Um menu será exibido com as seguintes opções:
   ```
   1. Nova
   2. Listar Produtos
   3. Remover Produto
   4. Entrada de Estoque
   5. Saída de Estoque
   6. Sair
   ```

4. Selecione a opção desejada digitando o número correspondente e siga as instruções na tela.

## Estrutura do Projeto

- **Classes:** O sistema contém uma classe `Produto` que encapsula os atributos de cada produto (nome, preço e quantidade em estoque).
- **Lógica de controle:** As opções de menu e a lógica de manipulação dos produtos estão centralizadas na classe principal do programa.

## Requisitos

- **.NET Core SDK** (versão 5.0 ou superior)
- **IDE ou Editor de Código** que suporte C# (ex: Visual Studio, VS Code)

## Contribuindo

Se você quiser contribuir com melhorias ou correções, sinta-se à vontade para abrir um pull request. Toda ajuda é bem-vinda!

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
