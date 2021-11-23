using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.DataBaseSteps;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Pages;
using NUnit.Framework;
using System.Collections;

namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        #region Pages and Flows Objects
        LoginPage loginPage;
        MainPage mainPage;
        #endregion

        #region Data Driven Providers
        public static IEnumerable EfetuarLoginInformandoUsuarioInvalidoIProvider()
        {
            return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "Resources/TestData/Login/EfetuarLoginInformandoUsuarioInvalidoData.csv");
        }
        #endregion

        [Test]
        public void EfetuarLoginComSucesso()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();

            #region Parameters
            string usuario = "templateautomacao";
            string senha = "123456";
            #endregion

            loginPage.PreencherUsuario(usuario);
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmLogin();

            Assert.AreEqual(usuario, mainPage.RetornaUsernameDasInformacoesDeLogin());
        }

        [Test]
        public void EfetuarLoginInformandoSenhaInvalida()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();

            #region Parameters
            string usuario = "templateautomacao";
            string senha = "senhainvalida";
            string mensagemErroEsperada = "Your account may be disabled or blocked or the username/password you entered is incorrect.";
            #endregion

            loginPage.PreencherUsuario(usuario);
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmLogin();

            Assert.AreEqual(mensagemErroEsperada, loginPage.RetornaMensagemDeErro());
        }

        //Exemplo utilizando um retorno de uma query de banco de dados
        [Test]
        public void EfetuarLoginComSucesso2()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();

            #region Parameters
            string usuario = "templateautomacao";
            string senha = UsuariosDBSteps.RetornaSenhaDoUsuario(usuario);
            #endregion

            loginPage.PreencherUsuario(usuario);
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmLogin();

            Assert.AreEqual(usuario, mainPage.RetornaUsernameDasInformacoesDeLogin());
        }

        [Test, TestCaseSource("EfetuarLoginInformandoUsuarioInvalidoIProvider")]
        public void EfetuarLoginInformandoUsuarioInvalido(ArrayList testData)
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();

            #region Parameters
            string usuario = testData[0].ToString();
            string senha = testData[1].ToString();
            string mensagemErroEsperada = "Your account may be disabled or blocked or the username/password you entered is incorrect.";
            #endregion

            loginPage.PreencherUsuario(usuario);
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmLogin();

            Assert.AreEqual(mensagemErroEsperada, loginPage.RetornaMensagemDeErro());
        }
    }
}
