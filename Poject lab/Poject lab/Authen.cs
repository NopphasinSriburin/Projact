using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poject_lab
{
    internal class Authen
    {
        private string _username;
        private string _password;
        private string _ID;
        private string _Brith;
        private string _Age;
        private string _Branch;

        private bool status;

        public bool Checkpassword(string username, string password)
        {
            this._username = username;
            this._password = password;

            string line;
            string filename = "C:\\Users\\nappa\\Desktop\\Poject lab\\Poject lab\\datauser.csv";
            StreamReader file = null;

            try
            {
                file = new StreamReader(filename);

                while ((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data[0] == username && data[1] == password)
                    {
                        return status = true;
                    }
                    else if (data[0]  != username && data[1] != password)
                    {
                        Console.WriteLine(String.Join(Environment.NewLine, line));
                    }
                    else
                    {
                        return status = false;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error: File not found.");
            }
            return status;

        }
        public bool singup(string username, string password , string ID , string Brith , string Age , string Branch)
        {
            this._username = username;
            this._password = password;
            this._ID = ID;
            this._Brith = Brith;
            this._Age = Age;
            this._Branch = Branch;

            string line;
            string filename = "C:\\Users\\nappa\\Desktop\\Poject lab\\Poject lab\\datauser.csv";
            StreamWriter file = null;

            try
            {
                file = File.AppendText(filename);

                string data = username + "," + password + "," + ID + "," + Brith + "," + Age + "," + Branch;
                file.WriteLine(data);
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: File not found.");
                return false;
            }

            return true;
        }
    }
}
