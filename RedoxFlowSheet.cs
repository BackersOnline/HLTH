using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKTH
{

    public class Source
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class Destination
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class Message
    {
        public int ID { get; set; }
    }

    public class Transmission
    {
        public int ID { get; set; }
    }

    public class Meta
    {
        public string DataModel { get; set; }
        public string EventType { get; set; }
        public DateTime EventDateTime { get; set; }
        public bool Test { get; set; }
        public Source Source { get; set; }
        public List<Destination> Destinations { get; set; }
        public Message Message { get; set; }
        public Transmission Transmission { get; set; }
        public object FacilityCode { get; set; }
    }

    public class Identifier
    {
        public string ID { get; set; }
        public string IDType { get; set; }
    }

    public class PhoneNumber
    {
        public string Home { get; set; }
        public object Office { get; set; }
        public object Mobile { get; set; }
    }

    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }

    public class Demographics
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string SSN { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public object IsHispanic { get; set; }
        public string MaritalStatus { get; set; }
        public object IsDeceased { get; set; }
        public object DeathDateTime { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public List<object> EmailAddresses { get; set; }
        public string Language { get; set; }
        public List<object> Citizenship { get; set; }
        public Address Address { get; set; }
    }

    public class Patient
    {
        public List<Identifier> Identifiers { get; set; }
        public Demographics Demographics { get; set; }
    }

    public class Observer
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ReferenceRange
    {
        public object Low { get; set; }
        public object High { get; set; }
        public object Text { get; set; }
    }

    public class Observation
    {
        public DateTime DateTime { get; set; }
        public string Value { get; set; }
        public string ValueType { get; set; }
        public string Units { get; set; }
        public string Code { get; set; }
        public string Codeset { get; set; }
        public object Status { get; set; }
        public List<object> Notes { get; set; }
        public Observer Observer { get; set; }
        public ReferenceRange ReferenceRange { get; set; }
        public object AbnormalFlag { get; set; }
    }

    public class RedoxFlowSheetRootObject
    {
        public Meta Meta { get; set; }
        public Patient Patient { get; set; }
        public List<Observation> Observations { get; set; }
    }
}
