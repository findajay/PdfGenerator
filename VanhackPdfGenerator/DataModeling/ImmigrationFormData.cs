using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhackPdfGenerator.DataModeling
{
    /// <summary>
    /// Collaborative immigration form data extracted from datasets 
    /// </summary>
    public class ImmigrationFormData
    {
        public string Yes_business { get; set; }
        public string No_business { get; set; }
        public string Yes_inn { get; set; }
        public string No_inn { get; set; }
        public string F_des_part { get; set; }
        public BasicDetails PrincipalReferalPartner { get; set; }
        public BasicDetails AlternateReferalPartner { get; set; }       
        public string F_Emp_Legal { get; set; }
        public AddressDetail Business_Address { get; set; }
        public AddressDetail Mail_Address { get; set; }        
        public string F_Employer_Web_Address { get; set; }
        public string F_Employer_Date_Business { get; set; }
        public string cb_individual { get;set; }
        public string cb_partnership { get; set; }
        public string cb_society { get; set; }
        public string cb_sole_propietor { get; set; }
        public string cb_not_profit { get; set; }
        public string cb_registred { get; set; }
        public string F_amout_employees { get; set; }
        public string F_business_revenu { get; set; }       
        public string receive_prog1 { get; set; }
        public string receive_prog2 { get; set; }
        public string receive_prog_If_Yes2 { get; set; }        
        public BasicDetails EmployerContactInfo { get; set; }
        public BasicDetails AlternateEmployerContactInfo { get; set; }
    }
    public class BasicDetails
    {
        public string F_position_title { get; set; }
        public string F_first_name { get; set; }
        public string F_mid_name { get; set; }
        public string F_last_name { get; set; }
        public string F_phone_number { get; set; }
        public string F_alternate_phone { get; set; }
        public string F_fax_number { get; set; }
        public string F_Email { get; set; }
        public string language_oral1 { get; set; }
        public string language_oral2 { get; set; }
        public string language_written1 { get; set; }
        public string language_written2 { get; set; }
    }

    public class AddressDetail
    {
        public string F_Mail_Address1 { get; set; }
        public string F_Mail_Address2 { get; set; }
        public string F_City { get; set; }
        public string F_Province { get; set; }
        public string F_Country { get; set; }
        public string F_Postal_Code { get; set; }
    }
}
