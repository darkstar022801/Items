using System;
using Items.Data.Entities;

namespace Items.Common.DTOs
{
    public class AddressDTO
    {
        public Guid Id { get; set; }
        public string Country { get; set; } //Country Name
        public string AdministrativeArea { get; set; } // State / Province / Region
        public string SubAdministrativeArea { get; set; } // County / District
        public string Locality { get; set; } //City / Town
        public int PostalCode { get; set; } //Postal code / ZIP Code
        public string StreetAddress { get; set; }
        public string Premise { get; set; } //Apartment, Suite, Box number, etc.
        public string LandMark { get; set; } //Nearby Landmark
        public int AddressType { get; set; } //Store or other Address

        public static AddressDTO From(Address address)
        {
            if (address == null)
                return new AddressDTO();

            return new AddressDTO
            {
                Id = address.Id,
                Country = address.Country,
                AdministrativeArea = address.AdministrativeArea,
                SubAdministrativeArea = address.SubAdministrativeArea,
                Locality = address.Locality,
                PostalCode = address.PostalCode,
                StreetAddress = address.StreetAddress,
                Premise = address.Premise,
                LandMark = address.LandMark,
                AddressType = address.AddressType
            };
        }
    }
}
