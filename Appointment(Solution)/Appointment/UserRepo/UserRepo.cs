using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Model
using Appointment.Database;

namespace Appointment.UserRepo
{
    // Enum for results
    public enum ErrorCode { Success, Error }

    public class UserRepo
    {
        // Existing code for user registration
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
                    // Check if the username already exists
                    if (db.user_account.Any(u => u.username == userName))
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return ErrorCode.Error;
                    }

                    // If the username is unique, proceed with registration
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
