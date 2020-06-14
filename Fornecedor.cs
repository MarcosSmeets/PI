using System;

namespace PI
{
    class Fornecedor : Hospital
    {
        public void showFornecedor()
        {
            Console.WriteLine("Nome: " + getNome() + "CNPJ: " + getCnpj() + "Endereço: " + getEnd());
        }
    }
}