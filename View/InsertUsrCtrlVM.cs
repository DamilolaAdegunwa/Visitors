using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitors.View
{
    class InsertUsrCtrlVM: ObservableObject, IDataErrorInfo
    {
        public string Error { get { return null; } }
        private string _username;
        private string _mobileno;
        private string _address;
        private string _gender;
        private string _emailid;
        private DateTime _dob;
        private string _pwd;
        private string _cpwd;
        private string _designation;


        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();
        string IDataErrorInfo.this[string name]
        {

            get
            {
                string res = null;
                switch (name)
                {
                    case "Username":
                        if (string.IsNullOrWhiteSpace(Username))
                            res = "Username cannot be empty";
                        break;
                    case "MobileNo":
                        if (string.IsNullOrWhiteSpace(MobileNo))
                            res = "MobileNo cannot be empty";
                        else if (MobileNo.Length < 10)
                            res = "MobileNo must be a of 10 characters.";
                        else if (MobileNo.Length > 10)
                            res= "MobileNo cannot be greater then 10 characters.";
                        break;

                    case "Address":
                        if (string.IsNullOrWhiteSpace(Address))
                            res = "Address cannot be empty";
                        break;
                    case "Gender":
                        if (string.IsNullOrWhiteSpace(Gender))
                            res = "Gender cannot be empty";
                        break;
                    case "EmailId":
                        if (string.IsNullOrWhiteSpace(EmailId))
                            res = "Address cannot be empty";
                        break;
                    case "DOB":
                        if (DOB == DateTime.Now)
                            res = "Select Date of birth";
                        break;
                    case "Password":
                        if (string.IsNullOrWhiteSpace(Password))
                            res = "Password cannot be empty";
                        break;
                    case "CPassword":
                        if (string.IsNullOrWhiteSpace(CPassword))
                            res = "Confirm Password cannot be empty";
                        else if (Password != CPassword)
                            res = "Confirm password doesnt match with password!!";
                        break;
                    case "Designation":
                        if (string.IsNullOrWhiteSpace(Designation))
                            res = "Designation cannot be empty";
                        break;


                }
                if (ErrorCollection.ContainsKey(name))
                    ErrorCollection[name] = res;
                else if (res != null)
                    ErrorCollection.Add(name, res);

                OnPropertyChanged("ErrorCollection");
                return res;
            }
        }



        public string Username
        {
            get { return _username; }
            set
            {
                OnPropertyChanged(ref _username, value);
            }
        }
        public string MobileNo
        {
            get { return _mobileno; }
            set
            {
                OnPropertyChanged(ref _mobileno, value);
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                OnPropertyChanged(ref _address, value);
            }
        }


        public string Gender
        {
            get { return _gender; }
            set
            {
                OnPropertyChanged(ref _gender, value);
            }
        }
        public string EmailId
        {
            get { return _emailid; }
            set
            {
                OnPropertyChanged(ref _emailid, value);
            }
        }

        public DateTime DOB
        {
            get { return _dob; }
            set
            {
                OnPropertyChanged(ref _dob, value);
            }
        }

        public string Password
        {
            get { return _pwd; }
            set
            {
                OnPropertyChanged(ref _pwd, value);
            }
        }
        public string CPassword
        {
            get { return _cpwd; }
            set
            {
                OnPropertyChanged(ref _cpwd, value);
            }
        }
        public string Designation
        {
            get { return _designation; }
            set
            {
                OnPropertyChanged(ref _designation, value);
            }
        }
    }
}
