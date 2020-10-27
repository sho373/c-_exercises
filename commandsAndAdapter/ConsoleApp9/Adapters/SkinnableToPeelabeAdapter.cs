namespace ConsoleApp9.Adapters
{
    internal class SkinnableToPeelabeAdapter : IPeelable
    {
        private ISkinnable Skinnable;

        public SkinnableToPeelabeAdapter(ISkinnable skinnable)
        {
            this.Skinnable = skinnable;
        }

        public void Peel()
        {
            Skinnable.Skin();
        }
    }
}