using Cadastro_Pessoa_FS1.Classes;

// PessoaFisica metodoPf = new PessoaFisica();

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEnd = new Endereco();

// novaPf.ValidarDataNasc(new DateTime(2000,01,01));


// novaPf.nome = "Odirlei";
// novaPf.dataNascimento = "01/01/2000";
// novaPf.cpf = "1234567890";
// novaPf.rendimento = 15000.5f;

// novoEnd.logradouro = "Alameda Barão de Limeira";
// novoEnd.numero = 539;
// novoEnd.complemento = "SENAI Informática";
// novoEnd.endComercial = true;

// novaPf.endereco = novoEnd;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {metodoPf.ValidaDataNascimento(novaPf.dataNascimento)}
// ");

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novoPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novoPj.nome = "Nome Pj";
novoPj.Cnpj = "00.000.000/0001.00";
novoPj.RazaoSocial = "Razão Social Pj";
novoPj.rendimento = 8000.5f; 

novoEndPj.logradouro = "Alameda Barão de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "SENAI Informática";
novoEndPj.endComercial = true;

novoPj.endereco = novoEndPj;

Console.WriteLine($"
Nome: {novoPj.nome}
Razão Social: {novoPj.RazaoSocial} 
CNPJ: {novoPj.Cnpj}
CNPJ Válido {metodoPj.ValidarCnpj(novaPj.cnpj)"});