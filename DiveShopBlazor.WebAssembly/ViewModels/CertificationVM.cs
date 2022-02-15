//
// Copyright (c) 2022 David Robinson  All Rights Reserved
//

using System.ComponentModel.DataAnnotations;

namespace DiveShop.ViewModels
{
    /// <summary>
    /// A certification that a diver may hold
    /// </summary>
    public class CertificationVM
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public CertificationVM() { }

        /// <summary>
        /// The database ID and Primary Key
        /// </summary>
        [MaxLength(8)]
        public string CertificationID { get; init; } = null!;

        /// <summary>
        /// The agency
        /// </summary>
        [MaxLength(20)]
        public string Agency { get; init; } = null!;

        /// <summary>
        /// The Certification name.
        /// </summary>
        [MaxLength(127)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Returns a string that represents a Certification
        /// </summary>
        /// <returns>A string that represents the Certification</returns>
        public override string ToString() => $"{CertificationID} {Agency} {Name}";
    }
}
