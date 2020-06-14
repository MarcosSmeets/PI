using System;

namespace PI
{
    class Hospital
    {
        private string nome;
        private string end;
        private string cnpj;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setEnd(string end)
        {
            this.end = end;
        }

        public string getEnd()
        {
            return this.end;
        }

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string getCnpj()
        {
            return this.cnpj;
        }

        public void showHosp()
        {
            Console.WriteLine("Nome: " + getNome() + "CNPJ: " + getCnpj() + "Endereço: " + getEnd());
        }
    }
}