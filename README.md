# Calculadora IMC

* Projeto:

* Desenvolver um CRUD para cadastrar clientes de um nutricionista. Os clientes possuem os seguintes atributos: <br />

   * Cliente <br />
   * Nome <br />
   * Altura <br />
   * Peso <br />
   * Data de Nascimento <br />

Na listagem de cliente o sistema deve categorizar por grau de obesidade os clientes de acordo com seu IMC, também deverá ser exibido a idade do cliente, além das outras informações já cadastradas: <br />

O IMC é reconhecido como padrão internacional para avaliar o grau de sobrepeso e obesidade. É calculado dividindo o peso (em kg) pela altura ao quadrado (em metros). <br />

IMC = Peso ÷ (Altura × Altura)
 
| IMC | Classificação 
| :---         |     :---:      
| Menor que 18,5   | Magreza     
| Entre 18,5 e 24,9    | Normal      
| Entre 25,0 e 29,9   | Sobrepeso    
| Entre 30,0 e 39,9 | Obesidade       
| Maior que 40,0   | Obesidade Grave    


* Contruído com: 
 
  * ASPNET Core MVC;
  * Visual Studio;
  * Entity Framework;
  * HTML;
  * CSS;

* Esse projeto foi feito utilizando a arquitetura em 03 camadas:
  * Application: onde contém a parte visual e as controllers; <br />
  * Business: onde contém a criação dos serviços e interfaces; <br />
  * Data: onde contém a implementação e acesso ao banco de dados. <br />
  
* Instruções para executar o projeto:

  * Clonar o repositório; </br>
  * Abrir a solução e rodar o comando update-database no console gerenciador de pacotes como o projeto ClientesNutricao.Data selecionado (é necessário que (localdb)\\mssqllocaldb esteja disponível); </br>
  * Definir o projeto ClientesNutricao.Application como projeto de inicialização; </br>
  * Executar o projeto.
  
