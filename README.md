# CalcularDigitoARCorreios

Para aqueles assim como eu que precisou pesquisar na internet e procurar como fazer o cálculo da **digito verificador** do AR dos correios.

### Como Contribuir?

Você pode contruibuir para este repositório utilizando a sessão de [Issues](https://github.com/jfilman/CalcularDigitoARCorreios/issues) aqui do GitHub. Basta criar um novo issue com correções, melhorias ou até mesmo implementações em outras linguagens.

A ideia é que possamos ter em diversas linguagem a mesma lógica e abordagem para que todos possam usufruir desse código.

Se você você contruibuir com outras linguagem é só criar uma pasta com o nome da linguagem que estará implementando o método e deixar seu arquivo dentro da pasta com o código aplicado.

### Como Usar?

A ideia é não precisar isntanciar o objeto e sim usar como um objeto estático e passar o número do AR para que seja calculado.

Exemplo C#:
```
string arComDV = Helper.FuncoesString.CalcularDVAR("12345678");
```
