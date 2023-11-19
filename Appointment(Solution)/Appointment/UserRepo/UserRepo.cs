using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model
using Appointment.Database;

namespace Appointment.UserRepo
{
    // Enum for results
    public enum ErrorCode { Success, Error }
    public class UserRepo
    {
        // function for btnRegister
        public ErrorCode Register(int role, 
            string userName, 
            string userPassword,
            string fName,
            string phone,
            string emailAddress)
        {
            // Entities on try and catch
           try
            {
                using (var db = new ServicesEntities())
                {
                    var newUserObj = new user_account()
                    {
                        username = userName,
                        password = userPassword
                    };

                    var newInformationObj = new user_information()
                    {
                        full_name = fName,
                        phone_number = phone,
                        email_address = emailAddress,
                        role_id = role
                    };

                    // call database
                    db.user_account.Add(newUserObj);
                    db.user_information.Add(newInformationObj);
                   // db.userType.Add(newUserTypeObj);

                    db.SaveChanges();

                    return ErrorCode.Success;
                }
            }            
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return ErrorCode.Error;
            }
            
        }

    }
}
