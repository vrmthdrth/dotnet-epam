namespace CustomerRepresentation
{
    using System;

    /// <summary>
    /// An enumeration defining different Customer class objects string representations.
    /// N is for "Name", R is for "Revenue"(formattion with separators), C is for "ContactPhone", r is for "Revenue"(formattion without separators).
    /// </summary>
    public enum CustomerRepresentation
    {
        /// <summary>
        /// Number, Revenue(with separators) and ContactInfo.
        /// </summary>
        NRC,

        /// <summary>
        /// Number, Revenue(without separators) and ContactInfo.
        /// </summary>
        NrC,

        /// <summary>
        /// Number and ContactInfo.
        /// </summary>
        NC,

        /// <summary>
        /// Number and Revenue(with separators).
        /// </summary>
        NR,

        /// <summary>
        /// Number and Revenue(without separators).
        /// </summary>
        Nr,

        /// <summary>
        /// Number.
        /// </summary>
        N,

        /// <summary>
        /// Revenue(with separators) and ContactInfo.
        /// </summary>
        RC,

        /// <summary>
        /// Revenue(without separators) and ContactInfo.
        /// </summary>
        rC,

        /// <summary>
        /// ContactInfo.
        /// </summary>
        C,

        /// <summary>
        /// Revenue(with separators).
        /// </summary>
        R,

        /// <summary>
        /// Revenue(without separators).
        /// </summary>
        r
    }

    /// <summary>
    /// A class containing properties and methods of customers.
    /// </summary>
    public class Customer
    {

        /// <summary>
        /// Gets or sets the name of customer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the revenue of customer.
        /// </summary>
        public decimal Revenue { get; set; }

        /// <summary>
        /// Gets or sets the contact phone of customer.
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="revenue">Revenue.</param>
        /// <param name="contactPhone">Contact phone.</param>
        public Customer(string name, decimal revenue, string contactPhone)
        {
            this.Name = name;
            this.Revenue = revenue;
            this.ContactPhone = contactPhone;
        }

        /// <summary>
        /// A method to represent Customer object as a string.
        /// </summary>
        /// <param name="format">Concrete customer representation.</param>
        /// <returns>Customer representation.</returns>
        public string ToString(CustomerRepresentation format)
        {
            switch (format)
            {
                case CustomerRepresentation.NRC:
                    return string.Format(FormatHelper.RevenueFormat(), "Customer record: {0}, {1:C}, {2}", this.Name, this.Revenue, this.ContactPhone);
                case CustomerRepresentation.NrC:
                    return string.Format("Customer record: {0}, {1}, {2}", this.Name, this.Revenue, this.ContactPhone);
                case CustomerRepresentation.NC:
                    return string.Format("Customer record: {0}, {1}", this.Name, this.ContactPhone);
                case CustomerRepresentation.NR:
                    return string.Format(FormatHelper.RevenueFormat(), "Customer record: {0}, {1:C}", this.Name, this.Revenue);
                case CustomerRepresentation.Nr:
                    return string.Format("Customer record: {0}, {1}", this.Name, this.Revenue);
                case CustomerRepresentation.N:
                    return string.Format("Customer record: {0}", this.Name);
                case CustomerRepresentation.RC:
                    return string.Format(FormatHelper.RevenueFormat(), "Customer record: {0:C}, {1}", this.Revenue, this.ContactPhone);
                case CustomerRepresentation.rC:
                    return string.Format("Customer record: {0}, {1}", this.Revenue, this.ContactPhone);
                case CustomerRepresentation.C:
                    return string.Format("Customer record: {0}", this.ContactPhone);
                case CustomerRepresentation.R:
                    return string.Format(FormatHelper.RevenueFormat(), "Customer record: {0:C}", this.Revenue);
                case CustomerRepresentation.r:
                    return string.Format("Customer record: {0}", this.Revenue);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
