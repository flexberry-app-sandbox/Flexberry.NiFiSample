﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.NiFiSample
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Producing country.
    /// </summary>
    // *** Start programmer edit section *** (ProducingCountry CustomAttributes)

    // *** End programmer edit section *** (ProducingCountry CustomAttributes)
    [AutoAltered()]
    [Caption("Producing country")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ProducingCountryE", new string[] {
            "Name as \'Name\'"})]
    [View("ProducingCountryL", new string[] {
            "Name as \'Name\'"})]
    public class ProducingCountry : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        // *** Start programmer edit section *** (ProducingCountry CustomMembers)

        // *** End programmer edit section *** (ProducingCountry CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (ProducingCountry.Name CustomAttributes)

        // *** End programmer edit section *** (ProducingCountry.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (ProducingCountry.Name Get start)

                // *** End programmer edit section *** (ProducingCountry.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (ProducingCountry.Name Get end)

                // *** End programmer edit section *** (ProducingCountry.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProducingCountry.Name Set start)

                // *** End programmer edit section *** (ProducingCountry.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (ProducingCountry.Name Set end)

                // *** End programmer edit section *** (ProducingCountry.Name Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ProducingCountryE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ProducingCountryE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ProducingCountryE", typeof(IIS.NiFiSample.ProducingCountry));
                }
            }
            
            /// <summary>
            /// "ProducingCountryL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ProducingCountryL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ProducingCountryL", typeof(IIS.NiFiSample.ProducingCountry));
                }
            }
        }
    }
}
