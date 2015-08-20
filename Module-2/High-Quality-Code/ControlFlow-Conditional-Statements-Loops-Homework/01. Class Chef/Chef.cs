namespace _01.Class_Chef
{
    using System;
    using Dishes;
    using Products;

    public class Chef
    {
        public void Cook()
        {
           Bowl bowl = this.GetBowl();
           Potato potato = this.GetPotato();
           Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Cut(potato);

            this.Peel(carrot);
            this.Cut(carrot);

            bowl.Add(potato);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException("TODO");
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException("TODO");
        }

        private void Cut(Vegetable potato)
        {
            ///...
        }

        private void Peel(Vegetable vegetable)
        {
            ///...
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException("TODO");
        }
    }
}
