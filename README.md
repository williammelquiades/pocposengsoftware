## Automação

# Introdução ao iniciar essa pratica você deve seguir os passo abaixo ao clonar o pacote.

1.: 

No Visual Studio vá em 
Tools -> NuGet Package Manager -> Package Management Console. 
No console aberto em alguma das janelas digite o comando abaixo:
Update-Package -reinstall

https://blog.mzikmund.com/2018/02/tip-force-reinstall-nuget-packages/
https://stackoverflow.com/questions/6876732/how-do-i-get-nuget-to-install-update-all-the-packages-in-the-packages-config
https://docs.microsoft.com/en-us/nuget/consume-packages/reinstalling-and-updating-packages

2.: 

Em Gerenciador de solução >> [na solução de projeto clicar com botão direito do mouse] >> Gerenciar Pacote do Nuget para a solução >>
e atualize todos os Pacote. 

3.: 

Verifique se a versão do chrome instalado na máquina é igual ao versão disponível no gerenciador.
If not, acessar site ( https://chromedriver.chromium.org/downloads ) e baixar versão correspondente a instalada na máquina

#Composição do projeto

- Arquitetura Projeto
	- Linguagem		- [CSharp](https://docs.microsoft.com/pt-br/dotnet/csharp/ "CSharp")
	- Framework de desenvolvimento: .NET Full Framework 4.6.1
	- Framework de Testes
	- Orquestrador de testes - [NUnit 3.11](https://github.com/nunit/nunit "NUnit 3.11")
	- Framework interação com elementos web - [Selenium.WebDriver 3.141](https://www.seleniumhq.org/download/ "Selenium.WebDriver") 

