# MusicasAPI

Uma API simples em .NET Core para gerenciar uma coleção de músicas. Desenvolvido com o GitHub Flow.

## Sumário

- [Instalação](#instalação)
- [Como Usar](#utilização-da-api)
- [GitHub Flow](#github-flow)

## Instalação

Instruções para instalar o projeto localmente.

1. Certifique-se de ter o **SDK do .NET Core** instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
2. Clone este repositório para o seu ambiente local usando o seguinte comando:

    ```bash
    git clone https://github.com/Marina-Flores/MusicasAPI.git
    ```

3. Navegue até o diretório do projeto.
4. Execute o projeto:

    ```bash
    dotnet run
    ```

Isso iniciará o servidor da API localmente.

## Utilização da API

A API pode ser acessada através de URLs como `http://localhost:<port>/musicas`. Você pode usar ferramentas como [Postman](https://www.postman.com/downloads/) para interagir com os endpoints.

### Exemplos de Endpoints:

- **GET /musicas**: Retorna todas as músicas.
- **POST /musicas**: Adiciona uma nova música.
 
## GitHub Flow

Para este projeto, estou utilizando o **GitHub Flow** como fluxo de trabalho. O GitHub Flow é simples e eficiente, sendo ideal para projetos onde:

1. Não há necessidade de gerenciar versões complexas.
2. O projeto será trabalhado por uma única pessoa.

### Por que GitHub Flow?

Embora existam fluxos de trabalho mais complexos, como o **Git Flow** ou **GitLab Flow**, o **GitHub Flow** atende perfeitamente às minhas necessidades neste projeto. Como estou desenvolvendo sozinho e não preciso gerenciar múltiplas versões ou colaborar com outras pessoas, o GitHub Flow proporciona uma abordagem mais simples e direta.

### Como funciona o GitHub Flow neste projeto?

1. **Branch principal (`main`)**:
   - A branch `main` sempre estará com o código mais estável.
   - As novas funcionalidades ou ajustes são feitas em **branches separadas**.

2. **Branches de feature**:
   - Para adicionar novas funcionalidades ou corrigir problemas, crio **branches específicas** a partir da `main`, como `feature/adicionar-musica` ou `feature/listar-musicas`.
   
3. **Pull Requests**:
   - Após a implementação de uma funcionalidade, abro um **Pull Request** para revisar as alterações antes de mesclá-las na `main`.

4. **Merge**:
   - Uma vez que o Pull Request é revisado e as mudanças estão prontas, elas são **mescladas na `main`**.

Este fluxo de trabalho mantém o processo simples, limpo e organizado, sem a complexidade adicional que seria necessária em projetos maiores ou colaborativos.

### Benefícios de usar o GitHub Flow neste projeto:

- **Simplicidade**: Sem a necessidade de múltiplas branches como em fluxos mais complexos.
- **Produtividade**: Como estou trabalhando sozinha, posso focar diretamente nas tarefas sem precisar me preocupar com gerenciar múltiplas versões ou equipes.
- **Velocidade**: A abordagem direta e com Pull Requests permite uma rápida integração de novas funcionalidades com menos etapas.
