﻿using LocadorAutomoveis.Aplicacao.ModuloDisciplina;
using LocadorAutomoveis.Aplicacao.ModuloFuncionario;
using LocadorAutomoveis.Aplicacao.ModuloGrupoAutomoveis;
using LocadorAutomoveis.Dominio.ModuloDisciplina;
using LocadorAutomoveis.Dominio.ModuloFuncionario;
using LocadorAutomoveis.Dominio.ModuloGrupoAutomoveis;
using LocadorAutomoveis.Infra.Orm.Compartilhado;
using LocadorAutomoveis.Infra.Orm.ModiuloFuncionario;
using LocadorAutomoveis.Infra.Orm.ModuloDisciplina;
using LocadorAutomoveis.Infra.Orm.ModuloGrupoAutomoveis;
using LocadorAutomoveis.WinApp.ModuloDisciplina;
using LocadorAutomoveis.WinApp.ModuloFuncionario;
using LocadorAutomoveis.WinApp.ModuloGrupoAutomoveis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadorAutomoveis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private Dictionary<string, ControladorBase> controladores;

        private ControladorBase controlador;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            controladores = new Dictionary<string, ControladorBase>();

            ConfigurarControladores();
        }

        private void ConfigurarControladores()
        {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<LocadorAutomoveisDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadorAutomoveisDbContext(optionsBuilder.Options);

            var migracoesPendentes = dbContext.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0)
            {
                dbContext.Database.Migrate();
            }

            IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmOrm(dbContext);
            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioEmOrm(dbContext);

            ValidadorDisciplina validadorDisciplina = new ValidadorDisciplina();

            ServicoDisciplina servicoDisciplina = new ServicoDisciplina(repositorioDisciplina, validadorDisciplina);

            controladores.Add("ControladorGrupoDisciplina", new ControladorDisciplina(repositorioDisciplina, servicoDisciplina));

            IRepositorioGrupoAutomoveis repositorioGrupoAutomoveis = new RepositorioGrupoAutomoveisEmOrm(dbContext);

            ValidadorGrupoAutomoveis validadorGrupoAutomoveis = new ValidadorGrupoAutomoveis();

            ServicoGrupoAutomoveis servicoGrupoAutomoveis = new ServicoGrupoAutomoveis(repositorioGrupoAutomoveis, validadorGrupoAutomoveis);

            controladores.Add("ControladorGrupoAutomoveis", new ControladorGrupoAutomoveis(repositorioGrupoAutomoveis, servicoGrupoAutomoveis));
            ValidadorFuncionario validadorFuncionario = new ValidadorFuncionario();

            ServicoFuncionario servicoFuncionario = new ServicoFuncionario(repositorioFuncionario, validadorFuncionario);

            controladores.Add("ControladorGrupoFuncionarios", new ControladorFuncionario(repositorioFuncionario, servicoFuncionario));

        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape()
        {
            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorDisciplina"]);
        }

        private void gruposDeAutomóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomoveis"]);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();

            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoFuncionarios"]);
        }
    }
}