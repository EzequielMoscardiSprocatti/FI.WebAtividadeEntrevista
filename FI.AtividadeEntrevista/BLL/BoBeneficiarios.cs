using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiarios
    {
        /// <summary>
        /// Adiciona Beneficiario
        /// </summary>
        /// <param name="beneficiarios"></param>
        /// <returns></returns>
        public long Incluir(DML.Beneficiarios beneficiarios)
        {
            DAL.Clientes.DaoBeneficiarios cli = new DAL.Clientes.DaoBeneficiarios();
            return cli.Incluir(beneficiarios);
        }

        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF, int IDCLIENTE)
        {
            DAL.Clientes.DaoBeneficiarios bnf = new DAL.Clientes.DaoBeneficiarios();
            return bnf.VerificarExistencia(CPF, IDCLIENTE);
        }

        /// <summary>
        /// Altera um beneficiario
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public void Alterar(DML.Beneficiarios beneficiarios)
        {
            DAL.Clientes.DaoBeneficiarios bnf = new DAL.Clientes.DaoBeneficiarios();
            bnf.Alterar(beneficiarios);
        }

        /// <summary>
        /// Lista os Beneficiarios
        /// </summary>
        public List<DML.Beneficiarios>Pesquisa(int IdCliente)
        {
            DAL.Clientes.DaoBeneficiarios benf = new DAL.Clientes.DaoBeneficiarios();
            return benf.Pesquisa(IdCliente);
        }


        /// <summary>
        /// Lista os Beneficiarios
        /// </summary>
        public DataTable PesquisaBeneficiario(int IdCliente)
        {
            DAL.Clientes.DaoBeneficiarios benf = new DAL.Clientes.DaoBeneficiarios();
            return benf.PesquisaBeneficiario(IdCliente);
        }


        public void DeletarBeneficiario(int Id)
        {
            DAL.Clientes.DaoBeneficiarios benf = new DAL.Clientes.DaoBeneficiarios();
            benf.Excluir(Id);
        }

    }
}
