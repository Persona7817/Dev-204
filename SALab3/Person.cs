using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace SALab3
{
    public abstract class Person : IDisposable
    {
        private int age;
        private string gender;

        public string FirstName { get; set; }
        public string LastName{ get; set;}
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }


        public Person(string firstname, String lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        private bool disposed = false;
        StreamReader sr;
        StreamWriter sw;

        public void Read(string filename)
        {

            sr = new StreamReader(filename);


            try

            { 

                using(sr)
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }

            catch(Exception e)
            {
                Console.WriteLine("File Not found");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }

        }


        public void Write(string filename)
            {

                sw = new StreamWriter(filename);
                string[] lines = { this.FirstName, this.LastName, this.Gender, this.Age.ToString() };

                try

                {

                    using (sw)
                    {
                        foreach (string line in lines)
                        {
                            sw.WriteLine(line);
                        }

                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("This file could not be written");
                    
                }
                finally
                {
                    sr.Close();
                    sr = null;
                }


            }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
            disposed = true;
        }


    }

    }

