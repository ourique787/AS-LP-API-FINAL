Texto: Dentro dos arquivos, ou através do link: https://docs.google.com/document/d/1gDUYpJofMOrXlmcXPClr9zxGxfmRmhuyidTkUD2iXs8/edit?usp=sharing

Vídeo: https://www.youtube.com/watch?v=zHDjYZ-PySY

Instruções de uso: Clonar os arquivos, executar um terminal e digitar: dotnet run

Após isso, o terminal deve acusar um url base, copiar esse URL e configurar dentro do POSTMAN, INSOMNIA ou Swagger, eu utilizei o Postman:

Configure as requisições:
GET/http://localhost:5203/api/pedidos
Para listar todos os pedidos, lembrando que o localhost:5203 é o meu padrão, utilize o que aparecer no terminal, e lembrando que o /pedidos pode ser /fornecedores, isso vai com sua preferência;
POST/http://localhost:5203/api/pedidos
Para criar um pedido, lembre de passar no body o que você quer criar: Exemplo:
{
    "Id": 3,
    "Data": "2024-12-03",
    "ValorTotal": 200.0,
    "Status": "Pendente",
    "Descricao": "Teste pedido 2"
}
PUT/http://localhost:5203/api/pedidos/{id}
Para editar o pedido que você deseja, lembre de passar no body novamente, exemplo:
{
  "Id": 3,
  "Data": "2024-12-04T10:00:00",
  "ValorTotal": 150.00,
  "Status": "Processado",
  "Descricao": "Teste video atualizado sss2"
}

Nesse caso, deve mudar na URL, onde tem /{id} substituir por 3, para modificar o ID numero 3:

GET/http://localhost:5203/api/pedidos/{id}

Nesse caso estamos listando apenas o pedido de algum id que passaremos no final, por exemplo: http://localhost:5203/api/pedidos/3 para listar o pedido 3.
Substitua o {id} pelo id do pedido;

DELETE/http://localhost:5203/api/pedidos/{id}

Substitua o {id} por algum número de id, para deletar o pedido.

LEMBRANDO: FUNCIONA COM FORNECEDORES, É APENAS NECESSÁRIO TROCAR, ONDE TEM /PEDIDOS, COLOCAR /FORNECEDORES.

Arquivos armazenados no app.db, utilizando o SQLite.

