using System.Text.RegularExpressions;
using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {

        public PessoaJuridica(string nome, Endereco endereco, float rendimento) : base(nome, endereco, rendimento)
        {
        }

        public string ?Cnpj { get; set; }

        public string ?RazaoSocial { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        //XX.XXX.XXX/0001-XX - XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^\d{2}.\d{3}.\d{3}/\d{4}-\d{2})||(\d{14})"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring (11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring (8, 4) != "0001");
                }
                return true;
            }
            return false;
        }
    }
}