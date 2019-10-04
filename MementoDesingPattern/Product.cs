namespace DesingPatternOrnekleri
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Memento MementoSave()
        {
            MementoCareTake m = new MementoCareTake();
            m._MementoCareTake.Name = this.Name;
            m._MementoCareTake.Price = this.Price;
            return m._MementoCareTake;
        }

        public Product Undo(Memento m)
        {
            return new Product() { Name = m.Name, Price = m.Price };
        }
    }
    
    class Memento
    {

        public string Name { get; set; }
        public double Price { get; set; }
    }

    class MementoCareTake
    {
        private Memento _Memento = new Memento();

        public Memento _MementoCareTake
        {
            get { return _Memento; }
            set { _Memento = value; }
        }

    }
}
