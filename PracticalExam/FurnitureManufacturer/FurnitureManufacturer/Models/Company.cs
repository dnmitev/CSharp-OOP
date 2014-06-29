namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Company : FurnitureManufacturer.Interfaces.ICompany
    {
        private const int MimimalCompanyNameLength = 5;

        private string name;
        private string registrationNumber;

        public Company(string companyName, string regNum)
        {
            this.Name = companyName;
            this.RegistrationNumber = regNum;
            this.Furnitures = new List<Interfaces.IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company's name cannot be null or empty.");
                }
                else if (value.Length < MimimalCompanyNameLength)
                {
                    throw new ArgumentOutOfRangeException("Company's name must be longer than 5 symbols.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Registration number's length must be exactly 10 digits.");
                }
                else
                {
                    foreach (var ch in value)
                    {
                        if (!char.IsDigit(ch))
                        {
                            throw new ArgumentException("Registration number must contain only digits.");
                        }
                    }

                    this.registrationNumber = value;
                }
            }
        }

        public ICollection<Interfaces.IFurniture> Furnitures { get; private set; }

        public void Add(Interfaces.IFurniture furniture)
        {
            if (furniture != null)
            {
                this.Furnitures.Add(furniture);
            }
        }

        public void Remove(Interfaces.IFurniture furniture)
        {
            if (furniture != null)
            {
                this.Furnitures.Remove(furniture);
            }
        }

        public Interfaces.IFurniture Find(string model)
        {
            Interfaces.IFurniture found = this.Furnitures
                                              .FirstOrDefault((furniture) => furniture.Model.ToLower() == model.ToLower());

            return found;
        }

        public string Catalog()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            if (this.Furnitures.Count >= 1)
            {
                var sortedFurnitures = this.Furnitures
                                           .OrderBy((f) => f.Price)
                                           .ThenBy((m) => m.Model);

                foreach (var furniture in sortedFurnitures)
                {
                    result.AppendLine(furniture.ToString());
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}