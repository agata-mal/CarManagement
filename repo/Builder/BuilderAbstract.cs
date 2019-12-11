namespace repo.Builder
{
    public abstract class BuilderAbstract<T> where T : class
    {
        protected T Prototype { get; set; }

        public T GetProduct()
        {
            return Prototype;
        }
    }
}