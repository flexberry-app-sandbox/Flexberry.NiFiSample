﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    /// Car.
    /// </summary>
    // *** Start programmer edit section *** (Car CustomAttributes)

    // *** End programmer edit section *** (Car CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("CarE", new string[] {
            "CarNumber as \'Car number\'",
            "CarBody as \'Car body\'",
            "CarDate as \'Car date\'",
            "Brand as \'Brand\'",
            "Brand.Name as \'Name\'"}, Hidden=new string[] {
            "Brand.Name"})]
    [AssociatedDetailViewAttribute("CarE", "SparePart", "SparePartE", true, "", "Spare part", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("CarE", "Brand", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("CarL", new string[] {
            "CarNumber as \'Car number\'",
            "CarBody as \'Car body\'",
            "CarDate as \'Car date\'",
            "Brand.Name as \'Name\'"})]
    public class Car : ICSSoft.STORMNET.DataObject
    {
        
        private string fCarNumber;
        
        private IIS.NiFiSample.CarType fCarBody;
        
        private System.DateTime fCarDate = System.DateTime.Parse("DateTime.Now");
        
        private IIS.NiFiSample.Brand fBrand;
        
        private IIS.NiFiSample.DetailArrayOfSparePart fSparePart;
        
        // *** Start programmer edit section *** (Car CustomMembers)

        // *** End programmer edit section *** (Car CustomMembers)

        
        /// <summary>
        /// CarBody.
        /// </summary>
        // *** Start programmer edit section *** (Car.CarBody CustomAttributes)

        // *** End programmer edit section *** (Car.CarBody CustomAttributes)
        public virtual IIS.NiFiSample.CarType CarBody
        {
            get
            {
                // *** Start programmer edit section *** (Car.CarBody Get start)

                // *** End programmer edit section *** (Car.CarBody Get start)
                IIS.NiFiSample.CarType result = this.fCarBody;
                // *** Start programmer edit section *** (Car.CarBody Get end)

                // *** End programmer edit section *** (Car.CarBody Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Car.CarBody Set start)

                // *** End programmer edit section *** (Car.CarBody Set start)
                this.fCarBody = value;
                // *** Start programmer edit section *** (Car.CarBody Set end)

                // *** End programmer edit section *** (Car.CarBody Set end)
            }
        }
        
        /// <summary>
        /// CarDate.
        /// </summary>
        // *** Start programmer edit section *** (Car.CarDate CustomAttributes)

        // *** End programmer edit section *** (Car.CarDate CustomAttributes)
        [NotNull()]
        public virtual System.DateTime CarDate
        {
            get
            {
                // *** Start programmer edit section *** (Car.CarDate Get start)

                // *** End programmer edit section *** (Car.CarDate Get start)
                System.DateTime result = this.fCarDate;
                // *** Start programmer edit section *** (Car.CarDate Get end)

                // *** End programmer edit section *** (Car.CarDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Car.CarDate Set start)

                // *** End programmer edit section *** (Car.CarDate Set start)
                this.fCarDate = value;
                // *** Start programmer edit section *** (Car.CarDate Set end)

                // *** End programmer edit section *** (Car.CarDate Set end)
            }
        }
        
        /// <summary>
        /// CarNumber.
        /// </summary>
        // *** Start programmer edit section *** (Car.CarNumber CustomAttributes)

        // *** End programmer edit section *** (Car.CarNumber CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string CarNumber
        {
            get
            {
                // *** Start programmer edit section *** (Car.CarNumber Get start)

                // *** End programmer edit section *** (Car.CarNumber Get start)
                string result = this.fCarNumber;
                // *** Start programmer edit section *** (Car.CarNumber Get end)

                // *** End programmer edit section *** (Car.CarNumber Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Car.CarNumber Set start)

                // *** End programmer edit section *** (Car.CarNumber Set start)
                this.fCarNumber = value;
                // *** Start programmer edit section *** (Car.CarNumber Set end)

                // *** End programmer edit section *** (Car.CarNumber Set end)
            }
        }
        
        /// <summary>
        /// Car.
        /// </summary>
        // *** Start programmer edit section *** (Car.Brand CustomAttributes)

        // *** End programmer edit section *** (Car.Brand CustomAttributes)
        [NotNull()]
        public virtual IIS.NiFiSample.Brand Brand
        {
            get
            {
                // *** Start programmer edit section *** (Car.Brand Get start)

                // *** End programmer edit section *** (Car.Brand Get start)
                IIS.NiFiSample.Brand result = this.fBrand;
                // *** Start programmer edit section *** (Car.Brand Get end)

                // *** End programmer edit section *** (Car.Brand Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Car.Brand Set start)

                // *** End programmer edit section *** (Car.Brand Set start)
                this.fBrand = value;
                // *** Start programmer edit section *** (Car.Brand Set end)

                // *** End programmer edit section *** (Car.Brand Set end)
            }
        }
        
        /// <summary>
        /// Car.
        /// </summary>
        // *** Start programmer edit section *** (Car.SparePart CustomAttributes)

        // *** End programmer edit section *** (Car.SparePart CustomAttributes)
        public virtual IIS.NiFiSample.DetailArrayOfSparePart SparePart
        {
            get
            {
                // *** Start programmer edit section *** (Car.SparePart Get start)

                // *** End programmer edit section *** (Car.SparePart Get start)
                if ((this.fSparePart == null))
                {
                    this.fSparePart = new IIS.NiFiSample.DetailArrayOfSparePart(this);
                }
                IIS.NiFiSample.DetailArrayOfSparePart result = this.fSparePart;
                // *** Start programmer edit section *** (Car.SparePart Get end)

                // *** End programmer edit section *** (Car.SparePart Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Car.SparePart Set start)

                // *** End programmer edit section *** (Car.SparePart Set start)
                this.fSparePart = value;
                // *** Start programmer edit section *** (Car.SparePart Set end)

                // *** End programmer edit section *** (Car.SparePart Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "CarE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CarE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CarE", typeof(IIS.NiFiSample.Car));
                }
            }
            
            /// <summary>
            /// "CarL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CarL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CarL", typeof(IIS.NiFiSample.Car));
                }
            }
        }
    }
}
