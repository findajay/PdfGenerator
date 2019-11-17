using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanhackPdfGenerator.DataModeling;

namespace VanhackPdfGenerator.DataProcessor
{
    public static class DataFieldProcessor
    {
        /// <summary>
        /// Process pdf source document and generate destination document 
        /// </summary>
        /// <param name="SRC"></param>
        /// <param name="DES"></param>
        /// <returns></returns>
        public static bool ProcessPdfFormFields(string SRC, string DES)
        {
            PdfReader reader = new PdfReader(SRC);
            reader.SetUnethicalReading(true);
            PdfWriter writer = new PdfWriter(DES, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(reader, writer);

            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDocument, true);
            IDictionary<String, PdfFormField> fields = form.GetFormFields();

            var UserImmigrationData = GetImmigrationFormData();

            try
            {

                foreach (KeyValuePair<String, PdfFormField> field in fields)
                {
                    if (field.Key.StartsWith("EMP5624_E[0].Page1[0]"))
                    {
                        string keyPrefix = "EMP5624_E[0].Page1[0].";
                        string key = field.Key.Replace(keyPrefix, "");
                        switch (key)
                        {
                            case "Yes_business[0]":
                                field.Value.SetValue(UserImmigrationData.Yes_business);
                                break;
                            case "No_business[0]":
                                field.Value.SetValue(UserImmigrationData.No_business);
                                break;
                            case "Yes_inn[0]":
                                field.Value.SetValue(UserImmigrationData.Yes_inn);
                                break;
                            case "No_inn[0]":
                                field.Value.SetValue(UserImmigrationData.No_inn);
                                break;
                            case "txtF_first_name[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_first_name);
                                break;
                            case "txtF_mid_name[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_mid_name);
                                break;
                            case "txtF_last_name[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_last_name);
                                break;
                            case "txtF_Email[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_Email);
                                break;
                            case "txtF_phone_number[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_phone_number);
                                break;
                            case "txtF_alternate_phone[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_alternate_phone);
                                break;
                            case "txtF_fax_number[0]":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.F_fax_number);
                                break;
                            case "rb_language_oral[0].1":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.language_oral1);
                                break;
                            case "rb_language_oral[0].2":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.language_oral2);
                                break;
                            case "rb_language_written[0].1":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.language_written1);
                                break;
                            case "rb_language_written[0].2":
                                field.Value.SetValue(UserImmigrationData.PrincipalReferalPartner.language_written2);
                                break;
                            case "txtF_first_name2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_first_name);
                                break;
                            case "txtF_mid_name2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_mid_name);
                                break;
                            case "txtF_last_name2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_last_name);
                                break;
                            case "txtF_Email2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_Email);
                                break;
                            case "txtF_phone_number2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_phone_number);
                                break;
                            case "txtF_alternate_phone2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_alternate_phone);
                                break;
                            case "txtF_fax_number2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.F_fax_number);
                                break;
                            case "rb_language_oral2[0].1":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.language_oral1);
                                break;
                            case "rb_language_oral2[0].2":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.language_oral2);
                                break;
                            case "rb_language_written2[0].1":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.language_written1);
                                break;
                            case "rb_language_written2[0].2":
                                field.Value.SetValue(UserImmigrationData.AlternateReferalPartner.language_written2);
                                break;
                        };

                    }
                    //Second page processing
                    else if (field.Key.StartsWith("EMP5624_E[0].Page2"))
                    {
                        string keyPrefix = "EMP5624_E[0].Page2[0].";
                        string key = field.Key.Replace(keyPrefix, "");
                        switch (key)
                        {
                            case "txtF_Emp_Legal[0]":
                                field.Value.SetValue(UserImmigrationData.F_Emp_Legal);
                                break;
                            case "txtF_Mail_Adress1[0]":
                                field.Value.SetValue(UserImmigrationData.Business_Address.F_Mail_Address1);
                                break;
                            case "txtF_Mail_Adress2[0]":
                                field.Value.SetValue(UserImmigrationData.Business_Address.F_Mail_Address2);
                                break;
                            case "txtF_City[0]":
                                field.Value.SetValue(UserImmigrationData.Business_Address.F_City);
                                break;
                            case "txtF_Province[0]":
                                field.Value.SetValue(UserImmigrationData.Business_Address.F_Province);
                                break;
                            case "txtF_Country[0]":
                                field.Value.SetValue(UserImmigrationData.Business_Address.F_Country);
                                break;
                            case "txtF_Postal_Code[0]":
                                field.Value.SetValue(UserImmigrationData.Business_Address.F_Postal_Code);
                                break;
                            case "txtF_Mail_Adress2-1[0]":
                                field.Value.SetValue(UserImmigrationData.Mail_Address.F_Mail_Address1);
                                break;
                            case "txtF_Mail_Adress2-2[0]":
                                field.Value.SetValue(UserImmigrationData.Mail_Address.F_Mail_Address2);
                                break;
                            case "txtF_City2[0]":
                                field.Value.SetValue(UserImmigrationData.Mail_Address.F_City);
                                break;
                            case "txtF_Province2[0]":
                                field.Value.SetValue(UserImmigrationData.Mail_Address.F_Province);
                                break;
                            case "txtF_Country2[0]":
                                field.Value.SetValue(UserImmigrationData.Mail_Address.F_Country);
                                break;
                            case "txtF_Postal_Code2[0]":
                                field.Value.SetValue(UserImmigrationData.Mail_Address.F_Postal_Code);
                                break;
                            case "txtF_Employer_Web_Address[0]":
                                field.Value.SetValue(UserImmigrationData.F_Employer_Web_Address);
                                break;
                            case "txtF_Employer_Date_Business[0]":
                                field.Value.SetValue(UserImmigrationData.F_Employer_Date_Business);
                                break;
                            case "cb_individual[0]":
                                field.Value.SetValue(UserImmigrationData.cb_individual);
                                break;
                            case "cb_partnership[0]":
                                field.Value.SetValue(UserImmigrationData.cb_partnership);
                                break;
                            case "cb_society[0]":
                                field.Value.SetValue(UserImmigrationData.cb_society);
                                break;
                            case "cb_sole_propietor[0]":
                                field.Value.SetValue(UserImmigrationData.cb_sole_propietor);
                                break;
                            case "cb_not_profit[0]":
                                field.Value.SetValue(UserImmigrationData.cb_not_profit);
                                break;
                            case "cb_registred[0]":
                                field.Value.SetValue(UserImmigrationData.cb_registred);
                                break;
                            case "txtF_amout_employees[0]":
                                field.Value.SetValue(UserImmigrationData.F_amout_employees);
                                break;
                            case "txtF_business_revenu[0]":
                                field.Value.SetValue(UserImmigrationData.F_business_revenu);
                                break;
                            case "rb_receive_prog[0].1":
                                field.Value.SetValue(UserImmigrationData.receive_prog1);
                                break;
                            case "rb_receive_prog[0].2":
                                field.Value.SetValue(UserImmigrationData.receive_prog2);
                                break;
                            case "txtF_If_Yes2[0]":
                                field.Value.SetValue(UserImmigrationData.receive_prog_If_Yes2);
                                break;
                            case "txtF_position_title[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_position_title);
                                break;
                            case "txtF_first_name2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_first_name);
                                break;
                            case "txtF_mid_name2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_mid_name);
                                break;
                            case "txtF_last_name2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_last_name);
                                break;
                            case "txtF_Email2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_Email);
                                break;
                            case "txtF_phone_number2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_phone_number);
                                break;
                            case "txtF_alternate_phone2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_alternate_phone);
                                break;
                            case "txtF_fax_number2[0]":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.F_fax_number);
                                break;
                            case "rb_language_oral2[0].1":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.language_oral1);
                                break;
                            case "rb_language_oral2[0].2":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.language_oral2);
                                break;
                            case "rb_language_written2[0].1":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.language_written1);
                                break;
                            case "rb_language_written2[0].2":
                                field.Value.SetValue(UserImmigrationData.EmployerContactInfo.language_written2);
                                break;
                            case "txtF_other_position_title[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_position_title);
                                break;
                            case "txtF_other_first_name2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_first_name);
                                break;
                            case "txtF_other_mid_name2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_mid_name);
                                break;
                            case "txtF_other_last_name2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_last_name);
                                break;
                            case "txtF_other_Email2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_Email);
                                break;
                            case "txtF_other_phone_number2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_phone_number);
                                break;
                            case "txtF_other_alternate_phone2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_alternate_phone);
                                break;
                            case "txtF_other_fax_number2[0]":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.F_fax_number);
                                break;
                            case "rb_other_language_oral2[0].1":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.language_oral1);
                                break;
                            case "rb_other_language_oral2[0].2":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.language_oral2);
                                break;
                            case "rb_other_language_written2[0].1":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.language_written1);
                                break;
                            case "rb_other_language_written2[0].2":
                                field.Value.SetValue(UserImmigrationData.AlternateEmployerContactInfo.language_written2);
                                break;
                        };

                    }
                }

                pdfDocument.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Get data set for pdf 
        /// </summary>
        /// <returns></returns>
        private static ImmigrationFormData GetImmigrationFormData()
        {            
            //Here we can get details of different entities from database and assign appropriate properties to dataset of immigrationFormData
            return new ImmigrationFormData()
            {

                Yes_business = "1",
                No_business = "0",
                Yes_inn = "0",
                No_inn = "1",
                PrincipalReferalPartner = new BasicDetails
                {
                    F_first_name = "Ajay",
                    F_mid_name = "",
                    F_last_name = "Kumar",
                    F_Email = "ajay.kumar@condecosoftware.com",
                    F_phone_number = "98103423",
                    F_alternate_phone = "",
                    F_fax_number = "",
                    language_oral1 = "1",
                    language_oral2 = "1",
                    language_written1 = "1",
                    language_written2 = "1"

                },
                AlternateReferalPartner = new BasicDetails
                {
                    F_first_name = "anamika ",
                    F_mid_name = "",
                    F_last_name = "lastname ",
                    F_Email = "alternate@condeco.com",
                    F_phone_number = "2984294",
                    F_alternate_phone = "",
                    F_fax_number = "214234",
                    language_oral1 = "0",
                    language_oral2 = "0",
                    language_written1 = "1",
                    language_written2 = "1"

                },
                F_Emp_Legal = "Condeco",
                Business_Address = new AddressDetail
                {
                    F_Mail_Address1 = "cyber city",
                    F_Mail_Address2 = "4th floor",
                    F_City = "Gurugram",
                    F_Country = "India",
                    F_Province = "Haryana",
                    F_Postal_Code = "122003"
                },
                Mail_Address = new AddressDetail
                {
                    F_Mail_Address1 = "2332/2",
                    F_Mail_Address2 = "sector 46",
                    F_City = "Gurugram  ",
                    F_Country = "India",
                    F_Province = "Haryana",
                    F_Postal_Code = "122002",
                },
                F_Employer_Web_Address = "www.vanhack.com",
                F_Employer_Date_Business = "Mon-Fri",
                F_des_part = "Vanhack",
                cb_individual = "1",
                cb_partnership = "1",
                cb_not_profit = "1",
                cb_registred = "1",
                cb_society = "1",
                cb_sole_propietor = "1",
                F_amout_employees = "200",
                F_business_revenu = "500 Million",
                receive_prog1 = "0",
                receive_prog2 = "0",
                receive_prog_If_Yes2 = "Extra information",

                EmployerContactInfo = new BasicDetails
                {
                    F_position_title = "Software Engineer",
                    F_first_name = "Ajay    ",
                    F_mid_name = "",
                    F_last_name = "Kumar",
                    F_Email = "ajay.20093@gmail.com",
                    F_phone_number = "9810303943",
                    F_alternate_phone = "",
                    F_fax_number = "324432342",
                    language_oral1 = "1",
                    language_oral2 = "1",
                    language_written1 = "1",
                    language_written2 = "1"
                },
                AlternateEmployerContactInfo = new BasicDetails
                {
                    F_position_title = "Senior Software Engineer",
                    F_first_name = "Ajay1",
                    F_mid_name = "",
                    F_last_name = "Kumar1",
                    F_Email = "findajay@outlook.com",
                    F_phone_number = "9810342312",
                    F_alternate_phone = "1287528643",
                    F_fax_number = "234234",
                    language_oral1 = "0",
                    language_oral2 = "0",
                    language_written1 = "1",
                    language_written2 = "1"
                }
            };
        }



    }
}
