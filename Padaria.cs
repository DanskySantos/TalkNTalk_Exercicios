using System;

namespace app_padaria
{
    public class Padaria
    {
        public Padaria()
        {
        }

        private string _nome;
        private string _produto;
        private int _quantidade;

        public Padaria(string _nome, string _produto, int _quantidade)
        {
            this._nome = _nome;
            this._produto = _produto;
            this._quantidade = _quantidade;
        }

        public string GetNome
        {
            get { return _nome; }
        }
        public string SetNome
        {
            set { _nome = value; }
        }
        
        public string GetProduto
        {
            get { return _produto; }
        }
        public string SetProduto
        {
            set { _produto = value; }
        }
        
        public int GetQuantidade
        {
            get { return _quantidade -48; }
        }
        public int SetQuantidade
        {
            set { _quantidade = value; }
        }
    }
}