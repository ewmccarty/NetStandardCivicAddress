namespace NetStandardCivicAddress
{
    internal interface ICivicAddress
    {
        /// <summary>
        ///     Gets or sets the first line of the address.
        /// </summary>
        System.String AddressLine1 { get; }

        /// <summary>
        ///     Gets or sets the second line of the address.
        /// </summary>
        System.String AddressLine2 { get; }

        /// <summary>
        ///     Gets or sets the building name or number.
        /// </summary>
        System.String Building { get; }

        /// <summary>
        ///     Gets or sets the name of the city.
        /// </summary>
        System.String City { get; }

        /// <summary>
        ///     Gets or sets the country or region of the location.
        /// </summary>
        System.String CountryRegion { get; }

        /// <summary>
        ///     Gets or sets the floor level of the location.
        /// </summary>
        System.String FloorLevel { get; }

        /// <summary>
        ///     Gets a value that indicates whether the CivicAddress contains data.
        /// </summary>
        System.String IsUnknown { get; }

        /// <summary>
        ///     Gets or sets the postal code of the location.
        /// </summary>
        System.String PostalCode { get; }

        /// <summary>
        ///     Gets or sets the state or province of the location.
        /// </summary>
        System.String StateProvince { get; }
    }
}