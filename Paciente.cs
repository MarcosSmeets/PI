using System;

namespace PI
{
    class Paciente
    {
        private string nome;
        private string end;
        private string cpf;
        private DateTime data;

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

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public void showPaciente()
        {
            Console.WriteLine("Nome: " + getNome() + "CPF: " + getCpf() + "Endereço: " + getEnd() + "Nasc: " + getData());
        }
    }
}