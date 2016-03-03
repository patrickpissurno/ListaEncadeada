using System.Collections.Generic;

namespace _2015_3003_1BIM_ListaEncadeada
{
    class Lista
    {
        private Elemento primeiro;
        public Elemento Primeiro
        {
            get
            {
                return primeiro;
            }
            set
            {
                primeiro = value;
            }
        }

        public Elemento Ultimo
        {
            get
            {
                return BuscaUltimo();
            }
        }

        public Lista()
        {
            
        }

        public void Adiciona(Elemento e)
        {
            if (Primeiro == null)
            {
                Primeiro = e;
            }
            else
            {
                Ultimo.Proximo = e;
            }
        }

        public void Adiciona(Elemento e, int pos)
        {
            if (pos >= Count)
                Adiciona(e);
            else
            {
                if (pos == 0)
                {
                    e.Proximo = Primeiro;
                    Primeiro = e;
                }
                else
                {
                    Elemento el = Primeiro;
                    int p = 0;
                    while (el != null)
                    {
                        Elemento _e = el.Proximo;
                        if (p + 1 == pos)
                        {
                            el.Proximo = e;
                            e.Proximo = _e;
                            break;
                        }
                        p++;
                        el = el.Proximo;
                    }
                }
            }
        }

        public void AdicionarApos(Elemento e, int v)
        {
            Elemento el = Primeiro;
            while (el != null)
            {
                Elemento _e = el.Proximo;
                if (el.Valor == v)
                {
                    el.Proximo = e;
                    e.Proximo = _e;
                    break;
                }
                el = el.Proximo;
            }
        }

        public Elemento BuscaUltimo()
        {
            Elemento current = Primeiro;
            while (current.Proximo != null)
            {
                current = current.Proximo;
            }
            return current;
        }

        public int Count
        {
            get {
                int count = 1;
                Elemento current = Primeiro;
                while (current != null)
                {
                    current = current.Proximo;
                    count++;
                }
                return count;
            }
        }

        public Elemento[] ToArray()
        {
            List<Elemento> list = new List<Elemento>();
            Elemento current = Primeiro;
            while (current != null)
            {
                list.Add(current);
                current = current.Proximo;
            }
            return list.ToArray();
        }

        public Elemento GetByPosition(int pos)
        {
            int count = 0;
            Elemento current = Primeiro;
            while (current != null)
            {
                if (count == pos)
                    return current;
                current = current.Proximo;
                count++;
            }
            return null;
        }

        public void SwapByPosition(int pos1, int pos2)
        {
            if (pos1 != pos2)
            {
                Elemento e1 = GetByPosition(pos1);
                Elemento e2 = GetByPosition(pos2);
                if (e1 != null && e2 != null)
                {
                    Elemento el = Primeiro;
                    Elemento _e = null;
                    while (el != null)
                    {
                        _e = el.Proximo;
                        if (el.Proximo == e1)
                            el.Proximo = e2;
                        else if (el.Proximo == e2)
                            el.Proximo = e1;
                        el = _e;
                    }
                    if (pos1 == 0)
                        Primeiro = e2;
                    else if (pos2 == 0)
                        Primeiro = e2;
                    _e = e1.Proximo;
                    e1.Proximo = e2.Proximo;
                    e2.Proximo = _e;
                }
            }
        }

        public void RemoveAtPos(int pos)
        {
            if (pos < 0)
                return;
            if (pos == 0)
                Primeiro = Primeiro.Proximo;
            else
            {
                Elemento el = Primeiro;
                int p = 0;
                while (el != null)
                {
                    if (p + 1 == pos)
                    {
                        if (el.Proximo != null)
                        {
                            el.Proximo = el.Proximo.Proximo;
                            break;
                        }
                    }
                    p++;
                    el = el.Proximo;
                }
            }
        }

        public void RemoveByValue(int v)
        {
            if (v == Primeiro.Valor)
                Primeiro = Primeiro.Proximo;
            else
            {
                Elemento el = Primeiro;
                while (el != null)
                {
                    if (el.Proximo != null && el.Proximo.Valor == v)
                    {
                        el.Proximo = el.Proximo.Proximo;
                        break;
                    }
                    el = el.Proximo;
                }
            }
        }
    }
}
