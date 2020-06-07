using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagement.Entities;
using ClinicManagement.Data;
using System.Windows.Forms;

namespace ClinicManagement.Repository
{
  public  class PatientRepo
    {
        public void AddtempReqAppoDocInfromation(Patient pa, Doctor dr, Clinic cl)
        {
            try
            {
                string sql = @"insert into tempReqAppoDoc (patientid,patientname,patientgender,patientemail,dateOfBirth,doctorid,date,time,clinicname,clinicid,divission,district,thana) values ('" + pa.Userid + "','" + pa.Username + "','" + pa.Gender + "','" + pa.Email + "','" + pa.DateOfBirth + "','" + dr.Userid + "','" + dr.Date + "','" + dr.Time + "','" + cl.Username + "','" + cl.Userid + "','" + cl.Divission + "','" + cl.District + "','" + cl.Thana + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        public void AddPatientHistoryInfromation(Patient pa, Doctor dr, Clinic cl, PrescriptionClass pr)
        {
            try
            {
                string sql = @"insert into patienthistory (patientid,patientname,patientgender,patientemail,dateOfBirth,doctorid,date,time,clinicname,clinicid,divission,district,thana,symptom,disease,test,testclinicname,testclinicid,report,medicines) values ('" + pa.Userid + "','" + pa.Username + "','" + pa.Gender + "','" + pa.Email + "','" + pa.DateOfBirth + "','" + dr.Userid + "','" + dr.Date + "','" + dr.Time + "','" + cl.Username + "','" + cl.Userid + "','" + cl.Divission + "','" + cl.District + "','" + cl.Thana + "','" + pr.Symptom + "','" + pr.Diseases + "','" + pr.Test + "','" + pr.Testclinicname + "','" + pr.Testclinicid + "','" + pr.Report + "','" + pr.Medicines + "');";

                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
