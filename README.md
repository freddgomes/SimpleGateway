# Simple Gateway

Esse projeto é a implementação de uma API REST que funciona como um gateway de pagamento.

Atualmente a API faz integração com a Adquirente Cielo e suporta apenas transações com cartão de crédito (Ambiente de Sandbox).
Integrações com ambientes de teste de outras adquirentes serão adicionadas.
Também será feita integração com serviço de antifraude.

## Ferramentas usadas

- Visual Studio Community 2017
- Sql Server Express 2017
- Postman

## Instruções para execução do projeto em ambiente local

- Certifique-se de ter o visual studio, preferencialmente na versão 2017 e o sql server express instalados.
- Clone o projeto para ambiente local.
- Execute os scripts de banco disponibilizados junto ao projeto em sua instância do sql server.
- Ajuste a string de conexão com o banco de dados que está no arquivo appsettings.json do projeto.
- Acesse o link e crie as credenciais necessárias para realizar transações, usando a Cielo: <https://cadastrosandbox.cieloecommerce.cielo.com.br/>
- Junto ao projeto, existe um arquivo que poder importado no Postman. Esse arquivo tem uma coleção com exemplos de requisições que podem ser realizadas na API.
- As Credenciais geradas pela Adquirente, podem ser usadas na coleção para criar e consultar transação.
- Ao consultar uma transação, informe o identificador da loja (Use o merchant id gerado pela adquirente).