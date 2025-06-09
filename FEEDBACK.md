# Feedback - Avaliação Geral

## Front End

### Navegação
  * Pontos positivos:
    - Projeto MVC com estrutura de navegação, views e controllers implementados para autenticação, produtos e categorias.

  * Pontos negativos:
    - Nenhum.

### Design
  - Interface simples, funcional e adequada ao contexto administrativo.

### Funcionalidade
  * Pontos positivos:
    - CRUD implementado para produtos e categorias nas camadas MVC e API.
    - Auth com ASP.NET Identity presente e funcional nas duas camadas.
    - Uso de SQLite, migrations automáticas e seed de dados estão corretamente aplicados.
    - Modelagem das entidades de domínio está correta e coesa com os requisitos.

  * Pontos negativos:
    - O ID do vendedor é selecionado via drop-down ao invés de capturado do usuário logado, o que compromete a integridade e segurança.
    - Não há validação para impedir que um vendedor altere produtos de outro.
    - O registro do vendedor não é feito automaticamente no momento da criação do usuário no MVC (apenas na API).

## Back End

### Arquitetura
  * Pontos positivos:
    - Três camadas bem separadas: API, MVC e biblioteca comum (`Commom`).
    - Organização clara e modular.

  * Pontos negativos:
    - Uso de `DataAnnotations` diretamente nas entidades, ao invés de `Fluent API`, que é mais adequado ao EF Core.
    - Falta do uso de abstrações para não deixar a program.cs muito bagunçada.

### Funcionalidade
  * Pontos positivos:
    - As funcionalidades básicas de cadastro, login e gerenciamento estão disponíveis nas duas camadas.
    - Migrations automáticas e seed operacionalizados.

  * Pontos negativos:
    - Lacunas de segurança ao não validar o vendedor autenticado nas operações sensíveis.

### Modelagem
  * Pontos positivos:
    - Entidades coerentes e bem estruturadas.
    - Associação correta entre Produto, Categoria e Vendedor.

  * Pontos negativos:
    - Uso de `DataAnnotations` pode limitar a escalabilidade da modelagem.

## Projeto

### Organização
  * Pontos positivos:
    - Boa estrutura de diretórios, solution `.sln` presente, projetos bem nomeados.
    - README.md e FEEDBACK.md disponíveis.

  * Pontos negativos:
    - Nenhum ponto relevante além dos observados tecnicamente.

### Documentação
  * Pontos positivos:
    - Arquivos de documentação estão disponíveis.
    - Estrutura da documentação compatível com os padrões do curso.

### Instalação
  * Pontos positivos:
    - SQLite com seed e migrations automáticas funcionais.
    - Projeto inicia corretamente sem necessidade de configuração adicional.

  * Pontos negativos:
    - Nenhum.

---

# 📊 Matriz de Avaliação de Projetos

| **Critério**                   | **Peso** | **Nota** | **Resultado Ponderado**                  |
|-------------------------------|----------|----------|------------------------------------------|
| **Funcionalidade**            | 30%      | 8        | 2,4                                      |
| **Qualidade do Código**       | 20%      | 8        | 1,6                                      |
| **Eficiência e Desempenho**   | 20%      | 8        | 1,6                                      |
| **Inovação e Diferenciais**   | 10%      | 9        | 0,9                                      |
| **Documentação e Organização**| 10%      | 8        | 0,8                                      |
| **Resolução de Feedbacks**    | 10%      | 7        | 0,7                                      |
| **Total**                     | 100%     | -        | **8,0**                                  |

## 🎯 **Nota Final: 8 / 10**
