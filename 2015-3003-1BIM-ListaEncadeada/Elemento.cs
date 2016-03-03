namespace _2015_3003_1BIM_ListaEncadeada
{
    class Elemento
    {
        #region Propriedades
        private int valor;
        private Elemento proximo;
        private Elemento anterior;
        #endregion

        #region Construtores
        public Elemento(int v)
        {
            Valor = v;
            Proximo = null;
            Anterior = null;
        }

        public Elemento(int v, Elemento p = null)
        {
            Valor = v;
            Proximo = p;
            Anterior = null;
        }

        public Elemento(int v, Elemento p = null, Elemento a = null) 
        {
            Valor = v;
            Proximo = p;
            Anterior = a;
        }
        #endregion

        #region Get/Set
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public Elemento Proximo
        {
            get
            {
                return proximo;
            }
            set
            {
                proximo = value;
            }
        }

        public Elemento Anterior
        {
            get
            {
                return anterior;
            }
            set
            {
                anterior = value;
            }
        }
        #endregion

        #region Utilitários
        public override string ToString()
        {
            return "Valor: " + valor.ToString();
        }
        #endregion
    }

}
