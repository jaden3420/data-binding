using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace FlagData
{
    /// <summary>
    /// This model object represents a single flag
    /// </summary>
    public class Flag : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private DateTime _dateAdopted;
        /// <summary>
        /// Name of the country that this flag belongs to
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Image URL for the flag (from resources)
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// The date this flag was adopted
        /// </summary>
        ///
        public DateTime DateAdopted
        {
            get { return _dateAdopted; }
            set
            {
                if (_dateAdopted != value)
                {
                    _dateAdopted = value;
                    // Can pass the property name as a string,
                    // -or- let the compiler do it because of the
                    // CallerMemberNameAttribute on the RaisePropertyChanged method.
                    RaisePropertyChanged();
                }
            }
        }
        // public DateTime DateAdopted { get; set; }
        /// <summary>
        /// Whether the flag includes an image/shield as part of the design
        /// </summary>
        public bool IncludesShield { get; set; }
        /// <summary>
        /// Some trivia or commentary about the flag
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// A URL for more information
        /// </summary>
        public Uri MoreInformationUrl { get; set; }
    }
}