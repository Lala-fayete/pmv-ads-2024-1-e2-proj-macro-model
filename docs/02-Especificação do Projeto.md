# Especificações do Projeto
| Perfis de Administrador | Perfil de Cliente |
|-------------------------|--------------------|
| Usuário responsável pelo gerenciamento e abastecimento do site. | Usuário que irá utilizar o conteúdo e a interface como consumidor.|
| Ter conhecimento sobre necessidades do site através de chamados abertos usuários no site. | Obter acesso fácil e rápido a informações sobre os alimentos catalogados os itens com informações personalizadas para preservar a integridade de consumo. |
| Abastecer a página inicial com informações de notícias atualizadas, verificadas e que promovam interesse pela plataforma. | Ter acesso ao seu perfil próprio, onde consiga visualizar os alimentos catálogos de forma centralizada e intuitiva. |

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `QUEM`| QUERO/PRECISO ... `O QUE` |PARA ... `PORQUE`                 |
|--------------------|------------------------------------|----------------------------------------|
|ADMINISTRADOR | Consultar chamados de suporte abertos. | Fornecer suporte para os usuários e ter conhecimento dos problemas que estão ocorrendo com os clientes na plataforma.  |
|ADMINISTRADOR | Fornecer imagens de itens ou analisar imagens. | Possibilitando a opção de compra de determinado item para colecionadores. |
|ADMINISTRADOR | Gerar e Filtrar. | Ter acesso a informações sobre a movimentação do site para acompanhamento. |
|ADMINISTRADOR | Adicionar, editar ou excluir usuários do sistema. | Gerenciar o acesso e as permissões dos usuários na plataforma. |
|ADMINISTRADOR | Configurar e personalizar as preferências e configurações do sistema. | Adaptar a plataforma às necessidades específicas da minha organização. |
|ADMINISTRADOR | Ter acesso a um painel de controle intuitivo e fácil de usar. | Facilitar a navegação e a administração da plataforma, mesmo sem conhecimento técnico avançado. |
|CLIENTE | Poder localizar o alimento através do filtro de pesquisa. | Realizar interações de texto com disponível(somente leitura). |
|CLIENTE | Acessar informações detalhadas sobre a composição nutricional de alimentos naturais e saudáveis. | Auxiliar na elaboração de planos alimentares personalizados para meus clientes, promovendo a saúde e o bem-estar. |
|CLIENTE | Encontrar informações sobre os benefícios para a saúde de diferentes alimentos naturais e suas propriedades nutricionais. | Incorporar escolhas alimentares mais saudáveis na minha dieta diária e melhorar minha qualidade de vida. |
|CLIENTE | Acessar dados sobre o alimento saudável e seus benefícios. | Informar e educar o público sobre a importância de escolhas alimentares conscientes e promover hábitos saudáveis de vida.|
|CLIENTE | Encontrar informações sobre opções de alimentos naturais e saudáveis que atendam às minhas necessidades dietéticas específicas. | Manter uma dieta equilibrada e saudável, mesmo com restrições alimentares, e garantir minha nutrição adequada.|
|CLIENTE | Acessar informações sobre alimentos que atendam às minhas necessidades nutricionais específicas, levando em consideração minha prática esportiva. | Garantir que minha dieta seja adequada para sustentar meu desempenho atlético, mesmo com restrições alimentares.|
|CLIENTE | Encontrar recursos sobre alimentação saudável que sejam compatíveis com minha condição médica, como diabetes, doença celíaca, alergias alimentares, entre outras. | Gerenciar minha condição de saúde através de uma dieta adequada e segura, minimizando sintomas e promovendo meu bem-estar geral.|
|CLIENTE | Descobrir opções de alimentos que se encaixem no meu estilo de vida vegano/vegetariano e também atendam às minhas restrições alimentares específicas.| Manter uma dieta variada, equilibrada e nutritiva, mesmo com múltiplas restrições alimentares, sem comprometer meus princípios éticos ou minha saúde.|
|CLIENTE | Encontrar informações sobre opções de alimentos que estejam alinhadas com minhas crenças ou convicções pessoais, como dietas kosher, halal, ou outras restrições alimentares baseadas em princípios religiosos ou éticos. | Seguir minha dieta de acordo com minhas convicções pessoais, respeitando minhas tradições e valores culturais. |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Na página inicial, o site deve permitir um cadastro de conta. | ALTA | 
|RF-002| Na página inicial, o site deve permitir realizar o login.   | ALTA |
|RF-003| A página inicial deve ter um botão no menu para a tela “Quem Somos”, que dará mais detalhes sobre o site e o grupo desenvolvedor.   | Baixa |
|RF-004| No cadastro de novo usuário, o sistema deverá consultar a disponibilidade do nome de usuário desejado, para que não existam perfis com nomes de usuário repetidos.   | Alta |
|RF-005| Todos os campos no cadastro e login devem ser obrigatórios.   | Alta |
|RF-006| Na tela de Alteração de Banners, o perfil administrador deve conseguir fazer upload da imagem, escolher quantos imagens terão.   | MÉDIA |
|RF-007| Na abertura de chamado deve-se permitir anexar uma imagem.  | MÉDIA  |
|RF-008| Todos os tipos de perfis após logados, na tela interna, terão um menu lateral esquerdo com as funções disponíveis, uma tela central onde serão apresentadas as telas internas, na parte superior esquerda deve ter a logo do site, na parte superior direita deve ter sobre o usuário logado: Foto; Nome de Usuário; Sair.   | MÉDIA |
|RF-009| A tela alimentos deverá apresentar os botões: Filtrar por Ordem Alfabética.  | Alta |
|RF-010| A tela de Criar Nova Pasta deverá ter os campos obrigatórios a preencher: Título da Pasta; Privacidade   | Alta |
|RF-011| A tela de Alterar Foto deve ser apresentada ao clicar em Alterar Foto no menu esquerdo.   | Baixa |
|RF-012| A tela de Adicionar Novo Item deverá ter os campos: Título do Item; Categoria; Inserir Imagem.   | Alta |
|RF-013| A tela de Alterar Item deverá ter os campos: Título do Item; Categoria; Inserir Imagem.   | Alta |
|RF-014| O botão de Excluir Item deverá excluir o item do card.   | MÉDIA  |
|RF-015| A tela de Visualizar Item permitirá o usuário visualizar os campos: Imagem do item; Título do Item; Categoria   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| Aplicação deve permitir meios de compartilhamento Web. |  ALTA | 
|RNF-003| A aplicação deve ser compatível com os navegadores. Deve ser compatível com os principais navegadores do mercado: Google Chrome, Firefox e Microsoft Edge. | ALTA | 
|RNF-004| A aplicação deve ter bom nível de contraste entre os elementos da tela. |  MÉDIA | 
|RNF-005| A aplicação web deve possuir um bom desempenho de tempo. Estimativa: Processamento de telas em até 15 segundos. | MÉDIA | 
|RNF-006| A aplicação deve ser responsiva, adaptando-se automaticamente a diferentes tamanhos de tela e resoluções, proporcionando uma boa experiência de usuário em dispositivos móveis. |  ALTA | 
|RNF-007| A aplicação deve ser escalável, capaz de lidar com um aumento significativo no número de usuários e no volume de dados sem comprometer o desempenho. |  ALTA | 
|RNF-008| A aplicação deve ser de fácil manutenção, com código bem organizado e documentado, facilitando futuras atualizações e correções de bugs. |  MÉDIA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| A aplicação deve ser entregue de forma plenamente funcional até 23/06/2024. |
|RE-02| A aplicação deve ser desenvolvida exclusivamente pelos membros do grupo.|
|RE-03| O aplicativo deve utilizar conhecimentos de SQL e Modelagem de Dados, Engenharia de Requisitos de Software, Programação Modular, Algoritmos e Estruturas de Dados, Desenvolvimento Web Back-End e Front-End e Fundamentos de Redes de Computadores.|
|RE-04| A aplicação é responsável por garantir que o banco de dados esteja sempre preciso e atualizado, garantindo que todas as informações nele contidas reflitam com precisão as últimas mudanças e atualizações relevantes. Esta medida é crucial para assegurar que os usuários tenham acesso a dados confiáveis e atualizados, promovendo assim a eficácia e a utilidade da aplicação em fornecer informações precisas e relevantes. |
|RE-05| A aplicação deve atender a todas as regulamentações e leis pertinentes ao setor e à localização geográfica em que opera. Isso pode incluir conformidade com leis de privacidade de dados, acessibilidade da web, padrões de segurança cibernética, entre outros. |
|RE-06| A equipe do projeto deve deter o conhecimento necessário para o pleno desenvolvimento da aplicação.|
|RE-07| A em desenvolvimento...|

## Gerenciamento de Projeto
- A metodologia Scrum foi selecionada como a abordagem ágil do nosso projeto de desenvolvimento de aplicação web, tendo em vista os benefícios destacados no cotidiano do mercado da tecnologia. Tais benefícios incluem a definição clara dos resultados a serem alcançados, a imposição de um ritmo disciplinado de execução do trabalho, alocação precisa de papéis e responsabilidades (Scrum Owner, Scrum Master e Team), o empoderamento da equipe para enfrentar desafios, a distribuição colaborativa e compartilhada do conhecimento e a promoção de um ambiente propício à crítica construtiva das ideias. Estas razões solidificam a escolha do Scrum como a metodologia mais adequada para garantir o êxito do nosso projeto de aplicação web.


## Divisão de Papéis
A equipe utiliza o Scrum como base para definição do processo de desenvolvimento.
-	Product Owner: Pedro Roberto Gomes da Silva Abadia
-	Scrum Master: João Gabriel Barrozo Rocha
-	Equipe de Desenvolvimento: , Jonathan Vaz de Avelar, Lucas Antonio Miranda da Silva, 
-	Equipe de Design: Lafayete Queiroz Horta


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
