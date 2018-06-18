// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable MemberCanBePrivate.Global

namespace NetStandardCivicAddress
{
    public sealed class CivicAddress : ICivicAddress, System.IEquatable<CivicAddress>
    {
        #region Public Fields

        /// <summary>
        ///     Represents a CivicAddress that contains no data.
        /// </summary>
        public static readonly CivicAddress Unknown;

        #endregion Public Fields

        #region Public Properties

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the first line of the address.
        /// </summary>
        public System.String AddressLine1 { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the second line of the address.
        /// </summary>
        public System.String AddressLine2 { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the building name or number.
        /// </summary>
        public System.String Building { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the name of the city.
        /// </summary>
        public System.String City { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the country or region of the location.
        /// </summary>
        public System.String CountryRegion { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the floor level of the location.
        /// </summary>
        public System.String FloorLevel { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets a value that indicates whether the CivicAddress contains data.
        /// </summary>
        public System.String IsUnknown { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the postal code of the location.
        /// </summary>
        public System.String PostalCode { get; [JetBrains.Annotations.UsedImplicitly] set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets or sets the state or province of the location.
        /// </summary>
        public System.String StateProvince { get; [JetBrains.Annotations.UsedImplicitly] set; }

        #endregion Public Properties

        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the CivicAddress class.
        /// </summary>
        public CivicAddress()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the CivicAddress class using address information.
        /// </summary>
        /// <param name="addressLine1"></param>
        /// <param name="addressLine2"></param>
        /// <param name="building"></param>
        /// <param name="city"></param>
        /// <param name="countryRegion"></param>
        /// <param name="floorLevel"></param>
        /// <param name="postalCode"></param>
        /// <param name="stateProvince"></param>
        public CivicAddress(System.String addressLine1, System.String addressLine2, System.String building,
            System.String city, System.String countryRegion, System.String floorLevel, System.String postalCode,
            System.String stateProvince)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.Building = building;
            this.City = city;
            this.CountryRegion = countryRegion;
            this.FloorLevel = floorLevel;
            this.PostalCode = postalCode;
            this.StateProvince = stateProvince;
        }

        #endregion Public Constructors

        #region Public Methods

        public static System.Boolean operator !=([JetBrains.Annotations.CanBeNull] CivicAddress left,
            [JetBrains.Annotations.CanBeNull] CivicAddress right) =>
            !System.Object.Equals(left, right);

        public static System.Boolean operator ==([JetBrains.Annotations.CanBeNull] CivicAddress left,
            [JetBrains.Annotations.CanBeNull] CivicAddress right) =>
            System.Object.Equals(left, right);

        /// <inheritdoc />
        public override System.Boolean Equals([JetBrains.Annotations.CanBeNull] System.Object obj)
        {
            //Check for null and compare run-time types.
            if (obj == null || !(this.GetType() == obj.GetType()))
            {
                return false;
            }

            var other = (CivicAddress) obj;
            System.Boolean hr = this.AddressLine1 == other.AddressLine1 && this.AddressLine2 == other.AddressLine2 &&
                this.Building == other.Building && this.City == other.City &&
                this.CountryRegion == other.CountryRegion && this.FloorLevel == other.FloorLevel &&
                this.PostalCode == other.PostalCode && this.StateProvince == other.StateProvince;
            return hr;
        }

        /// <inheritdoc />
        public System.Boolean Equals([JetBrains.Annotations.CanBeNull] CivicAddress other)
        {
            if (other is null)
            {
                return false;
            }

            if (System.Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return System.String.Equals(this.AddressLine1, other.AddressLine1) &&
                System.String.Equals(this.AddressLine2, other.AddressLine2) &&
                System.String.Equals(this.Building, other.Building) && System.String.Equals(this.City, other.City) &&
                System.String.Equals(this.CountryRegion, other.CountryRegion) &&
                System.String.Equals(this.FloorLevel, other.FloorLevel) &&
                System.String.Equals(this.IsUnknown, other.IsUnknown) &&
                System.String.Equals(this.PostalCode, other.PostalCode) &&
                System.String.Equals(this.StateProvince, other.StateProvince);
        }

        /// <inheritdoc />
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override System.Int32 GetHashCode()
        {
            unchecked
            {
                System.Int32 hashCode = this.AddressLine1 != null ? this.AddressLine1.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (this.AddressLine2 != null ? this.AddressLine2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Building != null ? this.Building.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.City != null ? this.City.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.CountryRegion != null ? this.CountryRegion.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.FloorLevel != null ? this.FloorLevel.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.IsUnknown != null ? this.IsUnknown.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.PostalCode != null ? this.PostalCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.StateProvince != null ? this.StateProvince.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary>
        ///     A string that represents the current object.
        /// </summary>
        /// <returns></returns>
        [JetBrains.Annotations.CanBeNull]
        public override System.String ToString()
        {
            System.String address = System.String.Empty;
            if (this.AddressLine1 != null)
            {
                address += $"{this.AddressLine1}\r\n";
            }

            if (this.AddressLine2 != null)
            {
                address += $"{this.AddressLine2}\r\n";
            }

            if (this.Building != null)
            {
                address += $"Building {this.Building}";
            }

            if (this.Building != null && this.FloorLevel != null)
            {
                address += ", ";
            }

            if (this.FloorLevel != null)
            {
                address += $"Floor {this.FloorLevel}";
            }

            if (this.Building != null || this.FloorLevel != null)
            {
                address += "\r\n";
            }

            if (this.City != null)
            {
                address += $"{this.City}";
            }

            if (this.City != null && (this.StateProvince != null || this.PostalCode != null))
            {
                address += ", ";
            }

            if (this.StateProvince != null)
            {
                address += $"{this.StateProvince}";
            }

            if (this.PostalCode != null)
            {
                address += $"{this.PostalCode}";
            }

            if (this.City != null || this.StateProvince != null || this.PostalCode != null)
            {
                address += "\r\n";
            }

            if (this.CountryRegion != null)
            {
                address += $"{this.CountryRegion}\r\n";
            }

            return address;
        }

        #endregion Public Methods
    }
}