# Feedback - Avaliação Geral

## Front End
### Navegação
  * Pontos positivos:
    - Possui estrutura MVC com views no projeto MiniLojaVirtualMVC
    - Separação clara entre MVC e API em projetos distintos

### Design
    - Será avaliado na entrega final

### Funcionalidade
  * Pontos positivos:
    - Estrutura básica do projeto MVC está presente
    - Integração com Identity para autenticação

## Back End
### Arquitetura
  * Pontos positivos:
    - Arquitetura corretamente dividida em 3 camadas: MiniLojaVirtual.Api, MiniLojaVirtual.MVC e MiniLojaVirtual.Common
    - Estrutura enxuta e coesa, adequada para um CRUD básico
    - Separação clara entre API e MVC

  * Pontos negativos:
    - Não foram identificados pontos negativos na arquitetura, pois segue o padrão recomendado

### Funcionalidade
  * Pontos positivos:
    - Implementação do Entity Framework
    - Estrutura preparada para autenticação com Identity

  * Pontos negativos:
    - Falta de implementação do registro de Vendedor integrado ao Identity no MVC

### Modelagem
  * Pontos positivos:
    - Modelagem mantida simples e anêmica como recomendado
    - Uso do Entity Framework para persistência  

## Projeto
### Organização
  * Pontos positivos:
    - Solution file (MiniLojaVirtual.sln) na raiz do projeto
    - Projetos corretamente separados em pastas distintas
    - Estrutura de pastas organizada e coerente

  * Pontos negativos:
    - Falta da pasta src na raiz do projeto
    - Alguns arquivos que poderiam estar em pastas específicas estão na raiz

### Documentação
  * Pontos positivos:
    - README.md presente e bem estruturado
    - FEEDBACK.md presente no repositório
    - Documentação inclui instruções de execução e configuração
    - Menção ao Swagger para documentação da API

### Instalação
  * Pontos positivos:
    - Instruções de instalação presentes no README.md
    - Configuração do banco de dados documentada

  * Pontos negativos:
    - Não foi possível identificar implementação de Seed de dados
    - Falta de implementação de migrations automáticas no start da aplicação
    - Uso de SQL Server ao invés de SQLite, o que pode complicar a instalação