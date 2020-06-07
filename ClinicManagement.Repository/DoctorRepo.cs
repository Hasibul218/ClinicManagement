using ClinicManagement.Data;
using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement.Repository
{
    public class DoctorRepo
    {
        public void AddDoctorScheduleInfromation(Doctor dr, Clinic cl)
        {
            try
            {
                string sql = @"insert into doctorschedule (doctorid,doctorname,date,time,specialty,doctoremail,clinicname,clinicid,divission,district,thana) values ('" + dr.Userid + "','" + dr.Username + "','" + dr.Date + "','" + dr.Time + "','" + dr.Specialty + "','" + dr.Email + "','" + cl.Username + "','" + cl.Userid + "','" + cl.Divission + "','" + cl.District + "','" + cl.Thana + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        public void AddPatientWatingListInfromation(Patient pa, Doctor dr, Clinic cl)
        {
            try
            {
                string sql = @"insert into patientWatingList (patientid,patientname,patientgender,patientemail,dateOfBirth,doctorid,date,time,clinicname,clinicid,divission,district,thana) values ('" + pa.Userid + "','" + pa.Username + "','" + pa.Gender + "','" + pa.Email + "','" + pa.DateOfBirth + "','" + dr.Userid + "','" + dr.Date + "','" + dr.Time + "','" + cl.Username + "','" + cl.Userid + "','" + cl.Divission + "','" + cl.District + "','" + cl.Thana + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
