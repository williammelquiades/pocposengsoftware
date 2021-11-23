using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.Flows;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
    public class ReportIssueTests : TestBase
    {

        #region Page Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        BugReportPage bugReportPage;
        #endregion

        [Test]
        public void CadastrarNovaIssueComSucessoInformandoSomenteCamposObrigatorios()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            bugReportPage = new BugReportPage();

            #region Parameters
            string usuario = "templateautomacao";
            string senha = "123456";
            string categoria = "[All Projects] Apptest";
            string resumo = "Resumo teste automático " + GeneralHelpers.ReturnStringWithRandomCharacters(5);
            string descricao = "Descrição teste automático";
            string caminhoArquivo = GeneralHelpers.ReturnProjectPath() + "Resources/Files/anexo_ocorrencia.jpg";
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);

            mainPage.AcessarReportIssue();

            bugReportPage.SelecionarCategoria(categoria);
            bugReportPage.PreencherResumo(resumo);
            bugReportPage.PreencherDescricao(descricao);
            bugReportPage.ClicarEmSubmitReport();
        }
    }
}
