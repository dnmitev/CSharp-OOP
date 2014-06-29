namespace FurnitureManufacturer.Models
{
    public class AdjustableChair : Chair, FurnitureManufacturer.Interfaces.IAdjustableChair
    {
        public AdjustableChair(string adjustableChairModel, string adjustableChairMaterial, decimal adjustableChairPrice, decimal adjustableChairHeight, int adjustableChairLegsCount)
            : base(adjustableChairModel, adjustableChairMaterial, adjustableChairPrice, adjustableChairHeight, adjustableChairLegsCount)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}